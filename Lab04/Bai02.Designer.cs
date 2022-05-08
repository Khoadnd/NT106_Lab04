namespace Lab04
{
    partial class Bai02
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
            this.btnPOST = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.rtxtContents = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPOST
            // 
            this.btnPOST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPOST.Location = new System.Drawing.Point(420, 12);
            this.btnPOST.Name = "btnPOST";
            this.btnPOST.Size = new System.Drawing.Size(75, 24);
            this.btnPOST.TabIndex = 0;
            this.btnPOST.Text = "POST";
            this.btnPOST.UseVisualStyleBackColor = true;
            this.btnPOST.Click += new System.EventHandler(this.btnPOST_Click);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(402, 24);
            this.txtURL.TabIndex = 1;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtData.Location = new System.Drawing.Point(12, 42);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(402, 24);
            this.txtData.TabIndex = 2;
            // 
            // rtxtContents
            // 
            this.rtxtContents.Location = new System.Drawing.Point(12, 72);
            this.rtxtContents.Name = "rtxtContents";
            this.rtxtContents.ReadOnly = true;
            this.rtxtContents.Size = new System.Drawing.Size(483, 366);
            this.rtxtContents.TabIndex = 3;
            this.rtxtContents.Text = "";
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.rtxtContents);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnPOST);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPOST;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.RichTextBox rtxtContents;
    }
}