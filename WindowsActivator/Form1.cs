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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            groupBox2.Visible = false;

            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;

            groupBox1.ForeColor = Color.White;
            groupBox2.ForeColor = Color.White;
            groupBox3.ForeColor = Color.White;

            radioButton1.ForeColor = Color.White;
            radioButton2.ForeColor = Color.White;
            radioButton3.ForeColor = Color.White;
            radioButton4.ForeColor = Color.White;
            radioButton5.ForeColor = Color.White;
            radioButton6.ForeColor = Color.White;
            radioButton7.ForeColor = Color.White;
            radioButton8.ForeColor = Color.White;
            radioButton9.ForeColor = Color.White;
            radioButton10.ForeColor = Color.White;
            radioButton11.ForeColor = Color.White;
            radioButton12.ForeColor = Color.White;

            checkBox1.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;


        }
        
        string windowsVersion()
        {
            if (radioButton1.Checked)
                return "1";
            if (radioButton2.Checked)
                return "2";
            if (radioButton3.Checked)
                return "3";
            if (radioButton4.Checked)
                return "4";
            if (radioButton5.Checked)
                return "5";
            if (radioButton6.Checked)
                return "6";
            if (radioButton7.Checked)
                return "7";
            if (radioButton11.Checked)
                return "8";
            if (radioButton10.Checked)
                return "9";
            if (radioButton9.Checked)
                return "10";
            else
                return "";
        }

        private void installKMSClientKey(string versionInt)
        {
            string licenseKey = "";
            if (versionInt == "1")
                licenseKey = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
            if (versionInt == "2")
                licenseKey = "3KHY7-WNT83-DGQKR-F7HPR-844BM";
            if (versionInt == "3")
                licenseKey = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
            if (versionInt == "4")
                licenseKey = "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
            if (versionInt == "5")
                licenseKey = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
            if (versionInt == "6")
                licenseKey = "MH37W-N47XK-V7XM9-C7227-GCQG9";
            if (versionInt == "7")
                licenseKey = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
            if (versionInt == "8")
                licenseKey = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
            if (versionInt == "9")
                licenseKey = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
            if (versionInt == "10")
                licenseKey = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
            label3.Text = "License Key: " + licenseKey;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C slmgr /ipk " + licenseKey;
            process.StartInfo = startInfo;
            process.Start();
            label4.Text = "Command: slmgr /ipk";
            Thread.Sleep(500);
        }
        private void setKMSMachineAddress()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C slmgr /skms kms8.msguides.com";
            process.StartInfo = startInfo;
            process.Start();
            label4.Text = "Command: slmgr /skms <URL>";
            Thread.Sleep(500);
        }
        private void activate()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C slmgr /ato";
            process.StartInfo = startInfo;
            process.Start();
            label4.Text = "Command: slmgr /ato";
            Thread.Sleep(500);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                for (int i = Form1.ActiveForm.Height; i > Form1.ActiveForm.MinimumSize.Height; i--)
                {
                    i--;
                    i--;
                    i--;
                    Form1.ActiveForm.Height = i;
                }
                groupBox2.Visible = false;
            }
            if (checkBox1.Checked)
            {
                groupBox2.Visible = true;
                for (int i = Form1.ActiveForm.Height; i < Form1.ActiveForm.MaximumSize.Height; i++)
                {
                    i++;
                    i++;
                    i++;
                    Form1.ActiveForm.Height = i;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Strayfade");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton8.Checked)
            {
                Form1.ActiveForm.ForeColor = Color.Black;
                Form1.ActiveForm.BackColor = Color.LightGray;

                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                button5.ForeColor = Color.Black;

                groupBox1.ForeColor = Color.Black;
                groupBox2.ForeColor = Color.Black;
                groupBox3.ForeColor = Color.Black;

                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
                radioButton3.ForeColor = Color.Black;
                radioButton4.ForeColor = Color.Black;
                radioButton5.ForeColor = Color.Black;
                radioButton6.ForeColor = Color.Black;
                radioButton7.ForeColor = Color.Black;
                radioButton8.ForeColor = Color.Black;
                radioButton9.ForeColor = Color.Black;
                radioButton10.ForeColor = Color.Black;
                radioButton11.ForeColor = Color.Black;
                radioButton12.ForeColor = Color.Black;

                checkBox1.ForeColor = Color.Black;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;

                pictureBox1.Visible = false;

                groupBox1.ForeColor = Color.Black;
                groupBox2.ForeColor = Color.Black;
                groupBox3.ForeColor = Color.Black;
            }
            else
            {
                Form1.ActiveForm.ForeColor = Color.White;
                Form1.ActiveForm.BackColor = Color.FromArgb(15, 15, 15);

                button1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;
                button4.ForeColor = Color.White;
                button5.ForeColor = Color.White;

                groupBox1.ForeColor = Color.White;
                groupBox2.ForeColor = Color.White;
                groupBox3.ForeColor = Color.White;

                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
                radioButton5.ForeColor = Color.White;
                radioButton6.ForeColor = Color.White;
                radioButton7.ForeColor = Color.White;
                radioButton8.ForeColor = Color.White;
                radioButton9.ForeColor = Color.White;
                radioButton10.ForeColor = Color.White;
                radioButton11.ForeColor = Color.White;
                radioButton12.ForeColor = Color.White;

                checkBox1.ForeColor = Color.White;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;

                pictureBox1.Visible = true;

                groupBox1.ForeColor = Color.White;
                groupBox2.ForeColor = Color.White;
                groupBox3.ForeColor = Color.White;
            }
        }

        string windowsVerInt;

        private void openSource()
        {
            System.Diagnostics.Process.Start("https://github.com/Strayfade/WindowsActivator");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openSource();
        }

        private void updateLabelText()
        {
            if (windowsVerInt == "1")
                label2.Text = "Windows 10 " + "Home";
            if (windowsVerInt == "2")
                label2.Text = "Windows 10 " + "Home N";
            if (windowsVerInt == "3")
                label2.Text = "Windows 10 " + "Home SL";
            if (windowsVerInt == "4")
                label2.Text = "Windows 10 " + "Home CS";
            if (windowsVerInt == "5")
                label2.Text = "Windows 10 " + "Pro";
            if (windowsVerInt == "6")
                label2.Text = "Windows 10 " + "Pro N";
            if (windowsVerInt == "7")
                label2.Text = "Windows 10 " + "Education";
            if (windowsVerInt == "8")
                label2.Text = "Windows 10 " + "Education N";
            if (windowsVerInt == "9")
                label2.Text = "Windows 10 " + "Enterprise";
            if (windowsVerInt == "10")
                label2.Text = "Windows 10 " + "Enterprise N";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            windowsVerInt = windowsVersion();
            updateLabelText();

            installKMSClientKey(windowsVerInt);
            setKMSMachineAddress();
            activate();
            label4.Text = "Finished with code 0";
            label2.Text = "";
            label1.Text = "Product Activated";
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton11.Enabled = false;
            radioButton10.Enabled = false;
            radioButton9.Enabled = false;
            button1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            windowsVerInt = windowsVersion();
            updateLabelText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton11.Checked = false;
            radioButton10.Checked = false;
            radioButton9.Checked = false;
            label2.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C slmgr -dlv";
            process.StartInfo = startInfo;
            process.Start();
            label4.Text = "Command: slmgr -dlv";
            Thread.Sleep(500);
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
        Form2 secondform = new Form2();
        private void Form1_Load(object sender, EventArgs e)
        {
            secondform.Show();
            Thread.Sleep(1500);
            secondform.Hide();

            radioButton1.Checked = true;
        }
    }
}
