using System;
using System.Drawing;
using System.Windows.Forms;

namespace VPlayer
{
    public partial class MainForm : Form
    {
        
        FormHandler formHandler = new FormHandler();
        
        public MainForm()
        {
           
            InitializeComponent();

            // Create Button controls
            this.Controls.Add(bTest);
            this.Controls.Add(bAuto);
            this.Controls.Add(bPlus);
            this.Controls.Add(bMinus);
            this.Controls.Add(bUp);
            this.Controls.Add(bDown);
            this.Controls.Add(bAbout);
            
            // Add Button event handlers
            bTest.Click += new EventHandler(bTest_Click);
            bAuto.Click += new EventHandler(bAuto_Click);
            bPlus.Click += new EventHandler(bPlus_Click);
            bMinus.Click += new EventHandler(bMinus_Click);
            bUp.Click += new EventHandler(bUp_Click);
            bDown.Click += new EventHandler(bDown_Click);
            bAbout.Click += new EventHandler(bAbout_Click);

            // Set default Text for the ListBox
            listBox1.Items.Add("Click here or drag files to add videos");
            listBox1.Items.Add("Video1");
            listBox1.Items.Add("Video2");
            listBox1.Items.Add("Video3");
            listBox1.Items.Add("Video4");
        }
        private void bTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Test Video Clicked!");
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

        public void clearItems()
        {
            listBox1.Items.Clear();
        }

    }
}