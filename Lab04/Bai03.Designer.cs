namespace Lab04
{
    partial class Bai03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.rtxtContents = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDownload.Location = new System.Drawing.Point(450, 12);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 24);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(432, 24);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://uit.edu.vn";
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFileName.Location = new System.Drawing.Point(12, 42);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(432, 24);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.Text = "uit.html";
            // 
            // rtxtContents
            // 
            this.rtxtContents.Location = new System.Drawing.Point(12, 72);
            this.rtxtContents.Name = "rtxtContents";
            this.rtxtContents.ReadOnly = true;
            this.rtxtContents.Size = new System.Drawing.Size(513, 349);
            this.rtxtContents.TabIndex = 3;
            this.rtxtContents.Text = "";
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 433);
            this.Controls.Add(this.rtxtContents);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnDownload);
            this.Name = "Bai03";
            this.Text = "Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.RichTextBox rtxtContents;
    }
}