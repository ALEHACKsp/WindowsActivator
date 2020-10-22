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


        private void Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            FadeOut(this, 30);
        }
    }
}
