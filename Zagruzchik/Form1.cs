using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.IO.Compression;
using System.Threading;

namespace Zagruzchik
{

    public partial class Form1 : Form

    {
        internal Form1()
        {
            InitializeComponent();
        }
        WebClient Client = new WebClient();
        int mouseX = 0, mouseY = 0;
        bool mousedown;
        //28; 170 - panel1 defloc
        //28; 433 - panel1 advloc
        internal void Form1_Load(object sender, EventArgs e)
        {
            this.Height = this.Height - 220;
            PrgVer.TextAlign = ContentAlignment.TopLeft;

            PrgVer.Text = Application.ProductVersion + " Epsilon";
            PrgAthr.Text = "Сделал |ZoidberG|";
            SettingsShow.Text = "Показать настройки";
            RusPathText.Text = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents","Windward");
            GamePathText.Text = Path.Combine(Application.StartupPath, "Windward");
        }

        private void TestCheck()
        {
            if (Application.StartupPath == @"I:\Projects\Progs\Zagruzchik\Zagruzchik\bin\Debug")
                testtm.Enabled = true;
        }

        private void RusCheckVer()
        {
            try
            {
                string NewVer = Client.DownloadString(new Uri("https://dl.dropboxusercontent.com/s/030uxgro39pu41m/rusver.txt?dl=1")); //https://www.dropbox.com/s/030uxgro39pu41m/rusver.txt?dl=0
                string ThisVer = File.ReadAllText(Path.Combine(RusPathText.Text, "mods", "translateMod", "version.txt"));
                if (NewVer.Contains(ThisVer))
                {
                    MessageBox.Show("У вас последняя версия русификатора!");
                }
                else
                {
                    MessageBox.Show("Доступна более новая версия русификатора!" + Environment.NewLine + "Доступная версия: V" + NewVer + Environment.NewLine + "Ваша версия: V" + ThisVer);
                }
            }
            catch { MessageBox.Show("Не удалось обнаружить файл версии русификатора. Проверка версии невозможна!"); }
        }

        private void RusCheck()
        {
            if (File.Exists(Path.Combine(RusPathText.Text, "mods", "translateMod", "Localization.txt")))
            {
                RusStatusPanel.BackColor = Color.Green;
                RusInstall.Text = "Обновить русификатор";
            }
            else
            {
                RusStatusPanel.BackColor = Color.Red;
                RusInstall.Text = "Установить русификатор";
            }
        }

        private void GameCheck()
        {
           /* if (File.Exists(Path.Combine("Windward", "Windward.exe")))
            {
                GameStatus.Text = "Установлена";
                GameStatus.ForeColor = Color.Green;
                GameStatusPanel.BackColor = Color.Green;
                GameInstall.BackgroundImage = Properties.Resources.installmade;
            }
            else*/ if (File.Exists(Path.Combine(GamePathText.Text, "Windward.exe")))
            {
                GameStatus.Text = "Установлена";
                GameStatus.ForeColor = Color.Green;
                GameStatusPanel.BackColor = Color.Green;
                GameInstall.BackgroundImage = Properties.Resources.installmade;
            }
            else
            {
                GameStatus.Text = "Отсутствует";
                GameStatus.ForeColor = Color.Red;
                GameStatusPanel.BackColor = Color.Red;
                GameInstall.BackgroundImage = Properties.Resources.ModernXP_74_Software_Install_icon;
            }
        }

        private void ExtractZip(string path, string destination)
        {
            try
            {
                ZipFile.ExtractToDirectory(path, destination);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void UnPack()
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            if (File.Exists(Path.Combine(RusPathText.Text, "Localization.zip")))
            {
                UnzipFile(Path.Combine(RusPathText.Text, "Localization.zip"), RusPathText.Text);
                try { File.Delete(Path.Combine(RusPathText.Text, "Localization.zip")); }
                catch { }
                MessageBox.Show("Готово! Русификатор установлен!");
                if (VKcheck.Checked)
                    Process.Start("http://new.vk.com/windwardgame");
            }

            if (File.Exists("update.zip"))
            {
                try { ExtractZip("update.zip", Application.StartupPath); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                try { File.Delete("update.zip"); }
                catch { }
                MessageBox.Show("Готово! Новая версия программы загружена!/nПрограмма будет перезапущена.");               
                CmdWork();
                if (VKcheck.Checked)
                    Process.Start("http://new.vk.com/windwardgame");
            }
            ProgressPanel.Visible = false;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;           
            ProgressPercent.Text = e.ProgressPercentage.ToString() + "%";
        }
        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            try { UnPack(); }
            catch { MessageBox.Show("Ошибка:  " + e.Error); }
        }
        private void RusInstall_Click(object sender, EventArgs e)
          {
            Client.DownloadProgressChanged += Client_DownloadProgressChanged;
            Client.DownloadFileCompleted += Client_DownloadFileCompleted;
            try {
            Client.DownloadFileAsync(new Uri("https://dl.dropboxusercontent.com/s/9ava21ao6aefzkt/Localization.zip?dl=1"), Path.Combine(RusPathText.Text , "Localization.zip"));
                ProgressPanel.Visible = true;
            }
            catch {
                try
                {
                    File.Delete(Path.Combine(RusPath.Text, "Localization.zip"));
                    Client.DownloadFileAsync(new Uri("https://dl.dropboxusercontent.com/s/9ava21ao6aefzkt/Localization.zip?dl=1"), Path.Combine(RusPath.Text, "Localization.zip"));
                    ProgressPanel.Visible = true;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
           }

        private void MvblPnl1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void MvblPnl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void MvblPnl1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HideBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void UpdaterTool_Click(object sender, EventArgs e)
        {
            try { ProgramUpdate();               
            }           
            catch { MessageBox.Show("Возникли неполадки с проверкой версии. Проверьте соединение с интернетом и перезапустите программу."); }
        }

        private void CmdWork()
        {
            var delpath = Environment.CurrentDirectory + "\\Zagruzchik.exe";
            var movepath = Environment.CurrentDirectory + "\\Update.exe";
            var killproc = "Zagruzchik.exe";

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = string.Format("/C taskkill /IM \"{0}\" & Timeout 1  & Del /F \"{1}\" & Move /Y \"{2}\" \"{1}\" & START \"\" \"{1}\"", killproc, delpath, movepath);
            process.Start();
        }

        private void TEST()
        {

        }


        private void ProgramUpdate()
        {
            string NewVer = Client.DownloadString(new Uri("https://dl.dropboxusercontent.com/s/7lxyq9ks0tut177/versionNew.txt?dl=1")); //https://www.dropbox.com/s/7lxyq9ks0tut177/versionNew.txt?dl=0
            string ThisVer = Application.ProductVersion;
            if (NewVer.Contains(ThisVer))
                MessageBox.Show("У вас последня версия!");
            else
            {
                DialogResult dialog = MessageBox.Show("Доступна более новая версия под номером: " + NewVer + "Хотите ли обновиться?", "Запрос", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    MessageBox.Show("Сейчас будет загружена новая версия!");
                    ProgramUpdateDownload();
                }
                else if (dialog == DialogResult.No)
                {
                    
                }
            }
        }

        private void ProgramUpdateDownload()
        {
            Client.DownloadProgressChanged += Client_DownloadProgressChanged;
            Client.DownloadFileCompleted += Client_DownloadFileCompleted;

            ProgressPanel.Visible = true;

            if (File.Exists("update.zip"))
                File.Delete("update.zip");

            Client.DownloadFileAsync(new Uri("https://dl.dropboxusercontent.com/s/mcvpepnqqt2goge/Update.zip?dl=1"), "update.zip"); //https://www.dropbox.com/s/mcvpepnqqt2goge/Update.zip?dl=0
        }

        private void GameStart_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine("Windward", "Windward.exe")))
            {
                Process.Start(Path.Combine("Windward", "Windward.exe"));
            }
            else if (File.Exists(Path.Combine(GamePathText.Text, "Windward.exe")))
            {
                Process.Start(Path.Combine(GamePathText.Text, "Windward.exe"));
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Игра не установлена или просто не обнаружена.\nХотите ли указать путь к папке с игрой?", "Запрос", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    ShowSettingsAction();
                    FolderBrowserDialog Fd = new FolderBrowserDialog();
                    Fd.ShowDialog();
                    GamePathText.Text = Fd.SelectedPath;
                }
                else if (dialog == DialogResult.No)
                {
                    
                }
            }
        }
        
        private void RusPathBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Fd = new FolderBrowserDialog();
            Fd.ShowDialog();
            RusPathText.Text = Fd.SelectedPath;
        }

        private void GamePathBrowse_Click(object sender, EventArgs e)
        {
        FolderBrowserDialog Fd = new FolderBrowserDialog();
        Fd.ShowDialog();
        GamePathText.Text = Fd.SelectedPath;
        }

        private void GameInstall_Click(object sender, EventArgs e)
        {
            GameInstallForm F = new GameInstallForm(GamePathText.Text);

            F.Show();
        }

        private void GamePathText_TextChanged(object sender, EventArgs e)
        {
            GameCheck();
        }

        private void SettingsShow_Click(object sender, EventArgs e)
        {
            ShowSettingsAction();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSettingsAction();
            MessageBox.Show("Была активирована секретная функция установки игры!");
            Gamebox.Enabled = true;
        }

        private void PrgVer_Click(object sender, EventArgs e)
        {
            ChangeLogForm ChangeLog = new ChangeLogForm();
            ChangeLog.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TEST();
        }

        private void RusPathText_TextChanged(object sender, EventArgs e)
        {
            RusCheck();
        }

        private void ShowSettingsAction()
        {
            if (Settings.Visible == true)
            {
                tm2.Enabled = true;            
                Settings.Visible = false;
                SettingsShow.Text = "Показать настройки";
                //this.Height = this.Height - 220;
                PrgVer.TextAlign = ContentAlignment.TopLeft;
            }
            else
            {
                tm1.Enabled = true;
                Settings.Visible = true;
                SettingsShow.Text = "Скрыть настройки";
               // this.Height = this.Height + 220;
                PrgVer.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Height >= 545)
                tm1.Enabled = false;
            else
                this.Height += 40;
        }

        private void tm2_Tick(object sender, EventArgs e)
        {
            if (this.Height <= 325)
                tm2.Enabled = false;
            else
                this.Height -= 40;
        }

        private void testtm_Tick(object sender, EventArgs e)
        {
            if (testlabel.Visible == true)
            {
                testlabel.Visible = false;
            }
            else
            {
                Random rand = new Random();
                int r = rand.Next(256);
                int g = rand.Next(256);
                int b = rand.Next(256);
                testlabel.ForeColor = Color.FromArgb(r, g, b);
                testlabel.Visible = true;
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            string NewVer = Client.DownloadString(new Uri("https://dl.dropboxusercontent.com/s/7lxyq9ks0tut177/versionNew.txt?dl=1")); //https://www.dropbox.com/s/7lxyq9ks0tut177/versionNew.txt?dl=0
            string ThisVer = Application.ProductVersion;
            if (NewVer.Contains(ThisVer))
                UpdaterTool.BackgroundImage = Properties.Resources.refreshNO_note1;
            else
                UpdaterTool.BackgroundImage = Properties.Resources.refresh_note1;
            GameCheck();
            RusCheck();
            RusCheckVer();
            TestCheck();
        }

        private void VKGroup_Click(object sender, EventArgs e)
        {
              Process.Start("http://new.vk.com/windwardgame");
        }

        static void UnzipFile(string path, string destination)
        {
            using (ZipArchive archive = ZipFile.OpenRead(path))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        entry.ExtractToFile(Path.Combine(destination, entry.FullName), true);
                    }
                }
            }
        }
    }
}
