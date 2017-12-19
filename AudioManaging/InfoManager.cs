﻿using System;
using System.Diagnostics;
using System.IO;

namespace VRAudioManager.AudioManaging
{
    static class InfoManager
    {
        public static void SaveInfo(string defaultAudio, string defaultMicrophone, string VRAudio, string VRMicrophone, string[] processesArray)
        {
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AppSettings.txt");

            string processes = string.Join("=", processesArray);
            string text = $"{defaultAudio}\n{defaultMicrophone}\n{VRAudio}\n{VRMicrophone}\n{processes}";

            File.WriteAllText(fileName, text);
        }

        public static void GetInfo(out string defaultAudio, out string defaultMicrophone, out string VRAudio,
            out string VRMicrophone, out string[] processesArray)
        {
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AppSettings.txt");

            if (File.Exists(fileName))
            {
                string text = File.ReadAllText(fileName);
                Debug.WriteLine(text);

                text = text.Replace("\n", "=");
                string[] values = text.Split('=');


                defaultAudio = values[0];
                defaultMicrophone = values[1];
                VRAudio = values[2];
                VRMicrophone = values[3];
                processesArray = new string[values.Length - 4];

                for (int i = 4; i < values.Length; i++)
                {
                    processesArray[i - 4] = values[i];
                }
            }
            else
            {
                defaultAudio = defaultMicrophone = VRAudio = VRMicrophone = "";
                processesArray = new string[0];
            }
        }
    }
}