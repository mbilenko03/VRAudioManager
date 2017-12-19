using System.Diagnostics;
using System.IO;

namespace VRAudioManager.AudioManaging
{
    class SwitchAudio
    {
        private static string BatchPath = Path.GetFullPath("~\\..\\audio.bat");        

        static public void SwitchDevice(string Input, string Output)
        {
            ProcessStartInfo theProcess = new ProcessStartInfo(BatchPath, string.Format("\"{0}\" \"{1}\"", Input, Output));
            theProcess.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(theProcess);
        }

        static public bool IsAnyProcessRuning(string[] processes)
        {
            bool anyProcessRunning = false;

            foreach (string element in processes)
            {
                var p = Process.GetProcessesByName(element);

                if (p.Length > 0)
                    anyProcessRunning = true;
            }

            return anyProcessRunning;
        }
    }
}
