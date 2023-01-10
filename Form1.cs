using System;
using System.Media;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.Json;

namespace TimmerApp
{
    public partial class Form1 : Form
    {
        private bool IsLoading = false;
        private string AppLocationSettingsFile = "Settings.json";
        private string AppsToStart = "ShortcutsFolder";
        private bool IsTickingTime = false;
        private string[]? ShortcutsDetected;
        private TimeSpan MaxElapsedTime = new(99, 59, 59);
        private TimeSpan ElapsedTime = new(00, 00, 00);

        private static DateOnly Today = DateOnly.FromDateTime(DateTime.Today);
        private static DateOnly LastTimeOpened = Today;

        private SavedInfo Settings = new
            (
                new(00, 00, 00),
                new(00, 00, 00),
                false,
                true,
                true,
                true,
                new int[3] { LastTimeOpened.Day, LastTimeOpened.Month, LastTimeOpened.Year}

            );
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
                if (Settings.TargetTime > new TimeSpan(00,00,00) && ElapsedTime >= Settings.TargetTime && Settings.IsAlarmActive)
                {
                    MakeAlarmSound();
                }
            }
            else
            {
                ForceStop();
            }
        }
        private static void MakeAlarmSound()
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
                try
                {
                    using (StreamReader Str = new(AppLocationSettingsFile))
                    {
                        
                        string jsonString = Str.ReadToEnd();
                        Settings = JsonSerializer.Deserialize<SavedInfo>(jsonString);

                        AlarmTargetH_T.Text = String.Format("{0:hh}", Settings.TargetTime);
                        AlarmTargetM_T.Text = String.Format("{0:mm}", Settings.TargetTime);
                        AlarmTargetS_T.Text = String.Format("{0:ss}", Settings.TargetTime);

                        LastTimeOpened = new DateOnly
                            (
                                Settings.LastTimeOpenedDate[2],
                                Settings.LastTimeOpenedDate[1],
                                Settings.LastTimeOpenedDate[0]
                            );

                        if (Settings.IsResumingTime && LastTimeOpened == Today)
                        {
                            ElapsedTime = Settings.LastTimerTime;
                            TimerNumbr_L.Text = $"{String.Format("{0:hh}", ElapsedTime)}:{String.Format("{0:mm}", ElapsedTime)}:{String.Format("{0:ss}", ElapsedTime)}";
                        }
                        Settings.LastTimeOpenedDate = new int[3] { Today.Day, Today.Month, Today.Year };
                        AutoStartTimmer_Check.Checked = Settings.IsAutoStartingTimmer;
                        OpenAppsAtStartup_Check.Checked = Settings.IsOppeningAppsAtStatrup;
                        StartAlarm_Check.Checked = Settings.IsAlarmActive;
                        ResumeTime_Check.Checked = Settings.IsResumingTime;
                    }
                }
                catch
                {
                    RecreateSettingsFile();
                }
                IsLoading = false;
            }
            else
            {
                RecreateSettingsFile();
            }
        }
        private void UpdateTimeSettings(object sender, EventArgs e)
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
            Settings.TargetTime = NewTimespan;
        }
        private void UpdateCheckBoxsesSettings(object sender, EventArgs e)
        {
            if (IsLoading)
            {
                return;
            }

            Settings.IsAlarmActive = StartAlarm_Check.Checked;
            Settings.IsOppeningAppsAtStatrup = OpenAppsAtStartup_Check.Checked;
            Settings.IsAutoStartingTimmer = AutoStartTimmer_Check.Checked;
            Settings.IsResumingTime = ResumeTime_Check.Checked;
        }
        private void RecreateSettingsFile()
        {
            using (StreamWriter Stw = new(AppLocationSettingsFile))
            {
                string jsonString = JsonSerializer.Serialize(Settings);
                Stw.Write(jsonString);
            }   
        }
        private void ForceStart()
        {
            if (Settings.IsAutoStartingTimmer)
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
            if (Settings.IsOppeningAppsAtStatrup)
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
        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            if (Settings.IsResumingTime)
            {
                Settings.LastTimerTime = ElapsedTime;
            }
            else
            {
                Settings.LastTimerTime = new TimeSpan(00, 00, 00);
            }
            RecreateSettingsFile();
        }
    }
}