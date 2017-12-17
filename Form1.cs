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
            return richTextBox1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void switchVR()
        {
            SwitchAudio.SwitchDevice(VRAudio.Text, VRMicrophone.Text);
        }

        private void switchDefault()
        {
            SwitchAudio.SwitchDevice(defaultAudio.Text, defaultMicrophone.Text);
        }
    }
}
