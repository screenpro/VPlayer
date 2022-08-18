using System.Windows.Forms;
using System.Xml;

namespace VPlayer
{
    
    public class FormHandler
    {

        // Variable to check whether the list needs to be cleared or not
        private bool newList = true;
        
        // Arrays to store file names and file paths
        private string[] files;
        private string[] paths;
        
        // Adds file(s) to the list and clears the list if it's the first time a file is added
        public void AddItem(ListBox listBox)
        {
            // Create Windows file dialogs
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == 
                System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                
                // Clear list if it's a new one
                if (newList)
                {
                    listBox.Items.Clear();
                    newList = false;
                }
                
                // Traverse the file array and add it to the listBox
                for (int i = 0; i < files.Length; i++)
                {
                    listBox.Items.Add(files[i]);
                }
            }
        }
        
        // Removes a list item
        public void RemoveItem(ListBox listBox)
        {
            object selected = listBox.SelectedItem;
            int index = listBox.SelectedIndex;
            
            listBox.Items.Remove(selected);
            
            // Check if list is not empty to maintain selection (to prevent an exception)
            if (listBox.Items.Count != 0)
            {
                listBox.SetSelected(index, true);                
            }
        }
        
        // Moves a list item in the specified direction
        public void MoveItem(int direction,ListBox listBox)
        {
            // Check if the selected item exists, abort if not
            if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
                return;

            // Calculate new index using move direction
            int newIndex = listBox.SelectedIndex + direction;

            // Checking bounds of the index range, do nothing if out of range
            if (newIndex < 0 || newIndex >= listBox.Items.Count)
                return;
            
            // Select the object to be moved
            object selected = listBox.SelectedItem;

            // Move object and move selection accordingly
            listBox.Items.Remove(selected);
            listBox.Items.Insert(newIndex, selected);
            listBox.SetSelected(newIndex, true);
        }
    }
}