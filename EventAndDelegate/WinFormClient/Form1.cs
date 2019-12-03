using System;
using System.Windows.Forms;
using WinFormClient.Alarms;

namespace WinFormClient
{
	public partial class Form1 : Form
	{
		#region Publisher
		public Alarm Alarm { get; }
		#endregion

		#region Subscriber
		public Tv Tv { get; }
		public Radio Radio { get; }
		#endregion

		public Form1()
		{
			InitializeComponent();

			Alarm = new Alarm();

			Tv = new Tv(); 
			Radio = new Radio();

			Alarm.OnAlarmRaised += Tv.AlarmListener;
			Alarm.OnAlarmRaised += Radio.AlarmListener;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Alarm.RaiseAlarm(location:"Alarm raised from the main Form!");
		}
	}
}
