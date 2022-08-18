using System;
using System.Drawing;
using System.Windows.Forms;

namespace VPlayer
{
    public partial class MainForm : Form
    {
        public Button button1;
        public Button button2;
        public MainForm()
        {
            InitializeComponent();
            button1 = new Button();
            button1.Size = new Size(80, 40);
            button1.Location = new Point(20, 20);
            button1.Text = "Button1";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_Click);

            button2 = new Button();
            button2.Size = new Size(80, 40);
            button2.Location = new Point(120, 20);
            button2.Text = "Button2";
            this.Controls.Add(button2);
            button2.Click += new EventHandler(button2_Click);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 1 Clicked!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 2 clicked!");
        }
    }
}