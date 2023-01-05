using System;
using System.Media;
using System.Runtime.InteropServices;

namespace TimmerApp
{
    public partial class Form1 : Form
    {
        private string? AppLocationSettingsFile = "Settings.txt";
        private string? AppLocationAppsToStartFolder = "ShortcutsFolder";
        private bool IsTickingTime = false;
        private TimeSpan MaxElapsedTime = new(0, 00, 20);
        private TimeSpan ElapsedTime = new(0, 00, 00);

        //---------------------Settings-----------------//

        private TimeSpan TargetTime = new(0, 00, 00);
        private bool IsOppeningAppsAtStatrup = true;
        private bool IsAlarmActive = true;
        public Form1()
        {
            InitializeComponent();
            GetSettings();

            //temp
            AllocConsole();
        }

        //temp
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
                TimeSpan TempSpan = ElapsedTime.Add(new TimeSpan(0, 00, 1));
                ElapsedTime = TempSpan;
                TimerNumbr_L.Text = string.Format("{0:h\\:mm\\:ss}", ElapsedTime);
                if (TargetTime > new TimeSpan(0,00,00) && ElapsedTime >= TargetTime && IsAlarmActive)
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

            if (!Directory.Exists(AppLocationAppsToStartFolder))
            {
                Directory.CreateDirectory(AppLocationAppsToStartFolder);
            }

            if (Directory.Exists(AppLocationSettingsFile))
            {
                using (StreamReader Str = new(AppLocationSettingsFile))
                {
                    
                }
            }
            else
            {
                RecreateSettingsFile();
            }
        }
        private void UpdateTimeSettings(object sender, EventArgs e)
        {
            if(AlarmTargetH_T.Text == "")
            {
                AlarmTargetH_T.Text = "0";
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
                    AlarmTargetH_T.Text = "0";
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
            IsAlarmActive = StartAlarm_Check.Checked;
            IsOppeningAppsAtStatrup = OpenAppsAtStartup_Check.Checked;
            RecreateSettingsFile();
        }
        private void RecreateSettingsFile()
        {
            using (StreamWriter Stw = new(AppLocationSettingsFile))
            {
                Stw.WriteLine($"Target Timne = {TargetTime}");
                Stw.WriteLine($"Open apps at startup = {IsOppeningAppsAtStatrup}");
                Stw.WriteLine($"Start alarm when on target time = {IsAlarmActive}");
            }
        }
        private void ForceStop()
        {
            IsTickingTime = false;
            ElapsedTime = new TimeSpan(0, 00, 00);
            ToggleTimmer_B.Text = "Start";
            TimerNumbr_L.Text = "0:00:00";

        }
    }
}