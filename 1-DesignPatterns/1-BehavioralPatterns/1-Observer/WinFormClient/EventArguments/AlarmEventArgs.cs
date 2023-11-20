using System;

namespace WinFormClient.EventArguments
{
	internal sealed class AlarmEventArgs:EventArgs
	{
		public string Location { get; }

		public AlarmEventArgs3(string location)
		{
			Location = location;
		}
	}
}
