using System.ComponentModel;

namespace VPlayer
{
    partial class MainForm
    {
        /// Required designer variable.
        private IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bTest = new System.Windows.Forms.Button();
            this.bAuto = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bMinus = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.bDown = new System.Windows.Forms.Button();
            this.bAbout = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bTest
            // 
            this.bTest.Location = new System.Drawing.Point(9, 155);
            this.bTest.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bTest.Name = "bTest";
            this.bTest.Size = new System.Drawing.Size(134, 25);
            this.bTest.TabIndex = 0;
            this.bTest.Text = "Test Video";
            this.bTest.UseVisualStyleBackColor = true;
            // 
            // bAuto
            // 
            this.bAuto.Location = new System.Drawing.Point(147, 155);
            this.bAuto.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bAuto.Name = "bAuto";
            this.bAuto.Size = new System.Drawing.Size(134, 25);
            this.bAuto.TabIndex = 1;
            this.bAuto.Text = "Set Video Autostart";
            this.bAuto.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(10, 11);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 139);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bMinus
            // 
            this.bMinus.Location = new System.Drawing.Point(256, 97);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(25, 25);
            this.bMinus.TabIndex = 4;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            // 
            // bUp
            // 
            this.bUp.Location = new System.Drawing.Point(256, 39);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(25, 25);
            this.bUp.TabIndex = 5;
            this.bUp.Text = "↑";
            this.bUp.UseVisualStyleBackColor = true;
            // 
            // bDown
            // 
            this.bDown.Location = new System.Drawing.Point(256, 68);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(25, 25);
            this.bDown.TabIndex = 6;
            this.bDown.Text = "↓";
            this.bDown.UseVisualStyleBackColor = true;
            // 
            // bAbout
            // 
            this.bAbout.Location = new System.Drawing.Point(256, 126);
            this.bAbout.Name = "bAbout";
            this.bAbout.Size = new System.Drawing.Size(25, 25);
            this.bAbout.TabIndex = 7;
            this.bAbout.Text = "?";
            this.bAbout.UseVisualStyleBackColor = true;
            // 
            // bPlus
            // 
            this.bPlus.Location = new System.Drawing.Point(256, 10);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(25, 25);
            this.bPlus.TabIndex = 3;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(290, 189);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bAbout);
            this.Controls.Add(this.bDown);
            this.Controls.Add(this.bUp);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bAuto);
            this.Controls.Add(this.bTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.Text = "screenpro vPlayer";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bPlus;

        private System.Windows.Forms.Button bTest;
        private System.Windows.Forms.Button bAuto;

        private System.Windows.Forms.Button bDown;
        private System.Windows.Forms.Button bAbout;

        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bUp;

        public System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}