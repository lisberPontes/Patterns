using System;

namespace WinFormClient.EventArguments
{
	public class AlarmEventArgs:EventArgs
	{
		public string Location { get; }

		public AlarmEventArgs(string location)
		{
			Location = location;
		}
	}
}