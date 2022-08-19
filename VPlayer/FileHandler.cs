using System;
using System.IO;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace VPlayer
{
    public class FileHandler
    {
        private bool init = true;
        
        public void WriteLine(String line)
        {
            if (init)
            {
                File.Delete(@"c:\temp\MyTest.txt");
                init = false;
            }
            String path = @"c:\temp\MyTest.txt";

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

        public void setInit(bool reinit)
        {
            init = reinit;
        }
    }
}