using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.EventArguments;

namespace WinFormsApp.Entities.Alarms
{
    internal sealed class Alarm
    {
        public event EventHandler<AlarmEventArgs> OnAlarmRaised = delegate { };

        public void RaiseAlarm(string location)
        {
            OnAlarmRaised(this, new AlarmEventArgs(location: location));
        }
    }
}
