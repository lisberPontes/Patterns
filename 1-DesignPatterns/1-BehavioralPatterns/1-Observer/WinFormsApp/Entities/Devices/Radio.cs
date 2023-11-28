using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.EventArguments;

namespace WinFormsApp.Entities.Devices
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
