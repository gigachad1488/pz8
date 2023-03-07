using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patarn
{
    public partial class Form1 : Form
    {
        List<Itest> tests = new List<Itest>()
            {
                new normtest(),
                new difftest(),
                new exam()
            };
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[3] {tests[0].Name, tests[1].Name, tests[2].Name});
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            students.Add(new Student(textBox1.Text, tests[comboBox1.SelectedIndex]));
            listBox1.Items.Add($"Студент: {students[listBox1.Items.Count].Name}, Экзамен: {students[listBox1.Items.Count].test.Name}");
        }
    }
}
