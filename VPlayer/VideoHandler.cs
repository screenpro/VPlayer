using System;
using System.Diagnostics;

namespace VPlayer
{
    public class VideoHandler
    {
        private String[] videoList;
        
        public void PlayVideo(String[] videos, int count)
        {
            // Add Thread to run Video in separate thread and to abort with key press
            while (true)
            {
                for (int i = 0; i < count; i++)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = "C:/Temp/ffplay.exe";
                    process.StartInfo.Arguments = " -sn -alwaysontop -i " + videos[i];
                    process.Start();
                    process.WaitForExit();
                }
            }
        }

        public void SetVideoList(String[] vList, int count)
        {
            // Probably unnecessary now
        }
    }
}

// Implement methodology to check for file validity