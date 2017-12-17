using System;
using System.Diagnostics;
using System.Management;
using System.Management.Instrumentation;
using System.Windows.Forms;

namespace VRAudioManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());





            //SwitchAudio audio = new SwitchAudio("Rift Microphone", "Rift Headphones", "Blue Snowball", "Rift Microphone");
            //audio.SwitchVR();
        }
    }
}