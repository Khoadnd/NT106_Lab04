using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
            // Default
            txtUrl.Text = @"http://uit.edu.vn";
            txtFileName.Text = @"uit.html";
        }

        private string Download(string url, string fileName)
        {
            var client = new WebClient();
            client.DownloadFile(url, fileName);

            var response = new StreamReader(client.OpenRead(url) ?? throw new Exception("Null response"));
            var responseData = response.ReadToEnd();
            response.Close();

            return responseData;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            rtxtContents.Clear();

            try
            {
                rtxtContents.AppendText(Download(txtUrl.Text.Trim(), txtFileName.Text.Trim()));
            }
            catch (Exception ex)
            {
                rtxtContents.AppendText(ex.Message);
            }
        }
    }
}
