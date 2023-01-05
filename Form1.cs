using Microsoft.VisualBasic;
using System.Collections;

namespace TimmerApp
{
    public partial class Form1 : Form
    {
        private string? AppLocation;
        private string? AppLocationSettingsFile;
        private string? AppLocationAppsToStartFolder;
        private bool IsTickingTime = false;

        //---------------------Settings-----------------//

        private TimeSpan time = new TimeSpan(0,00,00);
        private bool IsOppeningAppsAtStatrup = false;
        private bool IsAlarmActive = false;
        public Form1()
        {
            InitializeComponent();
            GetSettings();
        }
        private void ToggleTimmer(object sender, EventArgs e)
        {
            if (IsTickingTime)
            {
                IsTickingTime = false;
            }
            else
            {
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

        }
        private void GetSettings()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            AppLocation = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            AppLocationAppsToStartFolder = $"{AppLocation}\\ShortcutsFolder";
            AppLocationSettingsFile = $"{AppLocation}\\Settings.txt";

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
                using (StreamWriter Stw = new(AppLocationSettingsFile))
                {
                    Stw.WriteLine($"Target Timne = {time}");
                    Stw.WriteLine($"Open apps at startup = {IsOppeningAppsAtStatrup}");
                    Stw.WriteLine($"Start alarm when on target time = {IsAlarmActive}");
                }
            }
        }
    }
}