using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
#nullable disable

namespace CobaltOS
{
    public partial class ScriptRunnerForm : Form
    {
        public ScriptRunnerForm()
        {
            InitializeComponent();
        }

        private void RunScriptButton_Click(object sender, EventArgs e)
        {
            string codeText = CodeTextBox.Text;
            string username = Environment.UserName;
            string fileType = "";
            string terminalType = "";
            if (BatchfileRadioButton.Checked)
            {
                fileType = "CobaltOSBatchfile.bat";
                terminalType = "cmd.exe";
            }
            else if(PowershellRadioButton.Checked)
            {
                fileType = "CobaltOSPowershell.ps1";
                terminalType = "powershell.exe";
            }

            string filePath = Path.Combine($@"C:\Users\{username}\Downloads", fileType);

            File.WriteAllText(filePath, codeText);
            ProcessStartInfo process = new ProcessStartInfo(terminalType)
            {
                UseShellExecute = true,
                Verb = "runas",
                WorkingDirectory = $@"C:\Users\{username}\Downloads",
                Arguments = $"/c \"{filePath}\"",
            };

            var runningScript = Process.Start(process);
            runningScript?.WaitForExit();
            File.Delete(filePath);
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileScriptRunner.ShowDialog();
            string selectedFile = OpenFileScriptRunner.FileName;
            string fileExtension = Path.GetExtension(selectedFile);
            string terminalType = "";
            if (fileExtension == ".bat")
            {
                terminalType = "cmd.exe";
            }
            else if (fileExtension == ".ps1")
            {
                terminalType = "powershell.exe";
            }

            ProcessStartInfo process = new ProcessStartInfo(terminalType)
            {
                UseShellExecute = true,
                Verb = "runas",
                WorkingDirectory = selectedFile,
                Arguments = $"/c \"{selectedFile}\""
            };

            Process.Start(process);
        }
    }
}