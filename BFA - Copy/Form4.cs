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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox10.Text.Trim() == "" || comboBox2.Text.Trim() == "" || comboBox1.Text.Trim() == "" || textBox6.Text.Trim() == "" || textBox5.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกให้ครบ");
            }
            else
            {
                if (textBox10.Text.Length <= 5)
                {
                    MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                    conn.Open();
                    DataTable dt = new DataTable();
                    string sql = $"SELECT * FROM เลือดร้อยตัวผู้ WHERE ชื่อโค100ตัวผู้ = '{comboBox2.Text}' AND เลขโค100ตัวผู้ = '{comboBox1.Text}'";
                    var cmd = new MySqlCommand(sql, conn);
                    new MySqlDataAdapter(cmd).Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        string sql6 = $"SELECT * FROM ลูกผสม WHERE เลขโค = '{textBox2.Text+textBox10.Text+textBox11.Text}'";
                        var cmd6 = new MySqlCommand(sql6, conn);
                        DataTable dt6 = new DataTable();
                        new MySqlDataAdapter(cmd6).Fill(dt6);
                        if (dt6.Rows.Count < 1)
                        {
                            String SQL = "INSERT INTO ลูกผสม (ชื่อโค,เลขโค,ชื่อพ่อโค,ชื่อแม่โค,เลขพ่อโค,เลขแม่โค,ชื่อเจ้าของ,ชื่อฟาร์ม,สถานะ,day,รับ) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "' '" + textBox10.Text + "' '" + textBox11.Text + "' , '" + comboBox2.Text + "' , '" + textBox6.Text + "' , '" + comboBox1.Text + "' , '" + textBox5.Text + "' , '" + textBox7.Text + "' , '" + textBox8.Text + "' , '" + label13.Text + "' , '" + label14.Text + "' , '" + label15.Text + "')";

                            MySqlCommand CMD = new MySqlCommand(SQL, conn);

                            int abc = CMD.ExecuteNonQuery();
                            conn.Close();
                            if (abc > 0)
                            {
                                MessageBox.Show("จดทะเบียนเรียบร้อย ทางสมาคมจะส่งใบเพ็ดดีกรีให้ท่าน");
                                Form10 form10 = new Form10();
                                form10.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("ข้อมูลซ้ำ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ข้อมูลไม่ถูกต้อง");
                    }
                }
                else
                {
                    MessageBox.Show("กรุณากรอกไม่เกิน5หลัก");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textbox1(object sender, KeyPressEventArgs e)
        {
            
        }

        

        private void textbox6(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textbox7(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label4.Text = Form12.globalTable.Rows[0][4].ToString();
            textBox7.Text = Form12.globalTable.Rows[0][0].ToString();
            textBox8.Text = Form12.globalTable.Rows[0][3].ToString();
            textBox2.Text = Form12.globalTable.Rows[0][6].ToString();
            label14.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM เลือดร้อยตัวผู้";
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn);
            conn.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                comboBox1.Items.Add($"{xxxx.GetString(1)}");
                comboBox2.Items.Add($"{xxxx.GetString(0)}");
            }
            conn.Close();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM เลือดร้อยตัวผู้ WHERE เลขโค100ตัวผู้ like '" + comboBox1.Text + "' ";
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn);
            conn.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                comboBox2.Text = xxxx.GetString(0);
            }
            conn.Close();
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM เลือดร้อยตัวผู้ WHERE ชื่อโค100ตัวผู้ like '" + comboBox2.Text + "' ";
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn);
            conn.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                comboBox1.Text = xxxx.GetString(1);
            }
            conn.Close();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
