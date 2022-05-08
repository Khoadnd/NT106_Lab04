namespace Lab04
{
    partial class ViewSource
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
            this.rtxtSource = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtSource
            // 
            this.rtxtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtSource.Location = new System.Drawing.Point(0, 0);
            this.rtxtSource.Name = "rtxtSource";
            this.rtxtSource.ReadOnly = true;
            this.rtxtSource.Size = new System.Drawing.Size(800, 450);
            this.rtxtSource.TabIndex = 0;
            this.rtxtSource.Text = "";
            // 
            // ViewSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewSource";
            this.Text = "ViewSource";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtSource;
    }
}