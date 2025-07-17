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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            string user = Environment.UserName;
            WelcomeMessage.Text = $"Welcome to CobaltOS, {user}";
            // MessageBox.Show("");
            CreateRestorePoint restorePoint = new CreateRestorePoint();
            restorePoint.Show();
        }

        private void SearchForDupedFiles_Click(object sender, EventArgs e)
        {
            
        }

        private void EnterBIOSButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}