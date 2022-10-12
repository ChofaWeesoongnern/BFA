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
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        private void Form34_Load(object sender, EventArgs e)
        {
            label5.Text = Form12.globalTable.Rows[0][4].ToString();
            label11.Text = Form12.globalTable.Rows[0][0].ToString();
            label12.Text = Form12.globalTable.Rows[0][3].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Close();
        }

        private MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
        private void Form34_Shown(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            string sql2 = $"SELECT * FROM เลือดร้อย WHERE ชื่อฟาร์ม = '{label12.Text}'";
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn);
            conn.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                comboBox1.Items.Add($"{xxxx.GetString(1)}");
            }
            conn.Close();

            string sql6 = $"SELECT * FROM เลือดร้อยตัวผู้ WHERE ชื่อฟาร์ม = '{label12.Text}'";
            MySqlCommand cmd7 = new MySqlCommand(sql6, conn);
            conn.Open();
            DataTable dt7 = new DataTable();
            new MySqlDataAdapter(cmd7).Fill(dt7);
            MySqlDataReader xxxx3 = cmd7.ExecuteReader();

            while (xxxx3.Read())
            {
                comboBox1.Items.Add($"{xxxx3.GetString(1)}");
            }
            conn.Close();

            string sql1 = $"SELECT * FROM ลูกผสม WHERE ชื่อฟาร์ม = '{label12.Text}'";
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            conn.Open();
            DataTable dt1 = new DataTable();
            new MySqlDataAdapter(cmd1).Fill(dt1);
            MySqlDataReader xxxx1 = cmd1.ExecuteReader();

            while (xxxx1.Read())
            {
                comboBox1.Items.Add($"{xxxx1.GetString(1)}");
            }
            conn.Close();

            string sql3 = $"SELECT * FROM ลูกผสม2 WHERE ชื่อฟาร์ม = '{label12.Text}'";
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
            conn.Open();
            DataTable dt3 = new DataTable();
            new MySqlDataAdapter(cmd3).Fill(dt3);
            MySqlDataReader xxxx2 = cmd3.ExecuteReader();

            while (xxxx2.Read())
            {
                comboBox1.Items.Add($"{xxxx2.GetString(1)}");
            }
            conn.Close();

            string sql4 = $"SELECT * FROM ลูกผสม3 WHERE ชื่อฟาร์ม = '{label12.Text}'";
            MySqlCommand cmd5 = new MySqlCommand(sql4, conn);
            conn.Open();
            DataTable dt5 = new DataTable();
            new MySqlDataAdapter(cmd5).Fill(dt5);
            MySqlDataReader xxxx4 = cmd5.ExecuteReader();

            while (xxxx4.Read())
            {
                comboBox1.Items.Add($"{xxxx4.GetString(1)}");
            }
            conn.Close();

            string sql5 = $"SELECT * FROM ลูกผสม4 WHERE ชื่อฟาร์ม = '{label12.Text}'";
            MySqlCommand cmd6 = new MySqlCommand(sql5, conn);
            conn.Open();
            DataTable dt6 = new DataTable();
            new MySqlDataAdapter(cmd6).Fill(dt6);
            MySqlDataReader xxxx5 = cmd6.ExecuteReader();

            while (xxxx5.Read())
            {
                comboBox1.Items.Add($"{xxxx5.GetString(1)}");
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            string sql2 = "SELECT * FROM เลือดร้อย WHERE เลขโค100 like '" + comboBox1.Text + "' ";
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn);
            conn.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                label9.Text = xxxx.GetString(0);
                label10.Text = xxxx.GetString(1);
                label8.Text = xxxx.GetString(8);
                label14.Text = xxxx.GetString(9);
                label15.Text = xxxx.GetString(10);
            }
            conn.Close();

            string sql6 = "SELECT * FROM เลือดร้อยตัวผู้ WHERE เลขโค100ตัวผู้ like '" + comboBox1.Text + "' ";
            MySqlCommand cmd7 = new MySqlCommand(sql6, conn);
            conn.Open();
            DataTable dt7 = new DataTable();
            new MySqlDataAdapter(cmd7).Fill(dt7);
            MySqlDataReader xxxx3 = cmd7.ExecuteReader();

            while (xxxx3.Read())
            {
                label9.Text = xxxx3.GetString(0);
                label10.Text = xxxx3.GetString(1);
                label8.Text = xxxx3.GetString(8);
                label14.Text = xxxx3.GetString(9);
                label15.Text = xxxx3.GetString(10);
            }
            conn.Close();

            string sql1 = "SELECT * FROM ลูกผสม WHERE เลขโค like '" + comboBox1.Text + "' ";
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            conn.Open();
            DataTable dt1 = new DataTable();
            new MySqlDataAdapter(cmd1).Fill(dt1);
            MySqlDataReader xxxx1 = cmd1.ExecuteReader();

            while (xxxx1.Read())
            {
                label9.Text = xxxx1.GetString(0);
                label10.Text = xxxx1.GetString(1);
                label8.Text = xxxx1.GetString(8);
                label14.Text = xxxx1.GetString(9);
                label15.Text = xxxx1.GetString(10);
            }
            conn.Close();

            string sql3 = "SELECT * FROM ลูกผสม2 WHERE เลขโค2 like '" + comboBox1.Text + "' ";
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
            conn.Open();
            DataTable dt3 = new DataTable();
            new MySqlDataAdapter(cmd3).Fill(dt3);
            MySqlDataReader xxxx2 = cmd3.ExecuteReader();

            while (xxxx2.Read())
            {
                label9.Text = xxxx2.GetString(0);
                label10.Text = xxxx2.GetString(1);
                label8.Text = xxxx2.GetString(8);
                label14.Text = xxxx2.GetString(9);
                label15.Text = xxxx2.GetString(10);
            }
            conn.Close();

            string sql4 = "SELECT * FROM ลูกผสม3 WHERE เลขโค3 like '" + comboBox1.Text + "' ";
            MySqlCommand cmd5 = new MySqlCommand(sql4, conn);
            conn.Open();
            DataTable dt5 = new DataTable();
            new MySqlDataAdapter(cmd5).Fill(dt5);
            MySqlDataReader xxxx4 = cmd5.ExecuteReader();

            while (xxxx4.Read())
            {
                label9.Text = xxxx4.GetString(0);
                label10.Text = xxxx4.GetString(1);
                label8.Text = xxxx4.GetString(8);
                label14.Text = xxxx4.GetString(9);
                label15.Text = xxxx4.GetString(10);
            }
            conn.Close();

            string sql5 = "SELECT * FROM ลูกผสม4 WHERE เลขโค4 like '" + comboBox1.Text + "' ";
            MySqlCommand cmd6 = new MySqlCommand(sql5, conn);
            conn.Open();
            DataTable dt6 = new DataTable();
            new MySqlDataAdapter(cmd6).Fill(dt6);
            MySqlDataReader xxxx5 = cmd6.ExecuteReader();

            while (xxxx5.Read())
            {
                label9.Text = xxxx5.GetString(0);
                label10.Text = xxxx5.GetString(1);
                label8.Text = xxxx5.GetString(8);
                label14.Text = xxxx5.GetString(9);
                label15.Text = xxxx5.GetString(10);
            }
            conn.Close();
        }
    }
}
