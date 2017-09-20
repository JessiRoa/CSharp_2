using ExamLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWindowsApp
{
    public partial class Form1 : Form
    {
        private Exam enExam = new Exam("CSharp");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text);
            enExam.Assign(student);
            comboBox1.Items.Add(student);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enExam.Grade((Student)comboBox1.SelectedItem, comboBox2.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var gradeCountDirectory = enExam.GenerateStatistics();
            var ig = gradeCountDirectory["IG"];
            var g = gradeCountDirectory["G"];
            var vg = gradeCountDirectory["VG"];
            label1.Text = $"IG: {ig}";
            label2.Text = $"G: {g}";
            label3.Text = $"VG: {vg}";
        }
    }
}
