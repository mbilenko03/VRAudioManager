using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRAudioManager.AudioManaging
{
    class SwitchAudio
    {
        private static string BatchPath = Path.GetFullPath("~\\..\\..\\..\\RunningFiles\\audio.bat");        

        static public void SwitchDevice(string Input, string Output)
        {
            ProcessStartInfo theProcess = new ProcessStartInfo(BatchPath, string.Format("\"{0}\" \"{1}\"", Input, Output));
            theProcess.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(theProcess);
        }
    }
}
