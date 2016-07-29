using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.IO.Compression;
using System.Threading;
using System.Configuration;

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

            PrgVer.Text = Application.ProductVersion;
            PrgAthr.Text = "Сделал |ZoidberG|";
            SettingsShow.Text = "Показать настройки";
            RusPathText.Text = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents", "Windward");
            GamePathText.Text = Path.Combine(Application.StartupPath, "Windward");

        }

        private void CheckForPath()
        {
            if (File.Exists(Path.Combine(Application.StartupPath ,"Path.txt")))
            {
                GamePathText.Text = File.ReadAllText(Path.Combine(Application.StartupPath, "Path.txt"));
            }
        }

        private void DllCheck()
        {
            if (File.Exists(Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents", "Windward", "mods", "translateMod", "translateMod.dll")))
            {
                try
                {
                    File.Delete(Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents", "Windward", "mods", "translateMod", "translateMod.dll"));
                    MessageBox.Show("Файл: translateMod.dll был удален!");
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить файл: translateMod.dll  Попробуйте удалить его вручную в папке: " + Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents", "Windward", "mods", "translateMod"));
                }
            }
        }

        private void TestCheck()
        {
            // if (Application.StartupPath == @"I:\Projects\Progs\Zagruzchik\Zagruzchik\bin\Debug")
            if (Application.StartupPath.Contains(@"Projects\Progs\Zagruzchik\Zagruzchik\bin\Debug"))
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
             else*/
            if (File.Exists(Path.Combine(GamePathText.Text, "Windward.exe")))
            {
                GameStatus.Text = "Установлена";
                GameStatus.ForeColor = Color.Green;
                GameStatusPanel.BackColor = Color.Green;
            }
            else
            {
                GameStatus.Text = "Отсутствует";
                GameStatus.ForeColor = Color.Red;
                GameStatusPanel.BackColor = Color.Red;
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
            if (File.Exists(Path.Combine(RusPathText.Text, "Localization.zip")))
            {
                using (ZipArchive file = ZipFile.OpenRead(Path.Combine(RusPathText.Text, "Localization.zip")))
                {
                   
                    string path = RusPathText.Text;
                    try { ZipExtension.ExtractToDirectory(file, path, true); }
                    catch { MessageBox.Show("Ошибка распаковки!"); }
                }
                Unzipper.CancelAsync();
            }

            if (File.Exists("update.zip"))
            {
                using (ZipArchive file = ZipFile.OpenRead("update.zip"))
                {
                    
                    string path = Application.StartupPath;
                    try { ZipExtension.ExtractToDirectory(file, path, true); }
                    catch { MessageBox.Show("Ошибка распаковки!"); }
                }
                Unzipper.CancelAsync();
            }
            Unzipper.CancelAsync();
        }

        private void DeleteRemainingFiles()
        {
            if (File.Exists(Path.Combine(RusPathText.Text, "Localization.zip")))
            {
                string filepath = Path.Combine(RusPathText.Text, "Localization.zip");
                File.Delete(filepath);
                MessageBox.Show("Готово! Русификатор установлен!");
                if (VKcheck.Checked)
                    Process.Start("http://new.vk.com/windwardgame");
                RusInstall.Enabled = true;
            }

            if (File.Exists("update.zip"))
            {
                string filepath = "update.zip";
                File.Delete(filepath);
                MessageBox.Show("Готово! Новая версия программы загружена!/nПрограмма будет перезапущена.");
                CmdWork();
                if (VKcheck.Checked)
                    Process.Start("http://new.vk.com/windwardgame");
                UpdaterTool.Enabled = true;
            }


        }


       /* private void UnPack()
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
        */
        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;           
            ProgressPercent.Text = e.ProgressPercentage.ToString() + "%";
        }
        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (File.Exists(Path.Combine(RusPathText.Text, "Localization.zip")) || File.Exists("update.zip"))
            {
                try
                {
                    Unzipper.WorkerSupportsCancellation = true;
                    Unzipper.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Ошибка:  " + ex.Message);
                }
            }
            
            if (File.Exists("WIA.exe"))
            {
                ProgressPanel.Visible = false;
                File.Move("WIA.exe", "WindwardInstallAddon.exe");
                DialogResult answ = MessageBox.Show("Аддон загружен! Хотите запустить?", "Запрос", MessageBoxButtons.YesNo);
                if (answ == DialogResult.Yes)
                {
                    Process.Start("WindwardInstallAddon.exe");
                }
            }
        }
        private void RusInstall_Click(object sender, EventArgs e)
          {
            RusInstall.Enabled = false;
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
            UpdaterTool.Enabled = false;
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

        private void GamePathText_TextChanged(object sender, EventArgs e)
        {
            GameCheck();
        }

        private void SettingsShow_Click(object sender, EventArgs e)
        {
            ShowSettingsAction();
        }


        private void PrgVer_Click(object sender, EventArgs e)
        {
            ChangeLogForm ChangeLog = new ChangeLogForm();
            ChangeLog.Show();
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
            CheckForPath();
            DllCheck();
            //CreateConfig();
        }

        private void CreateConfig()
        {
           
        }

        private void VKGroup_Click(object sender, EventArgs e)
        {
              Process.Start("http://new.vk.com/windwardgame");
        }

        private void Unzipper_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                UnPack();
            }
            catch
            {

            }


        }

        private void GameInstall_Click(object sender, EventArgs e)
        {
            if (File.Exists("WindwardInstallerAddon.exe"))
            {
                DialogResult answ = MessageBox.Show("Аддон для загрузки игры был обнаружен! Хотите запустить?", "", MessageBoxButtons.YesNo);
                if (answ == DialogResult.Yes)
                {
                    Process.Start("WindwardInstallerAddon.exe");
                }
            }
            else
            {
                DialogResult answ = MessageBox.Show("Не удалось обнаружить аддон для загрузки игры! Возможно вы хотите его загрузить?", "Запрос", MessageBoxButtons.YesNo);
                if (answ == DialogResult.Yes)
                {
                    Client.DownloadProgressChanged += Client_DownloadProgressChanged;
                    Client.DownloadFileCompleted += Client_DownloadFileCompleted;

                    ProgressPanel.Visible = true;

                    Client.DownloadFileAsync(new Uri("https://dl.dropboxusercontent.com/s/0bfwdd9wmghvslm/WindwardInstallerAddon.exe?dl=1"),"WIA.exe"); //https://www.dropbox.com/s/0bfwdd9wmghvslm/WindwardInstallerAddon.exe?dl=0
                }
            }
        }

        private void Unzipper_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            DeleteRemainingFiles();
        }
        
    }
}
