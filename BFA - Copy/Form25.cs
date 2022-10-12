using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BFA
{
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Close();
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            label4.Text = Form13.globalTable.Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form26 form26 = new Form26();
            form26.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form27 form27 = new Form27();
            form27.Show();
            this.Hide();
        }
    }
}
