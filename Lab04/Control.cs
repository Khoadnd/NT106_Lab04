using System;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            var form = new Bai01();
            form.FormClosed += ChildFormClosedHandler;
            form.Show();
            Hide();
        }
        private void btnBai02_Click(object sender, EventArgs e)
        {
            var form = new Bai02();
            form.FormClosed += ChildFormClosedHandler;
            form.Show();
            Hide();
        }
        private void btnBai03_Click(object sender, EventArgs e)
        {
            var form = new Bai03();
            form.FormClosed += ChildFormClosedHandler;
            form.Show();
            Hide();
        }
        private void btnBai04_Click(object sender, EventArgs e)
        {
            var form = new Bai04();
            form.FormClosed += ChildFormClosedHandler;
            form.Show();
            Hide();
        }

        private void ChildFormClosedHandler(object sender, FormClosedEventArgs e)
        {
            Show();
            GC.Collect();
        }
    }
}
