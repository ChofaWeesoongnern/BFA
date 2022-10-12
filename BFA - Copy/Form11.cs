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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
