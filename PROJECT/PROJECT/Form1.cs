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
    public partial class Form1 : Form
    {
        Added_Members_Form m = new Added_Members_Form();
        public List<Person> p = new List<Person>(); 
        public Person Added { set; get; }
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Coach_Form window=new Coach_Form();
            window.ShowDialog();
            Added = window.Add1;
            add();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Player_Form player = new Player_Form();
            player.ShowDialog();
            Added = player.Add2;
            add();
        }
        private void button3_Click(object sender, EventArgs e)
        {
                m.ShowDialog();
                this.Close();
        }
        private void add()
        {
                if (Added != null)
                {
                    p.Add(Added);
                    m.people.Add(Added);
                    Added = null;
                }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
