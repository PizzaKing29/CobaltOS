using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
#nullable disable

namespace CobaltOS
{
    public partial class CobaltOS : Form
    {
        public CobaltOS()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            string user = Environment.UserName;
            WelcomeMessage.Text = $"Welcome to CobaltOS, {user}";
            CreateRestorePoint restorePoint = new CreateRestorePoint();
            // restorePoint.Show();
        }

        private void StartOptimizingButton_Click(object sender, EventArgs e)
        {
            if (TempFileCleaner.Checked)
            {
                PcOptimization.ClearTempFiles();
            }
            PcOptimization.gamingMode = GamingOptimization.Checked;

            if (AdjustPerformanceWindows.Checked)
            {
                PcOptimization.AdjustApperanceOfWindows();
            }
            if (TempFileCleaner.Checked)
            {
                PcOptimization.ClearTempFiles();
            }
            if (FasterDNS.Checked)
            {
                PcOptimization.SwitchDNS();
            }
        }

        private void BeginRepairButton_Click(object sender, EventArgs e)
        {

        }

        private void AdvancedStatsButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            if (DarkMode.Checked)
            {
                AppSettings.DarkMode();
                DarkMode.Checked = true;
                DarkMode.Refresh();
            }
        }

        private void ResetToDefaults_Click(object sender, EventArgs e)
        {
            DarkMode.Checked = false;
            DarkMode.Refresh();
        }
    }
}