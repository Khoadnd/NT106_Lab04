namespace Lab04
{
    partial class Control
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
            this.btnBai01 = new System.Windows.Forms.Button();
            this.btnBai02 = new System.Windows.Forms.Button();
            this.btnBai03 = new System.Windows.Forms.Button();
            this.btnBai04 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBai01
            // 
            this.btnBai01.Location = new System.Drawing.Point(12, 12);
            this.btnBai01.Name = "btnBai01";
            this.btnBai01.Size = new System.Drawing.Size(75, 23);
            this.btnBai01.TabIndex = 0;
            this.btnBai01.Text = "Bai 01";
            this.btnBai01.UseVisualStyleBackColor = true;
            this.btnBai01.Click += new System.EventHandler(this.btnBai01_Click);
            // 
            // btnBai02
            // 
            this.btnBai02.Location = new System.Drawing.Point(12, 41);
            this.btnBai02.Name = "btnBai02";
            this.btnBai02.Size = new System.Drawing.Size(75, 23);
            this.btnBai02.TabIndex = 1;
            this.btnBai02.Text = "Bai 02";
            this.btnBai02.UseVisualStyleBackColor = true;
            this.btnBai02.Click += new System.EventHandler(this.btnBai02_Click);
            // 
            // btnBai03
            // 
            this.btnBai03.Location = new System.Drawing.Point(156, 12);
            this.btnBai03.Name = "btnBai03";
            this.btnBai03.Size = new System.Drawing.Size(75, 23);
            this.btnBai03.TabIndex = 2;
            this.btnBai03.Text = "Bai 03";
            this.btnBai03.UseVisualStyleBackColor = true;
            this.btnBai03.Click += new System.EventHandler(this.btnBai03_Click);
            // 
            // btnBai04
            // 
            this.btnBai04.Location = new System.Drawing.Point(156, 41);
            this.btnBai04.Name = "btnBai04";
            this.btnBai04.Size = new System.Drawing.Size(75, 23);
            this.btnBai04.TabIndex = 3;
            this.btnBai04.Text = "Bai 04";
            this.btnBai04.UseVisualStyleBackColor = true;
            this.btnBai04.Click += new System.EventHandler(this.btnBai04_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 73);
            this.Controls.Add(this.btnBai04);
            this.Controls.Add(this.btnBai03);
            this.Controls.Add(this.btnBai02);
            this.Controls.Add(this.btnBai01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Control";
            this.Text = "Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBai01;
        private System.Windows.Forms.Button btnBai02;
        private System.Windows.Forms.Button btnBai03;
        private System.Windows.Forms.Button btnBai04;
    }
}

