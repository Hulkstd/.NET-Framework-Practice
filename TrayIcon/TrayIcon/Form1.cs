using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VisibleChange(Boolean FormVisible, Boolean TrayIconVisible)
        {
            this.Visible = FormVisible;
            this.cmsPopup.Visible = TrayIconVisible;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false, false);
        }

        private void nyiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true, true);
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true, false);
        }
        private void 종료TollStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}