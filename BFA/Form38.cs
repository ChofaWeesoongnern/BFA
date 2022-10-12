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
    public partial class Form38 : Form
    {
        public Form38()
        {
            InitializeComponent();
        }

        private void Form38_Load(object sender, EventArgs e)
        {
            label4.Text = Form13.globalTable.Rows[0][0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form36 form36 = new Form36();
            form36.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form37 form37 = new Form37();
            form37.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form39 form39 = new Form39();
            form39.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form40 form40 = new Form40();
            form40.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form41 form41 = new Form41();
            form41.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form42 form42 = new Form42();
            form42.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form43 form43 = new Form43();
            form43.Show();
            this.Hide();
        }
    }
}
