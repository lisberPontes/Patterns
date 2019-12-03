using System.Windows.Forms;
using WinFormClient.EventArguments;

namespace WinFormClient
{
	public class Tv
	{
		public void AlarmListener(object source, AlarmEventArgs args)
		{
			MessageBox.Show($@"TV (subscriber) - {args.Location} - sender:{source.ToString()}");
		}
	}
}