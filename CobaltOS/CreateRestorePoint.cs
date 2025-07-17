using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CobaltOS
{
    public partial class CreateRestorePoint : Form
    {
        public CreateRestorePoint()
        {
            InitializeComponent();
        }

        private void CreateRestorePoint_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            TopMost = true;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Close();
            SystemRepair.CreateSystemRestorePoint();
            SystemRepair.BeginPcRepair();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Close();
            SystemRepair.BeginPcRepair();
        }
    }
}