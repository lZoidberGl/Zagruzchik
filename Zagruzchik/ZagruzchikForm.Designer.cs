namespace Zagruzchik
{
    partial class ZagruzchikForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZagruzchikForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ProgressPanel = new System.Windows.Forms.Panel();
            this.ProgressPercent = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.VKcheck = new System.Windows.Forms.CheckBox();
            this.SettingsShow = new System.Windows.Forms.Button();
            this.GameStart = new System.Windows.Forms.Button();
            this.RusInstall = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Panel();
            this.GamePath = new System.Windows.Forms.GroupBox();
            this.GameStatusPanel = new System.Windows.Forms.Panel();
            this.GamePathText = new System.Windows.Forms.TextBox();
            this.GamePathBrowse = new System.Windows.Forms.Button();
            this.Gamebox = new System.Windows.Forms.GroupBox();
            this.GameInstall = new System.Windows.Forms.Button();
            this.GameStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RusPath = new System.Windows.Forms.GroupBox();
            this.RusStatusPanel = new System.Windows.Forms.Panel();
            this.RusPathText = new System.Windows.Forms.TextBox();
            this.RusPathBrowse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VKGroup = new System.Windows.Forms.Button();
            this.UpdaterTool = new System.Windows.Forms.Button();
            this.PrgAthr = new System.Windows.Forms.Label();
            this.MvblPnl1 = new System.Windows.Forms.Panel();
            this.testlabel = new System.Windows.Forms.Label();
            this.PrgVer = new System.Windows.Forms.Label();
            this.HideBtn = new System.Windows.Forms.Button();
            this.ExtBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tm1 = new System.Windows.Forms.Timer(this.components);
            this.tm2 = new System.Windows.Forms.Timer(this.components);
            this.testtm = new System.Windows.Forms.Timer(this.components);
            this.Unzipper = new System.ComponentModel.BackgroundWorker();
            this.MainPanel.SuspendLayout();
            this.ProgressPanel.SuspendLayout();
            this.Settings.SuspendLayout();
            this.GamePath.SuspendLayout();
            this.GameStatusPanel.SuspendLayout();
            this.Gamebox.SuspendLayout();
            this.RusPath.SuspendLayout();
            this.RusStatusPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MvblPnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.ProgressPanel);
            this.MainPanel.Controls.Add(this.VKcheck);
            this.MainPanel.Controls.Add(this.SettingsShow);
            this.MainPanel.Controls.Add(this.GameStart);
            this.MainPanel.Controls.Add(this.RusInstall);
            this.MainPanel.Controls.Add(this.Settings);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.MvblPnl1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(484, 545);
            this.MainPanel.TabIndex = 0;
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.Controls.Add(this.ProgressPercent);
            this.ProgressPanel.Controls.Add(this.progressBar);
            this.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressPanel.Location = new System.Drawing.Point(0, 230);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.Size = new System.Drawing.Size(484, 44);
            this.ProgressPanel.TabIndex = 12;
            this.ProgressPanel.Visible = false;
            // 
            // ProgressPercent
            // 
            this.ProgressPercent.BackColor = System.Drawing.Color.Transparent;
            this.ProgressPercent.Location = new System.Drawing.Point(404, 15);
            this.ProgressPercent.Name = "ProgressPercent";
            this.ProgressPercent.Size = new System.Drawing.Size(45, 20);
            this.ProgressPercent.TabIndex = 13;
            this.ProgressPercent.Text = "0%";
            this.ProgressPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar.Location = new System.Drawing.Point(40, 11);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(362, 26);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 12;
            // 
            // VKcheck
            // 
            this.VKcheck.AutoSize = true;
            this.VKcheck.Checked = true;
            this.VKcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VKcheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VKcheck.Location = new System.Drawing.Point(293, 193);
            this.VKcheck.Margin = new System.Windows.Forms.Padding(4);
            this.VKcheck.Name = "VKcheck";
            this.VKcheck.Size = new System.Drawing.Size(134, 21);
            this.VKcheck.TabIndex = 5;
            this.VKcheck.Text = "Посетить группу";
            this.VKcheck.UseVisualStyleBackColor = true;
            // 
            // SettingsShow
            // 
            this.SettingsShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsShow.BackgroundImage")));
            this.SettingsShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsShow.FlatAppearance.BorderSize = 0;
            this.SettingsShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingsShow.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsShow.Location = new System.Drawing.Point(62, 152);
            this.SettingsShow.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.SettingsShow.Name = "SettingsShow";
            this.SettingsShow.Size = new System.Drawing.Size(365, 39);
            this.SettingsShow.TabIndex = 9;
            this.SettingsShow.Text = "Настройки";
            this.SettingsShow.UseVisualStyleBackColor = true;
            this.SettingsShow.Click += new System.EventHandler(this.SettingsShow_Click);
            // 
            // GameStart
            // 
            this.GameStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameStart.BackgroundImage")));
            this.GameStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameStart.FlatAppearance.BorderSize = 0;
            this.GameStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameStart.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameStart.Location = new System.Drawing.Point(62, 108);
            this.GameStart.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(365, 39);
            this.GameStart.TabIndex = 10;
            this.GameStart.Text = "Запустить игру";
            this.GameStart.UseVisualStyleBackColor = true;
            this.GameStart.Click += new System.EventHandler(this.GameStart_Click);
            // 
            // RusInstall
            // 
            this.RusInstall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RusInstall.BackgroundImage")));
            this.RusInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RusInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RusInstall.FlatAppearance.BorderSize = 0;
            this.RusInstall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RusInstall.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RusInstall.Location = new System.Drawing.Point(62, 65);
            this.RusInstall.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.RusInstall.Name = "RusInstall";
            this.RusInstall.Size = new System.Drawing.Size(365, 39);
            this.RusInstall.TabIndex = 11;
            this.RusInstall.Text = "Установить русификатор";
            this.RusInstall.UseVisualStyleBackColor = true;
            this.RusInstall.Click += new System.EventHandler(this.RusInstall_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Controls.Add(this.GamePath);
            this.Settings.Controls.Add(this.Gamebox);
            this.Settings.Controls.Add(this.RusPath);
            this.Settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings.Location = new System.Drawing.Point(0, 274);
            this.Settings.Margin = new System.Windows.Forms.Padding(4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(484, 200);
            this.Settings.TabIndex = 8;
            this.Settings.Visible = false;
            // 
            // GamePath
            // 
            this.GamePath.Controls.Add(this.GameStatusPanel);
            this.GamePath.Controls.Add(this.GamePathBrowse);
            this.GamePath.Location = new System.Drawing.Point(40, 135);
            this.GamePath.Name = "GamePath";
            this.GamePath.Size = new System.Drawing.Size(405, 60);
            this.GamePath.TabIndex = 14;
            this.GamePath.TabStop = false;
            this.GamePath.Text = "Путь игры ";
            // 
            // GameStatusPanel
            // 
            this.GameStatusPanel.BackColor = System.Drawing.Color.Red;
            this.GameStatusPanel.Controls.Add(this.GamePathText);
            this.GameStatusPanel.ForeColor = System.Drawing.Color.Transparent;
            this.GameStatusPanel.Location = new System.Drawing.Point(6, 24);
            this.GameStatusPanel.Name = "GameStatusPanel";
            this.GameStatusPanel.Size = new System.Drawing.Size(358, 32);
            this.GameStatusPanel.TabIndex = 5;
            // 
            // GamePathText
            // 
            this.GamePathText.AllowDrop = true;
            this.GamePathText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamePathText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GamePathText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePathText.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GamePathText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(81)))), ((int)(((byte)(60)))));
            this.GamePathText.Location = new System.Drawing.Point(2, 2);
            this.GamePathText.Name = "GamePathText";
            this.GamePathText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GamePathText.Size = new System.Drawing.Size(354, 28);
            this.GamePathText.TabIndex = 2;
            this.GamePathText.TextChanged += new System.EventHandler(this.GamePathText_TextChanged);
            // 
            // GamePathBrowse
            // 
            this.GamePathBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GamePathBrowse.BackgroundImage")));
            this.GamePathBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GamePathBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GamePathBrowse.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GamePathBrowse.Location = new System.Drawing.Point(366, 24);
            this.GamePathBrowse.Name = "GamePathBrowse";
            this.GamePathBrowse.Size = new System.Drawing.Size(34, 32);
            this.GamePathBrowse.TabIndex = 3;
            this.GamePathBrowse.Text = "...";
            this.GamePathBrowse.UseVisualStyleBackColor = true;
            this.GamePathBrowse.Click += new System.EventHandler(this.GamePathBrowse_Click);
            // 
            // Gamebox
            // 
            this.Gamebox.Controls.Add(this.GameInstall);
            this.Gamebox.Controls.Add(this.GameStatus);
            this.Gamebox.Controls.Add(this.label2);
            this.Gamebox.Controls.Add(this.button1);
            this.Gamebox.Location = new System.Drawing.Point(40, 3);
            this.Gamebox.Name = "Gamebox";
            this.Gamebox.Size = new System.Drawing.Size(405, 60);
            this.Gamebox.TabIndex = 12;
            this.Gamebox.TabStop = false;
            this.Gamebox.Text = "Игра (Alpha)";
            // 
            // GameInstall
            // 
            this.GameInstall.BackgroundImage = global::Zagruzchik.Properties.Resources.ModernXP_74_Software_Install_icon;
            this.GameInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameInstall.Location = new System.Drawing.Point(359, 16);
            this.GameInstall.Name = "GameInstall";
            this.GameInstall.Size = new System.Drawing.Size(40, 40);
            this.GameInstall.TabIndex = 4;
            this.GameInstall.UseVisualStyleBackColor = true;
            this.GameInstall.Click += new System.EventHandler(this.GameInstall_Click);
            // 
            // GameStatus
            // 
            this.GameStatus.AutoSize = true;
            this.GameStatus.Location = new System.Drawing.Point(95, 28);
            this.GameStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameStatus.Name = "GameStatus";
            this.GameStatus.Size = new System.Drawing.Size(44, 17);
            this.GameStatus.TabIndex = 3;
            this.GameStatus.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Состояние:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RusPath
            // 
            this.RusPath.Controls.Add(this.RusStatusPanel);
            this.RusPath.Controls.Add(this.RusPathBrowse);
            this.RusPath.Location = new System.Drawing.Point(40, 69);
            this.RusPath.Name = "RusPath";
            this.RusPath.Size = new System.Drawing.Size(405, 60);
            this.RusPath.TabIndex = 13;
            this.RusPath.TabStop = false;
            this.RusPath.Text = "Путь русификатора";
            // 
            // RusStatusPanel
            // 
            this.RusStatusPanel.BackColor = System.Drawing.Color.Red;
            this.RusStatusPanel.Controls.Add(this.RusPathText);
            this.RusStatusPanel.ForeColor = System.Drawing.Color.Transparent;
            this.RusStatusPanel.Location = new System.Drawing.Point(6, 24);
            this.RusStatusPanel.Name = "RusStatusPanel";
            this.RusStatusPanel.Size = new System.Drawing.Size(358, 32);
            this.RusStatusPanel.TabIndex = 4;
            // 
            // RusPathText
            // 
            this.RusPathText.AllowDrop = true;
            this.RusPathText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RusPathText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RusPathText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RusPathText.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RusPathText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(81)))), ((int)(((byte)(60)))));
            this.RusPathText.Location = new System.Drawing.Point(2, 2);
            this.RusPathText.Name = "RusPathText";
            this.RusPathText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.RusPathText.Size = new System.Drawing.Size(354, 28);
            this.RusPathText.TabIndex = 4;
            this.RusPathText.TextChanged += new System.EventHandler(this.RusPathText_TextChanged);
            // 
            // RusPathBrowse
            // 
            this.RusPathBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RusPathBrowse.BackgroundImage")));
            this.RusPathBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RusPathBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RusPathBrowse.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RusPathBrowse.Location = new System.Drawing.Point(366, 24);
            this.RusPathBrowse.Name = "RusPathBrowse";
            this.RusPathBrowse.Size = new System.Drawing.Size(34, 32);
            this.RusPathBrowse.TabIndex = 3;
            this.RusPathBrowse.Text = "...";
            this.RusPathBrowse.UseVisualStyleBackColor = true;
            this.RusPathBrowse.Click += new System.EventHandler(this.RusPathBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VKGroup);
            this.panel1.Controls.Add(this.UpdaterTool);
            this.panel1.Controls.Add(this.PrgAthr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 474);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 71);
            this.panel1.TabIndex = 7;
            // 
            // VKGroup
            // 
            this.VKGroup.BackgroundImage = global::Zagruzchik.Properties.Resources.vklogo;
            this.VKGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VKGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VKGroup.FlatAppearance.BorderSize = 0;
            this.VKGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VKGroup.Location = new System.Drawing.Point(407, 16);
            this.VKGroup.Name = "VKGroup";
            this.VKGroup.Size = new System.Drawing.Size(40, 40);
            this.VKGroup.TabIndex = 7;
            this.VKGroup.UseVisualStyleBackColor = true;
            this.VKGroup.Click += new System.EventHandler(this.VKGroup_Click);
            // 
            // UpdaterTool
            // 
            this.UpdaterTool.BackgroundImage = global::Zagruzchik.Properties.Resources.refresh_note1;
            this.UpdaterTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdaterTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdaterTool.FlatAppearance.BorderSize = 0;
            this.UpdaterTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdaterTool.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.UpdaterTool.Location = new System.Drawing.Point(29, 13);
            this.UpdaterTool.Name = "UpdaterTool";
            this.UpdaterTool.Size = new System.Drawing.Size(41, 46);
            this.UpdaterTool.TabIndex = 6;
            this.UpdaterTool.UseVisualStyleBackColor = true;
            this.UpdaterTool.Click += new System.EventHandler(this.UpdaterTool_Click);
            // 
            // PrgAthr
            // 
            this.PrgAthr.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PrgAthr.Location = new System.Drawing.Point(161, 13);
            this.PrgAthr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrgAthr.Name = "PrgAthr";
            this.PrgAthr.Size = new System.Drawing.Size(159, 21);
            this.PrgAthr.TabIndex = 1;
            this.PrgAthr.Text = "label1";
            this.PrgAthr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MvblPnl1
            // 
            this.MvblPnl1.Controls.Add(this.testlabel);
            this.MvblPnl1.Controls.Add(this.PrgVer);
            this.MvblPnl1.Controls.Add(this.HideBtn);
            this.MvblPnl1.Controls.Add(this.ExtBtn);
            this.MvblPnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MvblPnl1.Location = new System.Drawing.Point(0, 0);
            this.MvblPnl1.Margin = new System.Windows.Forms.Padding(4);
            this.MvblPnl1.Name = "MvblPnl1";
            this.MvblPnl1.Size = new System.Drawing.Size(484, 54);
            this.MvblPnl1.TabIndex = 6;
            this.MvblPnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.MvblPnl1_Paint);
            this.MvblPnl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MvblPnl1_MouseDown);
            this.MvblPnl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MvblPnl1_MouseMove);
            this.MvblPnl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MvblPnl1_MouseUp);
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(220, 9);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(44, 17);
            this.testlabel.TabIndex = 3;
            this.testlabel.Text = "ТЕСТ";
            this.testlabel.Visible = false;
            // 
            // PrgVer
            // 
            this.PrgVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrgVer.Location = new System.Drawing.Point(26, 9);
            this.PrgVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrgVer.Name = "PrgVer";
            this.PrgVer.Size = new System.Drawing.Size(132, 38);
            this.PrgVer.TabIndex = 0;
            this.PrgVer.Text = "label1";
            this.PrgVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrgVer.Click += new System.EventHandler(this.PrgVer_Click);
            // 
            // HideBtn
            // 
            this.HideBtn.BackgroundImage = global::Zagruzchik.Properties.Resources.hide;
            this.HideBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideBtn.FlatAppearance.BorderSize = 0;
            this.HideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideBtn.Location = new System.Drawing.Point(359, 7);
            this.HideBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HideBtn.Name = "HideBtn";
            this.HideBtn.Size = new System.Drawing.Size(40, 40);
            this.HideBtn.TabIndex = 2;
            this.HideBtn.UseVisualStyleBackColor = true;
            this.HideBtn.Click += new System.EventHandler(this.HideBtn_Click);
            // 
            // ExtBtn
            // 
            this.ExtBtn.BackgroundImage = global::Zagruzchik.Properties.Resources._1455375866_DeleteRed;
            this.ExtBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExtBtn.FlatAppearance.BorderSize = 0;
            this.ExtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtBtn.Location = new System.Drawing.Point(407, 7);
            this.ExtBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExtBtn.Name = "ExtBtn";
            this.ExtBtn.Size = new System.Drawing.Size(40, 40);
            this.ExtBtn.TabIndex = 2;
            this.ExtBtn.UseVisualStyleBackColor = true;
            this.ExtBtn.Click += new System.EventHandler(this.ExtBtn_Click);
            // 
            // tm1
            // 
            this.tm1.Interval = 1;
            this.tm1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tm2
            // 
            this.tm2.Interval = 1;
            this.tm2.Tick += new System.EventHandler(this.tm2_Tick);
            // 
            // testtm
            // 
            this.testtm.Interval = 250;
            this.testtm.Tick += new System.EventHandler(this.testtm_Tick);
            // 
            // Unzipper
            // 
            this.Unzipper.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Unzipper_DoWork);
            this.Unzipper.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Unzipper_RunWorkerCompleted);
            // 
            // ZagruzchikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 545);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ZagruzchikForm";
            this.Text = "Загрузчик";
            this.TransparencyKey = System.Drawing.Color.Wheat;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ProgressPanel.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.GamePath.ResumeLayout(false);
            this.GameStatusPanel.ResumeLayout(false);
            this.GameStatusPanel.PerformLayout();
            this.Gamebox.ResumeLayout(false);
            this.Gamebox.PerformLayout();
            this.RusPath.ResumeLayout(false);
            this.RusStatusPanel.ResumeLayout(false);
            this.RusStatusPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.MvblPnl1.ResumeLayout(false);
            this.MvblPnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label PrgVer;
        private System.Windows.Forms.Label PrgAthr;
        private System.Windows.Forms.Label GameStatus;
        private System.Windows.Forms.CheckBox VKcheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MvblPnl1;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Button ExtBtn;
        private System.Windows.Forms.Button HideBtn;
        private System.Windows.Forms.Button SettingsShow;
        private System.Windows.Forms.Button GameStart;
        private System.Windows.Forms.Button RusInstall;
        private System.Windows.Forms.GroupBox GamePath;
        internal System.Windows.Forms.TextBox GamePathText;
        internal System.Windows.Forms.Button GamePathBrowse;
        private System.Windows.Forms.GroupBox Gamebox;
        private System.Windows.Forms.Button UpdaterTool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox RusPath;
        internal System.Windows.Forms.Button RusPathBrowse;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label ProgressPercent;
        private System.Windows.Forms.Panel ProgressPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel RusStatusPanel;
        internal System.Windows.Forms.TextBox RusPathText;
        private System.Windows.Forms.Panel GameStatusPanel;
        public System.Windows.Forms.Timer tm1;
        public System.Windows.Forms.Timer tm2;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.Timer testtm;
        private System.Windows.Forms.Button VKGroup;
        private System.ComponentModel.BackgroundWorker Unzipper;
        private System.Windows.Forms.Button GameInstall;
        private System.Windows.Forms.Button button1;
    }
}

