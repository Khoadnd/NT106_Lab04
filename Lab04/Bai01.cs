using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private string GetHTML(string url)
        {
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var html = new StreamReader(response.GetResponseStream() ?? throw new Exception("Null response"));
            var data = html.ReadToEnd();
            html.Close();
            return data;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            rtxtContents.Clear();

            try
            {
                if (!txtURL.Text.StartsWith("http://"))
                    txtURL.Text = txtURL.Text.Insert(0, "http://");

                rtxtContents.AppendText(GetHTML(txtURL.Text.Trim()));
            }
            catch (Exception ex)
            { rtxtContents.AppendText(ex.Message); }
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGet.PerformClick();
        }
    }
}
