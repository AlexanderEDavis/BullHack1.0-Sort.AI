using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sort.AI_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readFiles(string fileName, string filePath)
        {
            string fileExt = Path.GetExtension(fileName);
            string[] acceptedExtensions = { ".txt" };
            if (acceptedExtensions.Contains(fileExt))
            {
                string textContent = File.ReadAllText(filePath);
            }

        }
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = sourceDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtSourceLocation.Text = sourceDialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = destinationDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txtDestLocation.Text = destinationDialog.SelectedPath;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                SortAIcon.Visible = true;
                SortAIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                SortAIcon.Visible = false;
            }
        }
    }
}
