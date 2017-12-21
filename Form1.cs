using IWshRuntimeLibrary;
using System;
using System.Windows;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using VRAudioManager.AudioManaging;

namespace VRAudioManager
{
    public partial class Form1 : Form
    {
        private bool showForm = true;
        public Form1()
        {
            InitializeComponent();

            InfoManager.GetInfo(out string defaultAudio, out string defaultMicrophone, out string VRAudio,
                out string VRMicrophone, out bool autoToggle, out bool startUp, out string[] processesArray);

            this.defaultAudio.Text = defaultAudio;
            this.defaultMicrophone.Text = defaultMicrophone;
            this.VRAudio.Text = VRAudio;
            this.VRMicrophone.Text = VRMicrophone;
            this.autoToggle.Checked = autoToggle;
            this.startUp.Checked = startUp;

            richTextBox1.Text = string.Join("\n  ", processesArray);

            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItemDefault = new MenuItem("Default");
            MenuItem menuItemVR = new MenuItem("VR");
            MenuItem menuItemQuit = new MenuItem("Quit");

            menuItemDefault.Click += MenuItemDefault_Click;
            menuItemVR.Click += MenuItemVR_Click;
            menuItemQuit.Click += MenuItemQuit_Click;

            contextMenu.MenuItems.Add(menuItemDefault);
            contextMenu.MenuItems.Add(menuItemVR);
            contextMenu.MenuItems.Add(menuItemQuit);


            notifyIcon1.ContextMenu = contextMenu;

            if (startUp)
            {
                WindowState = FormWindowState.Minimized;
                notifyIcon1.Visible = true;
                showForm = false;
            }
        }

        private void MenuItemQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemVR_Click(object sender, EventArgs e)
        {
            switchVR();
        }

        private void MenuItemDefault_Click(object sender, EventArgs e)
        {
            switchDefault();
        }

        private void keyBind_KeyDown(object sender, KeyEventArgs e)
        {
            keyBind.Text = e.KeyCode.ToString();
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

            //Don't need constant switch
            if (isProcessRunning && currentSetting.Text != "VR")
                switchVR();
            else if (!isProcessRunning && currentSetting.Text != "Default")
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
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
            InfoManager.SaveInfo(defaultAudio.Text, defaultMicrophone.Text, VRAudio.Text, VRMicrophone.Text, autoToggle.Checked, startUp.Checked, GetProcesses());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!showForm)
                Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/mbilenko03/VRAudioManager/blob/master/README.md#usage");
            }
            catch { }
        }

        private void startUp_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), "VRAudioManager-shortcut.lnk");

            if (startUp.Checked)
            {
                if (!System.IO.File.Exists(fileName))
                    CreateShortcut("VRAudioManager-shortcut", Environment.GetFolderPath(Environment.SpecialFolder.Startup), Assembly.GetExecutingAssembly().Location);
            }
            else
            {
                if (System.IO.File.Exists(fileName))
                {
                    System.IO.File.Delete(fileName);
                }
            }
        }

        public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "VRAudioManager-shortcut";   // The description of the shortcut
            //shortcut.IconLocation = @"c:\myicon.ico";           // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;                 // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                    // Save the shortcut
        }

        private void browseFiles_Click(object sender, EventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".exe";
            dlg.Filter = "Executable (*.exe) | *.exe";


            // Display OpenFileDialog by calling ShowDialog method 
            bool? result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                string fileName = dlg.FileName;
                string[] fileParam = fileName.Split('\\');

                int lastElem = fileParam.Length - 1;

                fileName = fileParam[lastElem];

                fileParam = fileName.Split('.');
                fileName = fileParam[0];

                richTextBox1.AppendText($"\n{fileName}");
            }
        }
    }
}