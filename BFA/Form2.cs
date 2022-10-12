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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Close();
        }
        
        private MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox6.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox7.Text.Trim() == "" || textBox8.Text.Trim() == "" || textBox9.Text.Trim() == "" || textBox10.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกให้ครบ");
            }
            
            else 
            {
               if (textBox6.Text.Length == 10)
                {
                    MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                    conn.Open();
                    DataTable dt4 = new DataTable();
                    string sql4 = $"SELECT * FROM สมัครสมาชิกสมาคม WHERE เบอร์โทร = '{textBox6.Text}'";
                    var cmd4 = new MySqlCommand(sql4, conn);
                    new MySqlDataAdapter(cmd4).Fill(dt4);
                    if (dt4.Rows.Count < 1)
                    {
                        string sql3 = $"SELECT * FROM สมัครสมาชิกสมาคม WHERE ชื่อฟาร์ม = '{textBox3.Text}'";
                        var cmd3 = new MySqlCommand(sql3, conn);
                        DataTable dt3 = new DataTable();
                        new MySqlDataAdapter(cmd3).Fill(dt3);
                        if (dt3.Rows.Count < 1)
                        {
                            string sql1 = $"SELECT * FROM สมัครสมาชิกสมาคม WHERE username = '{textBox7.Text}'";
                            var cmd1 = new MySqlCommand(sql1, conn);
                            DataTable dt1 = new DataTable();
                            new MySqlDataAdapter(cmd1).Fill(dt1);
                            if (dt1.Rows.Count < 1)
                            {
                                string sql2 = $"SELECT * FROM สมัครสมาชิกสมาคม WHERE password = '{textBox8.Text}'";
                                var cmd2 = new MySqlCommand(sql2, conn);
                                DataTable dt2 = new DataTable();
                                new MySqlDataAdapter(cmd2).Fill(dt2);
                                if (dt2.Rows.Count < 1)
                                {
                                    string sql5 = $"SELECT * FROM สมัครสมาชิกสมาคม WHERE ตัวย่อ = '{textBox10.Text}'";
                                    var cmd5 = new MySqlCommand(sql5, conn);
                                    DataTable dt5 = new DataTable();
                                    new MySqlDataAdapter(cmd5).Fill(dt5);
                                    if (dt5.Rows.Count < 1)
                                    {
                                        if (textBox9.Text.Trim() == textBox8.Text.Trim())
                                        {
                                            String sql = "INSERT INTO สมัครสมาชิกสมาคม (ชื่อ,ที่อยู่,เบอร์โทร,ชื่อฟาร์ม,username,password,ตัวย่อ,สถานะ,day,รับ) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox6.Text + "' , '" + textBox3.Text + "' , '" + textBox7.Text + "' , '" + textBox8.Text + "' , '" + textBox10.Text + "' , 'ยังไม่ได้รับ' , '" + label10.Text + "' , '00/00/0000')";

                                            MySqlCommand cmd = new MySqlCommand(sql, conn);

                                            int rows = cmd.ExecuteNonQuery();
                                            conn.Close();

                                            if (rows > 0)
                                            {
                                                MessageBox.Show("สมัครเรียบร้อย ทางสมาคมจะส่งใบรับรองให้ท่าน");
                                                Form11 form11 = new Form11();
                                                form11.Show();
                                                this.Close();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("ข้อมูลไม่ถูกต้อง");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("ข้อมูลซ้ำ");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("ข้อมูลซ้ำ");
                                }
                            }
                            else
                            {
                                MessageBox.Show("ข้อมูลซ้ำ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("ข้อมูลซ้ำ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ข้อมูลซ้ำ");
                    }
                }
               else
                {
                    MessageBox.Show("กรุณากรอกให้ครบ 10 หลัก");
                }
            }
        }
            
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtB_ONLY_NUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textbox4(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textbox5(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textbox1(object sender, KeyPressEventArgs e)
        {
            
        }
        
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox8.PasswordChar = '\0';
                textBox9.PasswordChar = '\0';
            }
            else
            {
                textBox8.PasswordChar = '*';
                textBox9.PasswordChar = '*';
            }
        }

        private void label10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
