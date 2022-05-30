using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainbowUI
{
    public partial class MainForm : Form
    {
        //Variable for dragging
        Point lastPoint;
        public MainForm()
        {
            InitializeComponent();
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //For dragging
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //For dragging
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizelabel_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Idk put stuff in here if you want
        }

        //Rainbow timer
        int r = 255, g = 0, b = 0;
        private void PanelRainbow_Tick(object sender, EventArgs e)
        {
            RainbowPanel.BackColor = Color.FromArgb(r, g, b);
            LogoLabel.ForeColor = Color.FromArgb(r, g, b);
            if (r > 0 && b == 0) 
            {
                r--;
                g++;
            }
            if (g > 0 && r == 0) 
            {
                g--;
                b++;
            }
            if (b > 0 && g == 0)
            {
                b--;
                r++;
            }
        }
    }
}
