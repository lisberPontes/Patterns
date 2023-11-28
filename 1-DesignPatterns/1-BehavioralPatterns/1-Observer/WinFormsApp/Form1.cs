using System.Security.Claims;
using WinFormsApp.Entities.Alarms;
using WinFormsApp.Entities.Devices;

namespace WinFormsApp
{
    internal partial class Form1 : Form
    {
        #region Publisher
        private Alarm Alarm { get; }
        #endregion

        #region Subscriber
        private Tv Tv { get; } = new Tv();
        private Radio Radio { get; } = new Radio();
        #endregion

        public Form1(Alarm alarm)
        {
            InitializeComponent();

            Alarm = alarm;
            Alarm.OnAlarmRaised += Tv.AlarmListener;
            Alarm.OnAlarmRaised += Radio.AlarmListener;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alarm.RaiseAlarm(location: "Alarm raised from the main Form!");
        }

        protected override void OnClosed(EventArgs e)
        {
            Alarm.OnAlarmRaised -= Tv.AlarmListener;
            Alarm.OnAlarmRaised -= Radio.AlarmListener;

            base.OnClosed(e);
        }
    }
}