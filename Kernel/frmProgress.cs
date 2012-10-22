using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kernel
{
    public partial class frmProgress : Form
    {
        public delegate void ProgressLoop(frmProgress progress);

        private bool canceled = false;
        private ProgressLoop loop;

        public static void ShowProgress(Int64 max, Form owner, ProgressLoop loop)
        {
            frmProgress form = new frmProgress();
            form.pbProgress.Maximum = Convert.ToInt32(max);
            form.loop = loop;
            form.ShowDialog(owner);
        }

        public frmProgress()
        {
            InitializeComponent();
        }

        public bool Step()
        {
            ++pbProgress.Value;
            Application.DoEvents();
            return canceled;
        }

        public void Stop()
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            canceled = true;
        }

        private void frmProgress_FormClosing(object sender, FormClosingEventArgs e)
        {
            canceled = true;
        }

        private void frmProgress_Shown(object sender, EventArgs e)
        {
            loop(this);
            Stop();
        }
    }
}
