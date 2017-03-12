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

namespace Sort.AI
{
    public partial class SortAISettings : Form
    {
        public static string fileRead;

        public SortAISettings()
        {
            InitializeComponent();
            SortAIcon.BalloonTipText = "Sort.AI Is Running In The Background";
            SortAIcon.BalloonTipTitle = "Sort.AI";
            SortAIcon.BalloonTipIcon = ToolTipIcon.Info;

        }

        public static string ReadFiles(string fileName, string filePath)
        {
            string fileExt = Path.GetExtension(fileName);
            string[] acceptedExtensions = { ".txt" };
            if (acceptedExtensions.Contains(fileExt))
            {
                string textContent = File.ReadAllText(filePath);
                return textContent;
            }
            else
            {
                string textContent = "";
                return textContent;
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

        private void SortAISettings_Resize(object sender, EventArgs e)
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

        private void SortAIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                this.Show();
                this.WindowState = FormWindowState.Normal;
        }

        private void txtSourceLocation_Validating(object sender, CancelEventArgs e)
        {
            if (Directory.Exists(txtSourceLocation.Text) == false)
            {
                lblValidDir.Visible = true;
            }
            else
            {
                lblValidDir.Visible = false;
            }
        }

        private void txtDestLocation_Validating(object sender, CancelEventArgs e)
        {
            if (Directory.Exists(txtDestLocation.Text) == false)
            {
                lblValidDir.Visible = true;
            }
            else
            {
                lblValidDir.Visible = false;
            }
        }
    }
}
