using System;
using System.Threading;
using System.Windows.Forms;

namespace Seb.NET.WeekTray
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            bool notStarted;
            var mutex = new Mutex(true, "weekTrayApplication", out notStarted);

            if (!notStarted)
            {
                return;
            }

            Application.Run(new Tray(args));

            GC.KeepAlive(mutex);
        }
    }
}