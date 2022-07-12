namespace gamesense
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.copy_hwid = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // copy_hwid
            // 
            this.copy_hwid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copy_hwid.BackgroundImage")));
            this.copy_hwid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copy_hwid.FlatAppearance.BorderSize = 0;
            this.copy_hwid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy_hwid.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.copy_hwid.Location = new System.Drawing.Point(11, 275);
            this.copy_hwid.Margin = new System.Windows.Forms.Padding(2);
            this.copy_hwid.Name = "copy_hwid";
            this.copy_hwid.Size = new System.Drawing.Size(146, 35);
            this.copy_hwid.TabIndex = 13;
            this.copy_hwid.Text = "Copy HWID";
            this.copy_hwid.UseVisualStyleBackColor = true;
            this.copy_hwid.Click += new System.EventHandler(this.copy_hwid_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.back.Location = new System.Drawing.Point(345, 275);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(146, 35);
            this.back.TabIndex = 14;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 321);
            this.Controls.Add(this.back);
            this.Controls.Add(this.copy_hwid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader Panel";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button copy_hwid;
        private System.Windows.Forms.Button back;
    }
}