using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
namespace FInal_Revision_For_MexSploit_1._1
{
    public partial class ArgaX : Form
    {
        public ArgaX()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings Settings = new Settings();
            Settings.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TopMostSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (TopMostSwitch.Checked == false)
            {
                TopMost = false;
            }
            else
            {
                if (TopMostSwitch.Checked == true)
                {
                    TopMost = true;
                }
            }
        }

        private void TopMostLabel_Click(object sender, EventArgs e)
        {
            if (TopMostSwitch.Checked == false)
            {
                TopMost = false;
            }
            else
            {
                if (TopMostSwitch.Checked == true)
                {
                    TopMost = true;
                }
            }
        }

        private void TransparencyLabel_Click(object sender, EventArgs e)
        {
            if (TransparencySwitch.Checked == false)
            {
                Opacity = 1;
            }
            else
            {
                if (TransparencySwitch.Checked == true)
                {
                    Opacity = 0.8;
                }
            }
        }

        private void TransparencySwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (TransparencySwitch.Checked == false)
            {
                Opacity = 1;
            }
            else
            {
                if (TransparencySwitch.Checked == true)
                {
                    Opacity = 0.8;
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
           ScriptBox.Clear();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
