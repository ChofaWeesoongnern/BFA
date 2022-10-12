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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            label4.Text = Form12.globalTable.Rows[0][4].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = Form12.globalTable.Rows[0][4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            form21.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            form22.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23();
            form23.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24();
            form24.Show();
            this.Hide();
        }
    }
}
