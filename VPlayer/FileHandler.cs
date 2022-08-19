using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace VPlayer
{
    public class FileHandler
    {
        private bool init = true;
        String path = @"c:\temp\MyTest.txt";
        
        public void WriteLine(String line)
        {
            if (init)
            {
                File.Delete(@"c:\temp\MyTest.txt");
                init = false;
            }

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                String createText = line + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            else
            {
                String appendText = line + Environment.NewLine;
                File.AppendAllText(path, appendText);
            }
            
            // Open the file to read from.
            String readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }

        public String[] ReadLine()
        {
            int counter = 0;
            foreach (string line in System.IO.File.ReadLines(path))
            {
                counter++;
            }  
            String[] videos = new String[counter];            
            if (!File.Exists(path))
            {
                videos[0] = "0";
                return videos;
            }
            else
            {
                videos = File.ReadLines(path).ToArray();
                for (int i = 0; i < counter; i++)
                {
                    System.Console.WriteLine(videos[i]);
                }
                return videos;
            }
        }

        public void setInit(bool reinit)
        {
            init = reinit;
        }
    }
}