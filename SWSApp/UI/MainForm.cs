using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SWSApp.UI.Forms;

namespace SWSApp.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuAcademicYear_Click(object sender, EventArgs e)
        {
            foreach (var c in this.MdiChildren)
            {
                c.Close();
            }
            var uc = new AcademicYearForm();
            uc.MdiParent = this;
            uc.WindowState = FormWindowState.Maximized;
            uc.Dock = DockStyle.Fill;
            uc.StartPosition = FormStartPosition.CenterScreen;
            uc.Show();

        }
    }
}
