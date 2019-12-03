﻿using System;
using WinFormClient.EventArguments;

namespace WinFormClient.Alarms
{
	public class Alarm
	{
		public event EventHandler<AlarmEventArgs> OnAlarmRaised = delegate { };

		public void RaiseAlarm(string location)
		{
			OnAlarmRaised(this, new AlarmEventArgs(location:location));
		}
	}
}