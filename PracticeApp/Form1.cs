using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            var birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd") + ";";
            string name = textBox1.Text + ";";
            var phone = int.Parse(textBox2.Text);
            File.WriteAllText(textBox1.Text + ".txt", birthday + name + phone);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var fileText = File.ReadAllText(openFileDialog1.FileName); 
            //MessageBox.Show(fileText);
            var result = fileText.Split(';');
            saveFileDialog1.ShowDialog();
            var age = Math.Round(DateTime.Now.Subtract(DateTime.Parse(result[0])).TotalDays / 365);
            File.WriteAllText(saveFileDialog1.FileName, result[1] + " är " + age + " år gammal och har telefonnummer " + result[2]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
