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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" || textBox1.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกให้ครบ");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                conn.Open();
                DataTable dt = new DataTable();
                string sql = $"SELECT * FROM สมัครสมาชิกสมาคม WHERE username = '{textBox2.Text}' AND password = '{textBox1.Text}'";
                var cmd = new MySqlCommand(sql, conn);
                new MySqlDataAdapter(cmd).Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    conn.Close();
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ข้อมูลไม่ถูกต้อง");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Close();
        }
        public static DataTable globalTable = new DataTable();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            conn.Open();
            DataTable dt = new DataTable();
            string sql = $"SELECT * FROM สมัครสมาชิกสมาคม WHERE username = '{textBox2.Text}'";
            var cmd = new MySqlCommand(sql, conn);
            new MySqlDataAdapter(cmd).Fill(dt);
            globalTable = dt;
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
            this.Close();
        }
    }
}
