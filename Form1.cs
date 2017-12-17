using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void keyBind_KeyDown(object sender, KeyEventArgs e)
        {
            keyBind.Text = e.KeyCode.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = Process.GetProcessesByName("notepad");

            if (p.Length > 0)
                Debug.WriteLine($"Notepad.exe is detected. Process count: {p.Length}");
            else
                Debug.WriteLine("Notepad.exe is not detected :(");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toggleVR(object sender, EventArgs e)
        {
            SwitchAudio.SwitchDevice(VRAudio.Text, VRMicrophone.Text);
        }

        private void toggleDefault_Click(object sender, EventArgs e)
        {
            SwitchAudio.SwitchDevice(defaultAudio.Text, defaultMicrophone.Text);
        }
    }
}
