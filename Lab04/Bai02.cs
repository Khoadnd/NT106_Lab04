using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
            // Default
            txtURL.Text = @"http://www.contoso.com/PostAccepter.aspx";
        }

        private string Post(string url, string data)
        {
            var byteArray = Encoding.UTF8.GetBytes(data);

            var request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentLength = byteArray.Length;
            request.ContentType = "application/x-www-form-urlencoded";

            var requestStream = request.GetRequestStream();
            requestStream.Write(byteArray, 0, byteArray.Length);
            requestStream.Close();

            var response = request.GetResponse();
            var responseStream = new StreamReader(response.GetResponseStream() ?? throw new Exception("Null response"));
            var responseData = responseStream.ReadToEnd();
            response.Close();

            return responseData;
        }

        private void btnPOST_Click(object sender, EventArgs e)
        {
            rtxtContents.Clear();
            try
            {
                if (!txtURL.Text.StartsWith("http://"))
                    txtURL.Text = txtURL.Text.Insert(0, "http://");

                rtxtContents.AppendText(Post(txtURL.Text.Trim(), txtData.Text.Trim()));
            }
            catch (Exception ex)
            { rtxtContents.AppendText(ex.Message); }
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPOST.PerformClick();
        }
    }
}
