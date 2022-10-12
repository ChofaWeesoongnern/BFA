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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Close();
        }

        private MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || comboBox2.Text.Trim() == "" || comboBox1.Text.Trim() == "" || comboBox4.Text.Trim() == "" || comboBox3.Text.Trim() == "" || textBox10.Text.Trim() == "")
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
                        string sql4 = $"SELECT * FROM ลูกผสม2 WHERE ชื่อโค2 = '{comboBox4.Text}' AND เลขโค2 = '{comboBox3.Text}'";
                        var cmd4 = new MySqlCommand(sql4, conn);
                        DataTable dt4 = new DataTable();
                        new MySqlDataAdapter(cmd4).Fill(dt4);
                        if (dt4.Rows.Count > 0)
                        {
                            string sql6 = $"SELECT * FROM ลูกผสม3 WHERE เลขโค3 = '{textBox2.Text+textBox10+textBox11}'";
                            var cmd6 = new MySqlCommand(sql6, conn);
                            DataTable dt6 = new DataTable();
                            new MySqlDataAdapter(cmd6).Fill(dt6);
                            if (dt6.Rows.Count < 1)
                            {
                                String SQL = "INSERT INTO ลูกผสม3 (ชื่อโค3,เลขโค3,ชื่อพ่อโค3,ชื่อแม่โค3,เลขพ่อโค3,เลขแม่โค3,ชื่อเจ้าของ,ชื่อฟาร์ม,สถานะ,day,รับ) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "' '" + textBox10.Text + "' '" + textBox11.Text + "' , '" + comboBox2.Text + "' , '" + comboBox4.Text + "' , '" + comboBox1.Text + "' , '" + comboBox3.Text + "' , '" + textBox7.Text + "' , '" + textBox8.Text + "' , 'ยังไม่ได้รับ' , '" + label14.Text + "' , '00/00/0000')";

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
                        MessageBox.Show("ข้อมูลไม่ถูกต้อง");
                    }
                }
                else
                {
                    MessageBox.Show("กรุณากรอกไม่เกิน5หลัก");
                }
            }
        }

        private void textbox1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textbox3(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textbox6(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textbox7(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label4.Text = Form12.globalTable.Rows[0][4].ToString();
            textBox7.Text = Form12.globalTable.Rows[0][0].ToString();
            textBox8.Text = Form12.globalTable.Rows[0][3].ToString();
            textBox2.Text = Form12.globalTable.Rows[0][6].ToString();
            label14.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form8_Shown(object sender, EventArgs e)
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

            string sql3 = $"SELECT * FROM ลูกผสม2 WHERE ชื่อฟาร์ม = '{textBox8.Text}'";
            MySqlCommand cmd5 = new MySqlCommand(sql3, conn);
            conn.Open();
            DataTable dt5 = new DataTable();
            new MySqlDataAdapter(cmd5).Fill(dt5);
            MySqlDataReader xxxx1 = cmd5.ExecuteReader();

            while (xxxx1.Read())
            {
                comboBox3.Items.Add($"{xxxx1.GetString(1)}");
                comboBox4.Items.Add($"{xxxx1.GetString(0)}");
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql4 = "SELECT * FROM ลูกผสม2 WHERE เลขโค2 = '" + comboBox3.Text + "' ";
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd6 = new MySqlCommand(sql4, conn);
            conn.Open();
            DataTable dt6 = new DataTable();
            new MySqlDataAdapter(cmd6).Fill(dt6);
            MySqlDataReader xxxx2 = cmd6.ExecuteReader();

            while (xxxx2.Read())
            {
                comboBox4.Text = xxxx2.GetString(0);
            }
            conn.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql4 = "SELECT * FROM ลูกผสม2 WHERE ชื่อโค2 = '" + comboBox4.Text + "' ";
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd6 = new MySqlCommand(sql4, conn);
            conn.Open();
            DataTable dt6 = new DataTable();
            new MySqlDataAdapter(cmd6).Fill(dt6);
            MySqlDataReader xxxx2 = cmd6.ExecuteReader();

            while (xxxx2.Read())
            {
                comboBox3.Text = xxxx2.GetString(1);
            }
            conn.Close();
        }
    }
}
