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
    public partial class Form35 : Form
    {
        private MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
        private MySqlConnection databaseConnection()
        {
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            return conn;
        }
        private void showdata()
        {
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ชื่อ,ชื่อฟาร์ม,username,สถานะ,day,รับ FROM สมัครสมาชิกสมาคม";
            
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        public Form35()
        {
            InitializeComponent();
        }

        private void Form35_Load(object sender, EventArgs e)
        {
            label5.Text = Form13.globalTable.Rows[0][0].ToString();

            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            conn.Open();
            DataTable dt = new DataTable();
            string sql = $"SELECT * FROM สมัครสมาชิกสมาคม";
            var cmd = new MySqlCommand(sql, conn);
            new MySqlDataAdapter(cmd).Fill(dt);
            label12.Text = dt.Rows.Count.ToString();
            conn.Close();

            conn.Open();
            DataTable dt0 = new DataTable();
            string sql0 = $"SELECT * FROM สมัครสมาชิกสมาคม WHERE สถานะ = 'ได้รับแล้ว'";
            var cmd0 = new MySqlCommand(sql0, conn);
            new MySqlDataAdapter(cmd0).Fill(dt0);
            label15.Text = dt0.Rows.Count.ToString();
            conn.Close();

            label17.Text = (Convert.ToInt32(label12.Text) - Convert.ToInt32(label15.Text)).ToString();

            showdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form36 form36 = new Form36();
            form36.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            label4.Text = dataGridView1.Rows[e.RowIndex].Cells["ชื่อ"].FormattedValue.ToString();
            label6.Text = dataGridView1.Rows[e.RowIndex].Cells["ชื่อฟาร์ม"].FormattedValue.ToString();
            label8.Text = dataGridView1.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["สถานะ"].FormattedValue.ToString();
            label11.Text = dataGridView1.Rows[e.RowIndex].Cells["day"].FormattedValue.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["รับ"].FormattedValue.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "" || textBox1.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกให้ครบ");
            }
            else
            {
                if (textBox1.Text.Length == 10)
                {
                    MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                    String sql = "UPDATE สมัครสมาชิกสมาคม SET สถานะ = '" + comboBox1.Text + "',รับ = '" + textBox1.Text + "' WHERE username = '" + label8.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("อัพเดตสถานะสำเร็จ");
                    }
                }
                else
                {
                    MessageBox.Show("กรุณากรอกให้ครบ 10 หลัก");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
