using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace CobaltOS
{
    public static class PowerOptions
    {
        public static void EnterBios()
        {
            ProcessStartInfo process = new ProcessStartInfo("shutdown", "/r /fw /t 0")
            {
                UseShellExecute = true,
                Verb = "runas"
            };
            Process.Start(process);
        }

        public static void EnterSafeMode()
        {
            ProcessStartInfo process = new ProcessStartInfo("bcdedit", "/set {current} safeboot minimal")
            {
                UseShellExecute = true,
                Verb = "runas"
            };
            ProcessStartInfo restart = new ProcessStartInfo("shutdown", "/r /t 0")
            {
                UseShellExecute = true,
                Verb = "runas"
            };
            Process.Start(process).WaitForExit();
            Process.Start(restart);
        }
    }

    public partial class CobaltOS
    {
        public void EnterBIOSButton_Click(object sender, EventArgs e)
        {
            PowerOptions.EnterBios();
        }

        public void EnterSafeModeButton_Click(object sender, EventArgs e)
        {
            PowerOptions.EnterSafeMode();
        }
    }
}