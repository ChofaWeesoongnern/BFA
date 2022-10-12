using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFA
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            label5.Text = Form12.globalTable.Rows[0][4].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form33 form33 = new Form33();
            form33.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form34 form34 = new Form34();
            form34.Show();
            this.Hide();
        }
    }
}
