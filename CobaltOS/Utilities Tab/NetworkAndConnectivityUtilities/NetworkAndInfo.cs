using System.Diagnostics;
#nullable disable

namespace CobaltOS
{
    public static class NetworkAndInfo
    {
        public static void QuickIpAndMacInfo()
        {

        }

        public static void InternetSpeedTest()
        {
            // winget install --id=Ookla.Speedtest.CLI -e
            ProcessStartInfo process = new ProcessStartInfo("speedtest.exe")
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                FileName = $@"C:\\Users\\{ConstVariables.Username}\\AppData\\Local\\Microsoft\\WinGet\\Links\\speedtest.exe",
                Arguments = $"--accept-license --accept-gdpr",
                WorkingDirectory = $@"C:\Users\{ConstVariables.Username}",
            };
            var startProcess = Process.Start(process);
            string speedtestText = startProcess.StandardOutput.ReadToEnd();
            Clipboard.SetText(speedtestText);
            MessageBox.Show($"Speedtest Results (Also copied to clipboard):\n\n{ speedtestText}");


        }

        public static void QuickNetworkTroubleshooter()
        {
            
        }
    }

    public partial class CobaltOS
    {
        public void QuickIpButton_Click(object sender, EventArgs e)
        {
            NetworkAndInfo.QuickIpAndMacInfo();
        }

        public void NetworkTestButton_Click(object sender, EventArgs e)
        {
            NetworkAndInfo.InternetSpeedTest();
        }

        public void NetworkHelpButton_Click(object sender, EventArgs e)
        {
            NetworkAndInfo.QuickNetworkTroubleshooter();
        }
    }
}