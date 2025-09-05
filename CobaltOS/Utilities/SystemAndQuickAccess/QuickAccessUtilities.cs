using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CobaltOS
{
    public static class QuickAccessUtilities
    {
        public static void OpenTaskManager()
        {
            Process.Start("taskmgr.exe");
        }

        public static void OpenCmdAsAdmin()
        {
            ProcessStartInfo process = new ProcessStartInfo();
            process.FileName = "cmd.exe";
            process.WorkingDirectory = @"C:\Windows\System32";
            Process.Start(process);
        }

        public static void OpenPowershellAsAdmin()
        {
            ProcessStartInfo process = new ProcessStartInfo();
            process.FileName = "powershell.exe";
            process.WorkingDirectory = @"C:\Windows\System32";
            Process.Start(process);
        }
        
        public static void GetRecentClipboard()
        {
            string recentClipboard = Clipboard.GetText();
            Clipboard.SetText(recentClipboard);
        }
    }

    public partial class Form1
    {
        public void OpenTaskManagerButton_Click(object sender, EventArgs e)
        {
            QuickAccessUtilities.OpenTaskManager();
        }

        public void OpenCmdButton_Click(object sender, EventArgs e)
        {
            QuickAccessUtilities.OpenCmdAsAdmin();
        }

        public void OpenPowershellButton_Click(object sender, EventArgs e)
        {
            QuickAccessUtilities.OpenPowershellAsAdmin();
        }

        public void GetClipboardButton_Click(object sender, EventArgs e)
        {

        }
    }
}