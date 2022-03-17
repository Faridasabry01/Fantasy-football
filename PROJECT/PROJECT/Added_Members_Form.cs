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
    public partial class Added_Members_Form : Form
    {
         public List<Person> people = new List<Person>();
        public Added_Members_Form()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Added_Members_Form_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = people;
        }
      
    }
}
