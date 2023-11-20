using System;
using WinFormClient.EventArguments;

namespace WinFormClient.Entities.Alarms
{
	internal sealed class Alarm
	{
		public event EventHandler<AlarmEventArgs> OnAlarmRaised = delegate { };

		public void RaiseAlarm(string location)
		{
			OnAlarmRaised(this, new AlarmEventArgs(location:location));
		}
	}
}