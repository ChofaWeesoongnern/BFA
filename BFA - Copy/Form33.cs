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
    public partial class Form33 : Form
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void Form33_Load(object sender, EventArgs e)
        {
            label5.Text = Form12.globalTable.Rows[0][4].ToString();
            label9.Text = Form12.globalTable.Rows[0][0].ToString();
            label10.Text = Form12.globalTable.Rows[0][1].ToString();
            label11.Text = Form12.globalTable.Rows[0][2].ToString();
            label12.Text = Form12.globalTable.Rows[0][3].ToString();
            label8.Text = Form12.globalTable.Rows[0][7].ToString();
            label13.Text = Form12.globalTable.Rows[0][8].ToString();
            label15.Text = Form12.globalTable.Rows[0][9].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Close();
        }
    }
}
