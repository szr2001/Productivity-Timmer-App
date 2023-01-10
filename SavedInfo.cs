using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimmerApp
{
    public class SavedInfo
    {
        public TimeSpan TargetTime { get; set; }
        public TimeSpan LastTimerTime { get; set; }
        public bool IsAutoStartingTimmer { get; set; }
        public bool IsOppeningAppsAtStatrup { get; set; }
        public bool IsAlarmActive { get; set; }
        public bool IsResumingTime { get; set; }
        public int[] LastTimeOpenedDate { get; set; } = new int[3];
        public SavedInfo(TimeSpan targetTime, TimeSpan lastTimerTime, bool isAutoStartingTimmer, bool isOppeningAppsAtStatrup, bool isAlarmActive, bool isResumingTime, int[] lastTimeOpenedDate)
        {
            TargetTime = targetTime;
            LastTimerTime = lastTimerTime;
            IsAutoStartingTimmer = isAutoStartingTimmer;
            IsOppeningAppsAtStatrup = isOppeningAppsAtStatrup;
            IsAlarmActive = isAlarmActive;
            IsResumingTime = isResumingTime;
            LastTimeOpenedDate = lastTimeOpenedDate;
        }
    }
}
