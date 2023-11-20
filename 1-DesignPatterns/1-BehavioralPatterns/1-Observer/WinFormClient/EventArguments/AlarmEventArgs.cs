using System;

namespace WinFormClient.EventArguments
{
	internal sealed class AlarmEventArgs:EventArgs
	{
		public string Location { get; }

		public AlarmEventArgs(string location)
		{
			Location = location;
		}
	}
}