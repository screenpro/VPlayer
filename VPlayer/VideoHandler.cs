using System;
using System.IO;
using System.Windows.Forms;

namespace VPlayer
{
    public class VideoHandler
    {
        private String[] videoList;
        
        public void PlayVideo(String[] videoList)
        {
            
        }

        public void SetVideoList(String[] vList, int count)
        {
            StreamWriter writer = new StreamWriter("./videos.txt");
            for (int i = 0; i < count; i++)
            {
                writer.WriteLine(vList[i]);
            }
        }
    }
}

// Implement methodology to check for file validity