using System;
using System.IO;

namespace VPlayer
{
    public class VideoHandler
    {
        private String[] videoList;
        
        public void PlayVideo(String[] videoList)
        {
            
        }

        public void SetVideoList(String[] vList)
        {
            //int length = vList.GetLength(0);
            for (int i = 0; i < vList.GetLength(0); i++)
            {
                //using StreamWriter file = new("videos.txt", append: true);
                //file.WriteLine(vList[i]);
                using (StreamWriter writer = new StreamWriter("./videos.txt"))  
                {  
                    writer.WriteLine(vList[i]);
                }  
            }
        }
    }
}

// Implement methodology to check for file validity