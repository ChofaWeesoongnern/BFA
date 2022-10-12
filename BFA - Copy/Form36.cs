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
    public partial class Form36 : Form
    {
        public Form36()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Close();
        }

        private void Form36_Load(object sender, EventArgs e)
        {
            label5.Text = Form13.globalTable.Rows[0][0].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form35 form35 = new Form35();
            form35.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form38 form38 = new Form38();
            form38.Show();
            this.Hide();
        }
    }
}
