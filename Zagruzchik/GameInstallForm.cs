using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace Zagruzchik
{
    public partial class GameInstallForm : Form
    {
        public GameInstallForm(string F)
        {
            InitializeComponent();
            InstallPath.Text = F;
        }
       
        WebClient Client = new WebClient();
        private void GameInstallForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(InstallPath,InstallPath.Text);
            GameCheck();
        }     

      //  public TextBox Form1text
       // {
     //       get { return Form1.GamePathText.Text }
     //   }

        private void GameCheck()
        {
            if (File.Exists(InstallPath.Text + "\\Windward.exe"))
            {
                InstallUpdateButton.Text = "Обновить";
                ReinstallButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
            else
            {
                ReinstallButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }

        private void InstallUpdateButton_Click(object sender, EventArgs e)
        {
            Client.DownloadProgressChanged += Client_DownloadProgressChanged;
            Client.DownloadFileCompleted += Client_DownloadFileCompleted;
            try
            {
                Download("https://dl.dropboxusercontent.com/s/iwkvri38sytcvxr/WindwardGame.zip?dl=1", InstallPath.Text + "Game.zip");             //https://www.dropbox.com/s/iwkvri38sytcvxr/WindwardGame.zip?dl=0
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            while (progressBar.Value != 100)
            {
                
            }

        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            CancelAsync.Visible = true;
            progressBar.Value = e.ProgressPercentage;
            DownloadStatus.Text = Math.Round(double.Parse(e.BytesReceived.ToString()) / 1024, 0) + " KB/" + Math.Round(double.Parse(e.TotalBytesToReceive.ToString()) / 1024 , 0) + " KB       " + e.ProgressPercentage.ToString() + "%";
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            CancelAsync.Visible = false;
        }

        private void UnPack()
        {          
            {
                if (File.Exists("WindwardGame.zip"))
                {
                    progressBar.Style = ProgressBarStyle.Marquee;
                    string InPath1 = InstallPath.Text;
                    string InPath2 = InPath1.Remove(InPath1.Length - 8);
                    UnzipFile("WindwardGame.zip", InPath2);

                    progressBar.Style = ProgressBarStyle.Continuous;

                    MessageBox.Show("Если игра вам понравится, не забудьте поддержать разработчика и купить ее! ;)");

                    DialogResult dialog = MessageBox.Show("Игра успешно установлена!" + Environment.NewLine + "Хоите запустить?", "Запрос", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        try
                        { Process.Start(InstallPath.Text + "\\Windward.exe"); }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                    else if (dialog == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
        }

        private void ReinstallButton_Click(object sender, EventArgs e)
        {
            try {
                DeleteContent(InstallPath.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            try
            {
                Download("https://dl.dropboxusercontent.com/s/iwkvri38sytcvxr/WindwardGame.zip?dl=1", InstallPath.Text + "Game.zip");             //https://www.dropbox.com/s/iwkvri38sytcvxr/WindwardGame.zip?dl=0
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Download( string link, string path)
        {
            Client.DownloadProgressChanged += Client_DownloadProgressChanged;
            Client.DownloadFileCompleted += Client_DownloadFileCompleted;
            Client.DownloadFileAsync(new Uri(link), path);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteContent(InstallPath.Text);
            MessageBox.Show("Успешно удалено!");
            DownloadStatus.Text = "";
        }

        private void DeleteContent( string path )
        {
            try
            {
                DownloadStatus.Text = "Удаление...";
                System.IO.DirectoryInfo di = new DirectoryInfo(path);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            catch (Exception ex) { MessageBox.Show("Невозможно удалить!"+ Environment.NewLine + "Ошибка: " + ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameCheck();
        }
        static void UnzipFile(string path, string destination)
        {
            using (ZipArchive archive = ZipFile.OpenRead(path))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                   if (entry.FullName.EndsWith("*", StringComparison.OrdinalIgnoreCase))
                    {
                        entry.ExtractToFile(Path.Combine(destination, entry.FullName), true);
                    }
                }
            }
        }

        private void CancelAsync_Click(object sender, EventArgs e)
        {
            try {
                Client.CancelAsync();
                try
                {
                    DownloadStatus.Text = "Удаление...";
                    if (File.Exists(InstallPath.Text + "Game.zip"))
                        File.Delete(InstallPath.Text + "Game.zip");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            DownloadStatus.Text = "";
        }
    }
}
