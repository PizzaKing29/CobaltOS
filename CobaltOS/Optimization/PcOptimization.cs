using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaltOS
{
    public static class PcOptimization
    {
        public static bool gamingMode;

        public static void GamingOptimization()
        {
            var powershellFile = @"Optimization/PowerPlan.ps1";
            var StartInfo = new ProcessStartInfo
            {
                FileName = "Powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File \"{powershellFile}\" -GamingMode {gamingMode.ToString()}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            Process.Start(StartInfo);
        }

        public static void ClearTempFiles()
        {
            var powershellFile = @"CobaltOS/Optimization/CleanMgr.ps1";
            var StartInfo = new ProcessStartInfo
            {
                FileName = "Powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File \"{powershellFile}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            Process.Start(StartInfo);
        }

        public static void SwitchDNS()
        {
            var powershellFile = @"CobaltOS/Optimization/DNSSwitcher.ps1";
            var StartInfo = new ProcessStartInfo
            {
                FileName = "Powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File \"{powershellFile}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            Process.Start(StartInfo);
        }

        public static void AdjustApperanceOfWindows()
        {
            Process.Start("SystemPropertiesPerformance");
        }
    }
}