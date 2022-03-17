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
    public partial class GK_Form : Form
    {
        public GK_Form()
        {
            InitializeComponent();
        }
        public Person Add4 { set; get; }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = textBox12.Text;
            int age = Convert.ToInt32(textBox11.Text);
            string nationality = textBox10.Text;
            decimal salary = Convert.ToDecimal(textBox9.Text);
            int matches = Convert.ToInt32(textBox8.Text);
            int number = Convert.ToInt32(textBox1.Text);
            string position = textBox2.Text;
            int cleansheet = Convert.ToInt32(textBox3.Text);

            string team = textBox4.Text;
            int cups = Convert.ToInt32(textBox5.Text);
            int awards = Convert.ToInt32(textBox6.Text);
            int cards = Convert.ToInt32(textBox7.Text);

            Stats stat = new Stats(team, cups, awards, cards);

            Goalkeeper g = new Goalkeeper(name, age, nationality, salary, matches, number, position, cleansheet, stat);
            Add4 = g;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
