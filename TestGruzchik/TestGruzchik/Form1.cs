using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGruzchik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshPath();
        }

        private void RefreshPath()
        {
            textBox1.Text = @"A:\Program Files (x86)\Steam\steamapps\common\Windward";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Fd = new FolderBrowserDialog();
            Fd.ShowDialog();
            textBox1.Text = Fd.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(textBox1.Text, "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                listBox1.Items.Add(file + "  " + File.GetLastWriteTime(file));                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshPath();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
