using Microsoft.VisualBasic;
using System.Collections;

namespace TimmerApp
{
    public partial class Form1 : Form
    {
        private string? AppLocation;
        private string? AppLocationSettingsFolder;
        private string? AppLocationAppsToStartFolder;
        private bool IsTickingTime = false;
        //---------------------Settings-----------------//
        private TimeSpan time = new TimeSpan(0,00,00);
        private bool IsCountingAscending = true;
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
            AppLocation = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}