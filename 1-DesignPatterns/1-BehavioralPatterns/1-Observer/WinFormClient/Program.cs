using System;
using System.Windows.Forms;
using WinFormClient.Entities.Alarms;


namespace WinFormClient
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Alarm alarm = new Alarm();

			Application.Run(new Form1(alarm));
		}
	}
}