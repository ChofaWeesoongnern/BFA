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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Close();
        }

        private void Form17_Shown(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM สมัครสมาชิกสมาคม";
            MySqlConnection conn3 = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn3);
            conn3.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                comboBox2.Items.Add($"{xxxx.GetString(0)}");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM สมัครสมาชิกสมาคม WHERE ชื่อ like '" + "%" + comboBox2.Text + "%" + "' ";
            MySqlConnection conn3 = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn3);
            conn3.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                textBox1.Text = xxxx.GetString(0);
                textBox2.Text = xxxx.GetString(1);
                textBox6.Text = xxxx.GetString(2);
                textBox3.Text = xxxx.GetString(3);
                textBox10.Text = xxxx.GetString(6);
                textBox7.Text = xxxx.GetString(4);
                textBox8.Text = xxxx.GetString(5);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox6.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox10.Text.Trim() == "" || textBox7.Text.Trim() == "" || textBox8.Text.Trim() == "" || comboBox2.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกให้ครบ");
            }
            else
            {
                if (textBox6.Text.Length == 10)
                {
                    MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                    
                    String sql = "UPDATE สมัครสมาชิกสมาคม SET ชื่อ = '" +textBox1.Text+ "',ที่อยู่ = '" +textBox2.Text+ "',เบอร์โทร = '" +textBox6.Text+ "',ชื่อฟาร์ม = '" +textBox3.Text+ "',username = '" +textBox7.Text+ "',password = '" +textBox8.Text+ "',ตัวย่อ = '" +textBox10.Text+ "' WHERE username = '"+textBox7.Text+"'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                        Form16 form16 = new Form16();
                        form16.Show();
                        this.Close();
                    } 
                }
                else
                {
                    MessageBox.Show("กรุณากรอกให้ครบ 10 หลัก");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            label10.Text = Form13.globalTable.Rows[0][0].ToString();
        }
    }
}
