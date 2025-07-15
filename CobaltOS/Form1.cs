using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CobaltOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string User = Environment.UserName;
            WelcomeMessage.Text = $"Welcome to CobaltOS, {User}";
        }

        private void ShutdownPC_Click(object sender, EventArgs e)
        {
            SystemActions.Shutdown();
        }

        private void RestartPC_Click(object sender, EventArgs e)
        {
            SystemActions.Restart();
        }

        private void SleepPC_Click(object sender, EventArgs e)
        {
            SystemActions.Sleep();
        }

        private void EnableOrDisableDefenderButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchForDupedFiles_Click(object sender, EventArgs e)
        {
            
        }

        private void EnterBIOSButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}