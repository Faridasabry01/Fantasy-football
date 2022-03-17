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
    public partial class Player_Form : Form
    {
        public Person Add2 { set; get; }
        public Player_Form()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Field_Form field = new Field_Form();
              field.ShowDialog();
              Add2 = field.Add3;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GK_Form gk = new GK_Form();
            gk.ShowDialog();
            Add2 = gk.Add4;
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
