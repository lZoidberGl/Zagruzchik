using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zagruzchik
{
    public partial class ChangeLogForm : Form
    {
        int mouseX = 0, mouseY = 0;
        bool mousedown;
        public ChangeLogForm()
        {
            InitializeComponent();
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
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
