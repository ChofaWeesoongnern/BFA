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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
            this.Hide();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            label5.Text = Form13.globalTable.Rows[0][0].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            form25.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form28 form28 = new Form28();
            form28.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form36 form36 = new Form36();
            form36.Show();
            this.Hide();
        }
    }
}
