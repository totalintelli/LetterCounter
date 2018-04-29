using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterCounter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInputString_TextChanged(object sender, EventArgs e)
        {
            // Initialize letterCount to 0
            int letterCount = 0;

            // Get letterCount from inputString
            letterCount = txtInputString.Text.Length;

            if (letterCount > 0)
            {
                // Display inputString + " has " + letterCount + " characters."
                lbLetterCount.Text = txtInputString.Text + " has " + letterCount + " characters.";
            }
        }
    }
}
