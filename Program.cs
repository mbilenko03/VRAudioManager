using System;
using System.Windows.Forms;

namespace VRAudioManager
{
    static class Program
    {
        private IKeyboardMouseEvents m_GlobalHook;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}