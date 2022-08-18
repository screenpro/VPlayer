using System.Windows.Forms;
using System.Xml;

namespace VPlayer
{
    
    public class FormHandler
    {
        
        private bool newList;
        
        private string[] files;
        private string[] paths;

        public FormHandler()
        {
            newList = true;
        }
        
        public void AddItem(ListBox listBox)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == 
                System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                
                if (newList)
                {
                    listBox.Items.Clear();
                    newList = false;
                }
                
                for (int i = 0; i < files.Length; i++)
                {
                    listBox.Items.Add(files[i]);
                }
            }
        }
        
        public void RemoveItem(ListBox listBox)
        {
            object selected = listBox.SelectedItem;
            
            listBox.Items.Remove(selected);
        }
        
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

            object selected = listBox.SelectedItem;

            // Remove the element
            listBox.Items.Remove(selected);
            // Insert in the new position
            listBox.Items.Insert(newIndex, selected);
            // Restore the selection
            listBox.SetSelected(newIndex, true);
        }
    }
}