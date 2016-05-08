using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGruzchik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        WebClient Client = new WebClient();
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void InstallUpdateButton_Click(object sender, EventArgs e)
        {
            Client.DownloadProgressChanged += Client_DownloadProgressChanged;
            Client.DownloadFileCompleted += Client_DownloadFileCompleted;
            try
            {
                Download("https://dl.dropboxusercontent.com/s/iwkvri38sytcvxr/WindwardGame.zip?dl=1", Application.StartupPath + "Game.zip");             //https://www.dropbox.com/s/iwkvri38sytcvxr/WindwardGame.zip?dl=0
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
            while (progressBar1.Value != 100)
            {

            }
        }
        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //CancelAsync.Visible = true;
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = Math.Round(double.Parse(e.BytesReceived.ToString()) / 1024, 0) + " KB/" + Math.Round(double.Parse(e.TotalBytesToReceive.ToString()) / 1024, 0) + " KB       " + e.ProgressPercentage.ToString() + "%";
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //CancelAsync.Visible = false;
        }
        private void Download(string link, string path)
        {
            Client.DownloadFileAsync(new Uri(link), path);
        }
    }

}
