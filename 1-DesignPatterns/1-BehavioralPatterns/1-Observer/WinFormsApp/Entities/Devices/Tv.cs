using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.EventArguments;

namespace WinFormsApp.Entities.Devices
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
