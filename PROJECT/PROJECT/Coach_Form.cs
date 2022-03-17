using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class Coach_Form : Form
    {
        public Person Add1 { set; get; }
        public Coach_Form()
        {
            InitializeComponent();
        }
        private void Coach_Form_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
       private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = Convert.ToInt32(textBox2.Text);
            string nationality = textBox3.Text;
            decimal salary = Convert.ToDecimal(textBox4.Text);
            int matches = Convert.ToInt32(textBox5.Text);
            int yoe = Convert.ToInt32(textBox6.Text);

            Coach c = new Coach(name, age, nationality, salary, matches, yoe);
            Add1 = c;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
