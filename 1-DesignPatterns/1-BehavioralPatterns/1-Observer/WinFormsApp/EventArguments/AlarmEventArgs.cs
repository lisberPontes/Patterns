using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.EventArguments
{
    internal sealed class AlarmEventArgs : EventArgs
    {
        public string Location { get; }

        public AlarmEventArgs(string location)
        {
            Location = location;
        }
    }
}
