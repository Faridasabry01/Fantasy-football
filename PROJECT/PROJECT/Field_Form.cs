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
    public partial class Field_Form : Form
    {
        public Person Add3 { set; get; }
        public Field_Form()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox12.Text;
            int age = Convert.ToInt32(textBox11.Text);
            string nationality = textBox10.Text;
            decimal salary = Convert.ToDecimal(textBox9.Text);
            int matches = Convert.ToInt32(textBox8.Text);
            int number = Convert.ToInt32(textBox1.Text);
            string position = textBox2.Text;
            int goals = Convert.ToInt32(textBox3.Text);

            string team = textBox4.Text;
            int cups = Convert.ToInt32(textBox5.Text);
            int awards = Convert.ToInt32(textBox6.Text);
            int cards = Convert.ToInt32(textBox7.Text);

            Stats stat = new Stats(team,cups,awards,cards);
            Field f= new Field(name, age, nationality, salary, matches, number, position, goals,stat);
            Add3 = f;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {  
        }
    }
}
