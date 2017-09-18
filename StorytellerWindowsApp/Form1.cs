using StorytellerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorytellerWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Storyteller storyteller = new Storyteller();
                textStory.Text = storyteller.TellStory(
                    textBox1.Text,
                    Convert.ToInt32(numAgeOfChild.Value),
                    checkBoxScary.Checked
                    );
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Kan inte berätta storyn för dig");
            }
        }
    }
}
