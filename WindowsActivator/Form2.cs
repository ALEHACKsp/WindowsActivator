using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsActivator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private async void FadeIn(Form o, int interval = 80)
        {
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1;     
        }

        private async void FadeOut(Form o, int interval = 80)
        {
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; 
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            FadeOut(this, 1000);
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
            FadeIn(this, 70);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            FadeOut(this, 30);
        }
    }
}
