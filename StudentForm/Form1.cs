using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentForm
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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Fresher");
            comboBox1.Items.Add("1-2 Years");
            comboBox1.Items.Add("2-5 Years");
            comboBox1.Items.Add("5+ Years");

            comboBox1.SelectedIndex = 0;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (radioButton1.Checked)
                gender = "Male";
            else if (radioButton2.Checked)
                gender = "Female";

            string marital = "";

            if (radioButton3.Checked)
                marital = "Married";
            else if (radioButton4.Checked)
                marital = "Unmarried";

            string qualification = "";

            if (checkBox1.Checked)
                qualification += "Diploma ";

            if (checkBox2.Checked)
                qualification += "UG ";

            if (checkBox3.Checked)
                qualification += "PG ";

            MessageBox.Show(
            "Name : " + textBox1.Text +
            "\nDate of Birth : " + dateTimePicker1.Text +
            "\nGender : " + gender +
            "\nMarital Status : " + marital +
            "\nQualification : " + qualification +
            "\nExperience : " + comboBox1.Text +
            "\nAbout Project : " + richTextBox1.Text,
            "Student Details"
            );
        }
    }
}
