using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaltOS
{
    public static class SystemActions
    {
        public static void Shutdown()
        {
            Process.Start("shutdown.exe", "-s -t 00");
        }

        public static void Restart()
        {
            Process.Start("shutdown.exe", "-r -t 00");
        }

        public static void Sleep()
        {

        }

        public static void EnterBios()
        {
            Process.Start("shutdown.exe", "/r /fw /t 0");
        }
    }
}