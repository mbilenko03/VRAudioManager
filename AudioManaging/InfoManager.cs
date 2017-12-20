using System;
using System.Diagnostics;
using System.IO;

namespace VRAudioManager.AudioManaging
{
    static class InfoManager
    {
        public static void SaveInfo(string defaultAudio, string defaultMicrophone, string VRAudio, string VRMicrophone, bool autoToggle, bool startUp, string[] processesArray)
        {
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AppSettings.txt");

            string processes = string.Join("=", processesArray);
            string text = $"{defaultAudio}\n{defaultMicrophone}\n{VRAudio}\n{VRMicrophone}\n{autoToggle.ToString()}\n{startUp.ToString()}\n{processes}";

            File.WriteAllText(fileName, text);
        }

        public static void GetInfo(out string defaultAudio, out string defaultMicrophone, out string VRAudio,
            out string VRMicrophone, out bool autoToggle, out bool startUp, out string[] processesArray)
        {
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AppSettings.txt");

            if (File.Exists(fileName))
            {
                try
                {
                    string text = File.ReadAllText(fileName);

                    text = text.Replace("\n", "=");
                    string[] values = text.Split('=');


                    defaultAudio = values[0];
                    defaultMicrophone = values[1];
                    VRAudio = values[2];
                    VRMicrophone = values[3];

                    autoToggle = false;
                    startUp = false;

                    bool.TryParse(values[4], out autoToggle);
                    bool.TryParse(values[5], out startUp);


                    processesArray = new string[values.Length - 6];

                    for (int i = 6; i < values.Length; i++)
                    {
                        processesArray[i - 6] = values[i];
                    }
                }
                catch
                {
                    defaultAudio = defaultMicrophone = VRAudio = VRMicrophone = "";
                    autoToggle = startUp = false;
                    processesArray = new string[0];
                }
            }
            else
            {
                defaultAudio = defaultMicrophone = VRAudio = VRMicrophone = "";
                autoToggle = startUp = false;
                processesArray = new string[0];
            }
        }
    }
}
