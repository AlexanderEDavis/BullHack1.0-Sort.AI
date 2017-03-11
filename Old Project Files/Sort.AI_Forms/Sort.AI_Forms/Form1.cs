using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort.AI_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
