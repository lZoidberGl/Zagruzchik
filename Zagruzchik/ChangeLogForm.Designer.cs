namespace Zagruzchik
{
    partial class ChangeLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLogForm));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.MvblPnl1 = new System.Windows.Forms.Panel();
            this.HideBtn = new System.Windows.Forms.Button();
            this.ExtBtn = new System.Windows.Forms.Button();
            this.MvblPnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(58, 51);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(375, 250);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://dl.dropboxusercontent.com/s/x7ldu527j79cmbo/changelog.html?dl=0", System.UriKind.Absolute);
            // 
            // MvblPnl1
            // 
            this.MvblPnl1.BackColor = System.Drawing.Color.Transparent;
            this.MvblPnl1.Controls.Add(this.HideBtn);
            this.MvblPnl1.Controls.Add(this.ExtBtn);
            this.MvblPnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MvblPnl1.Location = new System.Drawing.Point(0, 0);
            this.MvblPnl1.Margin = new System.Windows.Forms.Padding(4);
            this.MvblPnl1.Name = "MvblPnl1";
            this.MvblPnl1.Size = new System.Drawing.Size(496, 40);
            this.MvblPnl1.TabIndex = 7;
            this.MvblPnl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MvblPnl1_MouseDown);
            this.MvblPnl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MvblPnl1_MouseMove);
            this.MvblPnl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MvblPnl1_MouseUp);
            // 
            // HideBtn
            // 
            this.HideBtn.BackColor = System.Drawing.Color.Transparent;
            this.HideBtn.BackgroundImage = global::Zagruzchik.Properties.Resources.hide;
            this.HideBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideBtn.FlatAppearance.BorderSize = 0;
            this.HideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideBtn.Location = new System.Drawing.Point(372, 4);
            this.HideBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HideBtn.Name = "HideBtn";
            this.HideBtn.Size = new System.Drawing.Size(40, 40);
            this.HideBtn.TabIndex = 2;
            this.HideBtn.UseVisualStyleBackColor = false;
            this.HideBtn.Click += new System.EventHandler(this.HideBtn_Click);
            // 
            // ExtBtn
            // 
            this.ExtBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExtBtn.BackgroundImage = global::Zagruzchik.Properties.Resources._1455375866_DeleteRed;
            this.ExtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExtBtn.FlatAppearance.BorderSize = 0;
            this.ExtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtBtn.Location = new System.Drawing.Point(420, 4);
            this.ExtBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExtBtn.Name = "ExtBtn";
            this.ExtBtn.Size = new System.Drawing.Size(40, 40);
            this.ExtBtn.TabIndex = 2;
            this.ExtBtn.UseVisualStyleBackColor = false;
            this.ExtBtn.Click += new System.EventHandler(this.ExtBtn_Click);
            // 
            // ChangeLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 354);
            this.Controls.Add(this.MvblPnl1);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeLogForm";
            this.Text = "Изменения";
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.MvblPnl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel MvblPnl1;
        private System.Windows.Forms.Button HideBtn;
        private System.Windows.Forms.Button ExtBtn;
    }
}