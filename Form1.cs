using System;
using System.Media;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Xml.Serialization;

namespace TimmerApp
{
    public partial class Form1 : Form
    {
        private string AppLocationSettingsFile = "Settings.txt";
        private string AppsToStart = "ShortcutsFolder";
        private bool IsTickingTime = false;
        private string[]? ShortcutsDetected;
        private TimeSpan MaxElapsedTime = new(99, 59, 59);
        private TimeSpan ElapsedTime = new(00, 00, 00);
        private bool IsLoading = false;

        //---------------------Settings-----------------//

        private TimeSpan TargetTime = new(00, 00, 00);
        private bool IsOppeningAppsAtStatrup = true;
        private bool IsAlarmActive = true;
        private bool IsAutoStartingTimmer = false;
        public Form1()
        {
            InitializeComponent();
            //Call Console
            //AllocConsole();

            GetSettings();
            ForceStart();
            StartShorcuts();
        }

        //Console Dll Inport
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        //

        private void ToggleTimmer(object sender, EventArgs e)
        {
            if (IsTickingTime)
            {
                ToggleTimmer_B.Text = "Start";
                IsTickingTime = false;
            }
            else
            {
                ToggleTimmer_B.Text = "Stop";
                IsTickingTime = true;
                TickTime();
            }
        }
        private async void TickTime()
        {
            CalculateSeconds();
            await Task.Delay(1000);
            if (IsTickingTime)
            {
                TickTime();
            }
        }
        private void CalculateSeconds()
        {
            if (ElapsedTime < MaxElapsedTime)
            {
                TimeSpan TempSpan = ElapsedTime.Add(new TimeSpan(00, 00, 01));
                ElapsedTime = TempSpan;
                TimerNumbr_L.Text = string.Format("{0:hh\\:mm\\:ss}", ElapsedTime);
                if (TargetTime > new TimeSpan(00,00,00) && ElapsedTime >= TargetTime && IsAlarmActive)
                {
                    MakeAlarmSound();
                }
            }
            else
            {
                ForceStop();
            }
        }
        private void MakeAlarmSound()
        {
            SoundPlayer Sp = new("Resources/Audio/AlarmSound.wav");
            Sp.Play();
        }
        private void GetSettings()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            if (!Directory.Exists(AppsToStart))
            {
                Directory.CreateDirectory(AppsToStart);
            }
            if (File.Exists(AppLocationSettingsFile))
            {
                IsLoading = true;
                using (StreamReader Str = new(AppLocationSettingsFile))
                {
                    List<string> Settings = new();
                    Settings.Add(Str.ReadLine());
                    Settings.Add(Str.ReadLine());
                    Settings.Add(Str.ReadLine());
                    Settings.Add(Str.ReadLine());
                    TargetTime =  new TimeSpan
                        (
                            int.Parse(Settings[0].Split('=')[1].Split(':')[0]),
                            int.Parse(Settings[0].Split('=')[1].Split(':')[1]),
                            int.Parse(Settings[0].Split('=')[1].Split(':')[2])
                        );
                    AlarmTargetH_T.Text = String.Format("{0:hh}", TargetTime);
                    AlarmTargetM_T.Text = String.Format("{0:mm}", TargetTime);
                    AlarmTargetS_T.Text = String.Format("{0:ss}", TargetTime);

                    IsOppeningAppsAtStatrup = Convert.ToBoolean(Settings[1].Split('=')[1]);
                    OpenAppsAtStartup_Check.Checked = IsOppeningAppsAtStatrup;

                    IsAlarmActive = Convert.ToBoolean(Settings[2].Split('=')[1]);
                    StartAlarm_Check.Checked = IsAlarmActive;

                    IsAutoStartingTimmer = Convert.ToBoolean(Settings[3].Split('=')[1]);
                    AutoStartTimmer_Check.Checked = IsAutoStartingTimmer;
                }
                IsLoading = false;
            }
            else
            {
                RecreateSettingsFile();
            }
        }
        private void UpdateTimeSettings(object sender, EventArgs e) // problem
        {
            if (IsLoading)
            {
                return;
            }
            if(AlarmTargetH_T.Text == "")
            {
                AlarmTargetH_T.Text = "00";
                return;
            }
            if (AlarmTargetM_T.Text == "")
            {
                AlarmTargetM_T.Text = "00";
                return;
            }
            if (AlarmTargetS_T.Text == "")
            {
                AlarmTargetS_T.Text = "00";
                return;
            }
            string CombinedStrings = $"{AlarmTargetH_T.Text}{AlarmTargetM_T.Text}{AlarmTargetS_T.Text}";
            foreach(char C in CombinedStrings)
            {
                if(!char.IsDigit(C))
                {
                    AlarmTargetH_T.Text = "00";
                    AlarmTargetM_T.Text = "00";
                    AlarmTargetS_T.Text = "00";
                    return;
                }
            }
            TimeSpan NewTimespan = new(int.Parse(AlarmTargetH_T.Text), int.Parse(AlarmTargetM_T.Text), int.Parse(AlarmTargetS_T.Text));
            TargetTime = NewTimespan;
            RecreateSettingsFile();
        }
        private void UpdateCheckBoxsesSettings(object sender, EventArgs e)
        {
            if (!IsLoading)
            {
                IsAlarmActive = StartAlarm_Check.Checked;
                IsOppeningAppsAtStatrup = OpenAppsAtStartup_Check.Checked;
                IsAutoStartingTimmer = AutoStartTimmer_Check.Checked;
                RecreateSettingsFile();
            }
        }
        private void RecreateSettingsFile()
        {
            using (StreamWriter Stw = new(AppLocationSettingsFile))
            {
                Stw.WriteLine($"Target Time = {string.Format("{0:hh\\:mm\\:ss}", TargetTime)}");
                Stw.WriteLine($"Open apps at startup = {IsOppeningAppsAtStatrup}");
                Stw.WriteLine($"Start alarm when on target time = {IsAlarmActive}");
                Stw.WriteLine($"Start timmer on Startup = {IsAutoStartingTimmer}");
            }
        }
        private void ForceStart()
        {
            if (IsAutoStartingTimmer)
            {
                ToggleTimmer_B.Text = "Stop";
                IsTickingTime = true;
                TickTime();
            }
        }
        private void ForceStop()
        {
            IsTickingTime = false;
            ElapsedTime = new TimeSpan(00, 00, 00);
            ToggleTimmer_B.Text = "Start";
            TimerNumbr_L.Text = "00:00:00";

        }
        private void StartShorcuts()
        {
            if (IsOppeningAppsAtStatrup)
            {
                ShortcutsDetected = Directory.GetFiles(AppsToStart);
                foreach(string directory in ShortcutsDetected)
                {
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(directory)
                    {
                        UseShellExecute = true
                    };
                    p.Start();
                }
            }
        }
    }
}