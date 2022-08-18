using System;
using System.IO;
using System.Windows.Forms;

namespace VPlayer
{
    public partial class MainForm : Form
    {
        
        // Initialize FormHandler to have its methods available
        private FormHandler formHandler = new FormHandler();
        private VideoHandler videoHandler = new VideoHandler();
        
        public MainForm()
        {

            // Initialize the Form
            InitializeComponent();

            // Create button controls
            this.Controls.Add(bTest);
            this.Controls.Add(bAuto);
            this.Controls.Add(bPlus);
            this.Controls.Add(bMinus);
            this.Controls.Add(bUp);
            this.Controls.Add(bDown);
            this.Controls.Add(bAbout);
            
            // Add button event handlers
            bTest.Click += new EventHandler(bTest_Click);
            bAuto.Click += new EventHandler(bAuto_Click);
            bPlus.Click += new EventHandler(bPlus_Click);
            bMinus.Click += new EventHandler(bMinus_Click);
            bUp.Click += new EventHandler(bUp_Click);
            bDown.Click += new EventHandler(bDown_Click);
            bAbout.Click += new EventHandler(bAbout_Click);

            // Set default Text for the ListBox
            listBox1.Items.Add("Drag files here or click [+] to add videos");
        }
        
        private void bTest_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            String[] fileList = new String[listBox1.Items.Count];
            //MessageBox.Show("Video list saved. Playback will start in 10 seconds.");
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                fileList[i] = listBox1.SelectedItem.ToString();
            }
            videoHandler.SetVideoList(fileList);
        }
        
        private void bAuto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Set Video Autostart Clicked!");
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            formHandler.AddItem(listBox1);
        }
        
        private void bMinus_Click(object sender, EventArgs e)
        {
            formHandler.RemoveItem(listBox1);
        }
        
        private void bUp_Click(object sender, EventArgs e)
        {
            formHandler.MoveItem(-1,listBox1);
        }
        
        private void bDown_Click(object sender, EventArgs e)
        {
            formHandler.MoveItem(1,listBox1);
        }
        
        private void bAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog that will show a very short manual as well as an \"About\" section.");
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}