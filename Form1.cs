using System;
using System.Diagnostics;
using System.Windows.Forms;
using VRAudioManager.AudioManaging;

namespace VRAudioManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void keyBind_KeyDown(object sender, KeyEventArgs e)
        {
            keyBind.Text = e.KeyCode.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {        
        }

        private void Default_Click(object sender, EventArgs e)
        {
            switchDefault();
        }

        private void VR_Click(object sender, EventArgs e)
        {
            switchVR();
        }

        private void autoToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (autoToggle.Checked)
                timer.Enabled = true;
            else
                timer.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bool isProcessRunning = SwitchAudio.IsAnyProcessRuning(GetProcesses());

            if (isProcessRunning)
                switchVR();
            else
                switchDefault();
        }

        private string[] GetProcesses()
        {
            string processes = richTextBox1.Text;
            processes = processes.Replace("\n", "=");
            return processes.Split('=');
        }

        private void switchVR()
        {
            SwitchAudio.SwitchDevice(VRAudio.Text, VRMicrophone.Text);
            currentSetting.Text = "VR";
        }

        private void switchDefault()
        {
            SwitchAudio.SwitchDevice(defaultAudio.Text, defaultMicrophone.Text);
            currentSetting.Text = "Default";
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            } 
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            InfoManager.SaveInfo(defaultAudio.Text, defaultMicrophone.Text, VRAudio.Text, VRMicrophone.Text, GetProcesses());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InfoManager.GetInfo(out string defaultAudio, out string defaultMicrophone, out string VRAudio,
                out string VRMicrophone, out string[] processesArray);

            this.defaultAudio.Text = defaultAudio;
            this.defaultMicrophone.Text = defaultMicrophone;
            this.VRAudio.Text = VRAudio;
            this.VRMicrophone.Text = VRMicrophone;

            richTextBox1.Text = string.Join("\n  ",processesArray);
        }
    }
}