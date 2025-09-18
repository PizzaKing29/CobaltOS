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
            ScriptRunner.RunScriptButton(CodeTextBox, BatchfileRadioButton, PowershellRadioButton);
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            ScriptRunner.OpenFileButton(OpenFileScriptRunner);
        }
    }
}