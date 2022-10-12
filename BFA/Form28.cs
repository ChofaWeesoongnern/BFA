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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Close();
        }

        private void Form28_Load(object sender, EventArgs e)
        {
            label4.Text = Form13.globalTable.Rows[0][0].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form29 form29 = new Form29();
            form29.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form30 form30 = new Form30();
            form30.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form31 form31 = new Form31();
            form31.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form32 form32 = new Form32();
            form32.Show();
            this.Hide();
        }
    }
}
