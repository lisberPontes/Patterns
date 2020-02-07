using System.Windows.Forms;
using WinFormClient.EventArguments;

namespace WinFormClient.Entities.Devices
{
	internal sealed class Radio
	{
		public void AlarmListener(object source, AlarmEventArgs args)
		{
			MessageBox.Show($@"Radio (subscriber) - {args.Location} - sender:{source}",
				"Radio", 
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}
	}
}