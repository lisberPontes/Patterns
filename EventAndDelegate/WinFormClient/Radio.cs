﻿using System.Windows.Forms;
using WinFormClient.EventArguments;

namespace WinFormClient
{
	public class Radio
	{
		public void AlarmListener(object source, AlarmEventArgs args)
		{
			MessageBox.Show($@"Radio (subscriber) - {args.Location} - sender:{source.ToString()}");
		}
	}
}