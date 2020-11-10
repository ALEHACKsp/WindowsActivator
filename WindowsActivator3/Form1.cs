using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsActivator3.Properties;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;

namespace WindowsActivator3
{
    public partial class Form1 : Form
    {
        string version = "3.1";
        string buildDate = "11/10/2020";

        string trueVersion;
        bool started = false;

        public Form1()
        {
            InitializeComponent();
        }

        void setProgress(int progress)
        {
            int z = circularProgressBar1.Value;
            for (int i = z; i < progress; i++)
            {
                circularProgressBar1.Value = i;
                Thread.Sleep(19);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.ExitHover;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Exit;
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.SettingsHover;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.Settings;
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.MinimizeHover;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Minimize;
        }
        private void CenterRing_MouseHover(object sender, EventArgs e)
        {
            if (!started)
            {
                CenterRing.Image = Resources.CenterRing;
            }
        }
        private void CenterRing_MouseLeave(object sender, EventArgs e)
        {
            if (!started)
            {
                CenterRing.Image = Resources.Center;
            }
        }

        public string regedit()
        {
            RegistryKey parentKey = Registry.LocalMachine;
            RegistryKey mainKey = parentKey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0", true);
            return mainKey.GetValue("ProcessorNameString").ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                trueVersion = trueVersion + version[i];
            }
            Username.Text = System.Windows.Forms.SystemInformation.ComputerName.ToString();
            label3.Text = "Version: " + version;
            Data4.Text = "WindowsActivator " + version;
            label1.Text = "Build Date: " + buildDate;
            label5.Text = trueVersion.ToString();
            InitTimer(100);
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton11.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            label14.Text = regedit();
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

        private void Data2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                activate();
                started = true;
            }
        }
        string windowsVerInt;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CenterRing_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                activate();
                started = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                activate();
                started = true;
            }
        }
        private void openSource()
        {
            System.Diagnostics.Process.Start("https://github.com/Strayfade/WindowsActivator");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openSource();
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
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C slmgr /ipk " + licenseKey;
            process.StartInfo = startInfo;
            process.Start();
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
            Thread.Sleep(500);
        }
        private void finalize()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C slmgr /ato";
            process.StartInfo = startInfo;
            process.Start();
            Thread.Sleep(500);
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
        private void updateLabelText()
        {
            windowsVerInt = windowsVersion();
            if (windowsVerInt == "1")
                label10.Text = "Windows 10 " + "Home";
            if (windowsVerInt == "2")
                label10.Text = "Windows 10 " + "Home N";
            if (windowsVerInt == "3")
                label10.Text = "Windows 10 " + "Home SL";
            if (windowsVerInt == "4")
                label10.Text = "Windows 10 " + "Home CS";
            if (windowsVerInt == "5")
                label10.Text = "Windows 10 " + "Pro";
            if (windowsVerInt == "6")
                label10.Text = "Windows 10 " + "Pro N";
            if (windowsVerInt == "7")
                label10.Text = "Windows 10 " + "Education";
            if (windowsVerInt == "8")
                label10.Text = "Windows 10 " + "Education N";
            if (windowsVerInt == "9")
                label10.Text = "Windows 10 " + "Enterprise";
            if (windowsVerInt == "10")
                label10.Text = "Windows 10 " + "Enterprise N";
        }
        void activate()
        {
            CenterRing.Image = Resources.CenterRing1;
            circularProgressBar1.Visible = true;
            setProgress(10);
            Thread.Sleep(250);
            windowsVerInt = windowsVersion();
            updateLabelText();
            circularProgressBar1.Value = 20;
            installKMSClientKey(windowsVerInt);
            circularProgressBar1.Value = 50;
            setKMSMachineAddress();
            Thread.Sleep(1000);
            circularProgressBar1.Value = 65;
                        //"Start WindowsActivator"
            label9.Text = "Finalizing Activation.";
            label10.Text = "";
            Thread.Sleep(2000);
            finalize();
            setProgress(100);
            label9.Text = "     Product Activated  ";
            circularProgressBar1.Value = 100;
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
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = FormWindowState.Minimized;
        }
        public string getCurrentCpuUsage()
        {
            int coreCount = 0;
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                coreCount++;
            }
            return coreCount.ToString();
        }
        public void InitTimer(int updates)
        {
            timer2.Stop();
            timer2.Tick += new EventHandler(timer1_Tick);
            timer2.Interval = updates; // in miliseconds
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateLabelText();
            label8.Text = getAvailableRAM();
            Data1.Text = getCurrentCpuUsage();
        }
        public string getAvailableRAM()
        {
            PerformanceCounter ramCounter;
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            return ramCounter.NextValue() + "MB";
        }
        private void label8_Click(object sender, EventArgs e)
        {
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int updateSpeed = trackBar1.Value * 100;
            InitTimer(updateSpeed);
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }
        bool settingsVisible = false;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            settingsVisible = !settingsVisible;
            if(settingsVisible)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton11.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
            }
            else if (!settingsVisible)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton11.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            openSource();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                label7.ForeColor = Color.Gray;
                trackBar1.Enabled = false;
                InitTimer(10);
            }
            else if (!checkBox1.Checked)
            {
                label7.ForeColor = Color.White;
                trackBar1.Enabled = true;

                int updateSpeed = trackBar1.Value * 100;
                InitTimer(updateSpeed);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Strayfade/");
        }

        private void siticoneOSToggleSwith1_CheckedChanged(object sender, EventArgs e)
        {
            settingsVisible = !settingsVisible;
            if(siticoneOSToggleSwith1.Checked)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton11.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
            }
            else if (!siticoneOSToggleSwith1.Checked)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton11.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            settingsVisible = !settingsVisible;
            if (settingsVisible)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton11.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
            }
            else if (!settingsVisible)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton11.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
        }
        private void cv_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Strayfade/WindowsActivator");
        }
        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Strayfade/WindowsActivator");
        }
    }
}