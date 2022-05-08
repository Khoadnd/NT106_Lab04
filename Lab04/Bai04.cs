using System;
using System.Threading;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai04 : Form
    {
        private static bool enabled = false;
        public Bai04()
        {
            enabled = true;
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            var updateThread = new Thread(new ThreadStart(Update));
            updateThread.Start();
        }

        private void Update()
        {
            while (enabled)
            {
                btnBack.Enabled = wbMain.CanGoBack;
                btnForward.Enabled = wbMain.CanGoForward;
                Thread.Sleep(100);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            wbMain.Navigate(txtURL.Text.Trim());
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGo.PerformClick();
        }

        // update url bar
        private void wbMain_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtURL.Text = wbMain.Url.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            wbMain.Refresh();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            wbMain.GoForward();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            wbMain.GoBack();
        }

        private void Bai04_FormClosed(object sender, FormClosedEventArgs e)
        {
            enabled = false;
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            var sourceView = new ViewSource(wbMain.DocumentText);
            sourceView.Show();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            wbMain.ShowSaveAsDialog();
        }
    }
}
