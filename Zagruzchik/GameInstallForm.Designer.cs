namespace Zagruzchik
{
    partial class GameInstallForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameInstallForm));
            this.InstallUpdateButton = new System.Windows.Forms.Button();
            this.ReinstallButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LabelMain = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.DownloadStatus = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.InstallPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstallUpdateButton
            // 
            this.InstallUpdateButton.Location = new System.Drawing.Point(14, 90);
            this.InstallUpdateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InstallUpdateButton.Name = "InstallUpdateButton";
            this.InstallUpdateButton.Size = new System.Drawing.Size(100, 35);
            this.InstallUpdateButton.TabIndex = 0;
            this.InstallUpdateButton.Text = "Установить";
            this.InstallUpdateButton.UseVisualStyleBackColor = true;
            this.InstallUpdateButton.Click += new System.EventHandler(this.InstallUpdateButton_Click);
            // 
            // ReinstallButton
            // 
            this.ReinstallButton.Location = new System.Drawing.Point(122, 90);
            this.ReinstallButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReinstallButton.Name = "ReinstallButton";
            this.ReinstallButton.Size = new System.Drawing.Size(160, 35);
            this.ReinstallButton.TabIndex = 1;
            this.ReinstallButton.Text = "Переустановить";
            this.ReinstallButton.UseVisualStyleBackColor = true;
            this.ReinstallButton.Click += new System.EventHandler(this.ReinstallButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(290, 91);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 35);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Location = new System.Drawing.Point(134, 9);
            this.LabelMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(139, 20);
            this.LabelMain.TabIndex = 3;
            this.LabelMain.Text = "Выберите действие";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(48, 32);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(341, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 4;
            // 
            // DownloadStatus
            // 
            this.DownloadStatus.Location = new System.Drawing.Point(15, 58);
            this.DownloadStatus.Name = "DownloadStatus";
            this.DownloadStatus.Size = new System.Drawing.Size(374, 28);
            this.DownloadStatus.TabIndex = 5;
            this.DownloadStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InstallPath
            // 
            this.InstallPath.Location = new System.Drawing.Point(15, 134);
            this.InstallPath.Name = "InstallPath";
            this.InstallPath.ReadOnly = true;
            this.InstallPath.Size = new System.Drawing.Size(374, 27);
            this.InstallPath.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(40, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Путь установки можно изменить в настройках! ";
            // 
            // CancelAsync
            // 
            this.CancelAsync.Location = new System.Drawing.Point(15, 32);
            this.CancelAsync.Name = "CancelAsync";
            this.CancelAsync.Size = new System.Drawing.Size(24, 24);
            this.CancelAsync.TabIndex = 9;
            this.CancelAsync.Text = "X";
            this.CancelAsync.UseVisualStyleBackColor = true;
            this.CancelAsync.Visible = false;
            this.CancelAsync.Click += new System.EventHandler(this.CancelAsync_Click);
            // 
            // GameInstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(403, 187);
            this.Controls.Add(this.CancelAsync);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InstallPath);
            this.Controls.Add(this.DownloadStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ReinstallButton);
            this.Controls.Add(this.InstallUpdateButton);
            this.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameInstallForm";
            this.Text = "Установка игры";
            this.Load += new System.EventHandler(this.GameInstallForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InstallUpdateButton;
        private System.Windows.Forms.Button ReinstallButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label DownloadStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox InstallPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelAsync;
    }
}