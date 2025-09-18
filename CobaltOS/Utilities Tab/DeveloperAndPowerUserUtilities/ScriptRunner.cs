using System.Diagnostics;

namespace CobaltOS
{
    public static class ScriptRunner
    {
        public static void RunScripts()
        {
            ScriptRunnerForm scriptRunner = new ScriptRunnerForm();
            scriptRunner.Show();
        }

        public static void RunScriptButton(TextBox CodeTextBox, RadioButton BatchfileRadioButton, RadioButton PowershellRadioButton)
        {
            string codeText = CodeTextBox.Text;
            string fileType = "";
            string terminalType = "";
            if (BatchfileRadioButton.Checked)
            {
                fileType = "CobaltOSBatchfile.bat";
                terminalType = "cmd.exe";
            }
            else if (PowershellRadioButton.Checked)
            {
                fileType = "CobaltOSPowershell.ps1";
                terminalType = "powershell.exe";
            }

            string filePath = Path.Combine($@"C:\Users\{ConstVariables.Username}\Downloads", fileType);

            File.WriteAllText(filePath, codeText);
            ProcessStartInfo process = new ProcessStartInfo(terminalType)
            {
                UseShellExecute = true,
                Verb = "runas",
                WorkingDirectory = $@"C:\Users\{ConstVariables.Username}\Downloads",
                Arguments = $"/c \"{filePath}\"",
            };

            Process.Start(process)?.WaitForExit();
            File.Delete(filePath);
        }

        public static void OpenFileButton(OpenFileDialog OpenFileScriptRunner)
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

    public partial class CobaltOS : Form
    {
        public void ScriptRunnerButton_Click(object sender, EventArgs e)
        {
            ScriptRunner.RunScripts();
        }
    }
}