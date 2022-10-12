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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" || textBox1.Text.Trim() == "" || textBox3.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกให้ครบ");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                conn.Open();
                DataTable dt = new DataTable();
                string sql = $"SELECT * FROM loginuser WHERE username = '{textBox2.Text}' AND password = '{textBox1.Text}' AND รหัสลับ = '{textBox3.Text}'";
                var cmd = new MySqlCommand(sql, conn);
                new MySqlDataAdapter(cmd).Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Form16 form16 = new Form16();
                    form16.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ข้อมูลไม่ถูกต้อง");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        public static DataTable globalTable = new DataTable();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            conn.Open();
            DataTable dt = new DataTable();
            string sql = $"SELECT * FROM loginuser WHERE username = '{textBox2.Text}'";
            var cmd = new MySqlCommand(sql, conn);
            new MySqlDataAdapter(cmd).Fill(dt);
            globalTable = dt;
            conn.Close();
        }
    }
}
