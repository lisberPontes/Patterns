using System.Windows.Forms;
using WinFormClient.EventArguments;

namespace WinFormClient.Entities.Devices
{
	internal sealed class Tv
	{
		public void AlarmListener(object source, AlarmEventArgs args)
		{
			MessageBox.Show($@"TV (subscriber) - {args.Location} - sender:{source}",
				"TV",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}
	}
}