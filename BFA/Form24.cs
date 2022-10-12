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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.Show();
            this.Close();
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            label4.Text = Form12.globalTable.Rows[0][4].ToString();
        }

        private void Form24_Shown(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM เลือดร้อยตัวผู้";
            MySqlConnection conn3 = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn3);
            conn3.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                comboBox2.Items.Add($"{xxxx.GetString(1)}");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM เลือดร้อยตัวผู้ WHERE เลขโค100ตัวผู้ like '" + comboBox2.Text + "' ";
            MySqlConnection conn3 = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn3);
            conn3.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                label32.Text = xxxx.GetString(1);
                label37.Text = xxxx.GetString(6);
                label36.Text = xxxx.GetString(7);
                label1.Text = xxxx.GetString(4);
                label6.Text = xxxx.GetString(5);
            }
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text.Trim() == "-")
            {
                label12.Text = "-";
                label13.Text = "-";
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                string sql = $"SELECT * FROM เลือดร้อยตัวผู้ WHERE เลขโค100ตัวผู้ = '{label1.Text}' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                MySqlDataReader xxxx = cmd.ExecuteReader();

                while (xxxx.Read())
                {
                    label12.Text = xxxx.GetString(4);
                }
                conn.Close();

                string sql1 = $"SELECT * FROM เลือดร้อยตัวผู้ WHERE เลขโค100ตัวผู้ = '{label1.Text}' ";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                conn.Open();
                DataTable dt1 = new DataTable();
                new MySqlDataAdapter(cmd1).Fill(dt1);
                MySqlDataReader xxxx1 = cmd1.ExecuteReader();

                while (xxxx1.Read())
                {
                    label13.Text = xxxx1.GetString(5);
                }
                conn.Close();
            }
        }

        private void label12_TextChanged(object sender, EventArgs e)
        {
            if (label12.Text.Trim() == "-")
            {
                label15.Text = "-";
                label16.Text = "-";
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                string sql0 = $"SELECT * FROM เลือดร้อยตัวผู้ WHERE เลขโค100ตัวผู้ = '{label12.Text}' ";
                MySqlCommand cmd0 = new MySqlCommand(sql0, conn);
                conn.Open();
                DataTable dt0 = new DataTable();
                new MySqlDataAdapter(cmd0).Fill(dt0);
                MySqlDataReader xxxx0 = cmd0.ExecuteReader();

                while (xxxx0.Read())
                {
                    label15.Text = xxxx0.GetString(4);
                }
                conn.Close();

                string sql4 = $"SELECT * FROM เลือดร้อยตัวผู้ WHERE เลขโค100ตัวผู้ = '{label12.Text}' ";
                MySqlCommand cmd4 = new MySqlCommand(sql4, conn);
                conn.Open();
                DataTable dt4 = new DataTable();
                new MySqlDataAdapter(cmd4).Fill(dt4);
                MySqlDataReader xxxx4 = cmd4.ExecuteReader();

                while (xxxx4.Read())
                {
                    label16.Text = xxxx4.GetString(5);
                }
                conn.Close();
            }
        }

        private void label13_TextChanged(object sender, EventArgs e)
        {
            if (label13.Text.Trim() == "-")
            {
                label18.Text = "-";
                label20.Text = "-";
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                string sql2 = $"SELECT * FROM ลูกผสม4 WHERE เลขโค4 = '{label13.Text}' ";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                conn.Open();
                DataTable dt2 = new DataTable();
                new MySqlDataAdapter(cmd2).Fill(dt2);
                MySqlDataReader xxx2 = cmd2.ExecuteReader();

                while (xxx2.Read())
                {
                    label18.Text = xxx2.GetString(4);
                }
                conn.Close();

                string sql3 = $"SELECT * FROM เลือดร้อย WHERE เลขโค100 = '{label13.Text}' ";
                MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                conn.Open();
                DataTable dt3 = new DataTable();
                new MySqlDataAdapter(cmd3).Fill(dt3);
                MySqlDataReader xxxx3 = cmd3.ExecuteReader();

                while (xxxx3.Read())
                {
                    label18.Text = xxxx3.GetString(4);
                }
                conn.Close();

                string sql5 = $"SELECT * FROM ลูกผสม4 WHERE เลขโค4 = '{label13.Text}' ";
                MySqlCommand cmd5 = new MySqlCommand(sql5, conn);
                conn.Open();
                DataTable dt5 = new DataTable();
                new MySqlDataAdapter(cmd5).Fill(dt5);
                MySqlDataReader xxxx5 = cmd5.ExecuteReader();

                while (xxxx5.Read())
                {
                    label20.Text = xxxx5.GetString(5);
                }
                conn.Close();

                string sql6 = $"SELECT * FROM เลือดร้อย WHERE เลขโค100 = '{label13.Text}' ";
                MySqlCommand cmd6 = new MySqlCommand(sql6, conn);
                conn.Open();
                DataTable dt6 = new DataTable();
                new MySqlDataAdapter(cmd6).Fill(dt6);
                MySqlDataReader xxxx6 = cmd6.ExecuteReader();

                while (xxxx6.Read())
                {
                    label20.Text = xxxx6.GetString(5);
                }
                conn.Close();
            }
        }

        private void label6_TextChanged(object sender, EventArgs e)
        {
            if (label6.Text.Trim() == "-")
            {
                label22.Text = "-";
                label8.Text = "-";
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                string sql = $"SELECT * FROM ลูกผสม4 WHERE เลขโค4 = '{label6.Text}' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                MySqlDataReader xxxx = cmd.ExecuteReader();

                while (xxxx.Read())
                {
                    label22.Text = xxxx.GetString(4);
                }
                conn.Close();

                string sql1 = $"SELECT * FROM ลูกผสม4 WHERE เลขโค4 = '{label6.Text}' ";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                conn.Open();
                DataTable dt1 = new DataTable();
                new MySqlDataAdapter(cmd1).Fill(dt1);
                MySqlDataReader xxxx1 = cmd1.ExecuteReader();

                while (xxxx1.Read())
                {
                    label8.Text = xxxx1.GetString(5);
                }
                conn.Close();

                string sql7 = $"SELECT * FROM เลือดร้อย WHERE เลขโค100 = '{label6.Text}' ";
                MySqlCommand cmd7 = new MySqlCommand(sql7, conn);
                conn.Open();
                DataTable dt7 = new DataTable();
                new MySqlDataAdapter(cmd7).Fill(dt7);
                MySqlDataReader xxxx7 = cmd7.ExecuteReader();

                while (xxxx7.Read())
                {
                    label22.Text = xxxx7.GetString(4);
                }
                conn.Close();

                string sql8 = $"SELECT * FROM เลือดร้อย WHERE เลขโค100 = '{label6.Text}' ";
                MySqlCommand cmd8 = new MySqlCommand(sql8, conn);
                conn.Open();
                DataTable dt8 = new DataTable();
                new MySqlDataAdapter(cmd8).Fill(dt8);
                MySqlDataReader xxxx8 = cmd8.ExecuteReader();

                while (xxxx8.Read())
                {
                    label8.Text = xxxx8.GetString(5);
                }
                conn.Close();
            }
        }

        private void label22_TextChanged(object sender, EventArgs e)
        {
            if (label22.Text.Trim() == "-")
            {
                label24.Text = "-";
                label26.Text = "-";
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                string sql0 = $"SELECT * FROM เลือดร้อยตัวผู้ WHERE เลขโค100ตัวผู้ = '{label22.Text}' ";
                MySqlCommand cmd0 = new MySqlCommand(sql0, conn);
                conn.Open();
                DataTable dt0 = new DataTable();
                new MySqlDataAdapter(cmd0).Fill(dt0);
                MySqlDataReader xxxx0 = cmd0.ExecuteReader();

                while (xxxx0.Read())
                {
                    label24.Text = xxxx0.GetString(4);
                }
                conn.Close();

                string sql4 = $"SELECT * FROM เลือดร้อยตัวผู้ WHERE เลขโค100ตัวผู้ = '{label22.Text}' ";
                MySqlCommand cmd4 = new MySqlCommand(sql4, conn);
                conn.Open();
                DataTable dt4 = new DataTable();
                new MySqlDataAdapter(cmd4).Fill(dt4);
                MySqlDataReader xxxx4 = cmd4.ExecuteReader();

                while (xxxx4.Read())
                {
                    label26.Text = xxxx4.GetString(5);
                }
                conn.Close();
            }
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text.Trim() == "-")
            {
                label28.Text = "-";
                label30.Text = "-";
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                string sql = $"SELECT * FROM ลูกผสม3 WHERE เลขโค3 = '{label8.Text}' ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                MySqlDataReader xxxx = cmd.ExecuteReader();

                while (xxxx.Read())
                {
                    label28.Text = xxxx.GetString(4);
                }
                conn.Close();

                string sql1 = $"SELECT * FROM ลูกผสม3 WHERE เลขโค3 = '{label8.Text}' ";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                conn.Open();
                DataTable dt1 = new DataTable();
                new MySqlDataAdapter(cmd1).Fill(dt1);
                MySqlDataReader xxxx1 = cmd1.ExecuteReader();

                while (xxxx1.Read())
                {
                    label30.Text = xxxx1.GetString(5);
                }
                conn.Close();

                string sql9 = $"SELECT * FROM ลูกผสม4 WHERE เลขโค4 = '{label8.Text}' ";
                MySqlCommand cmd9 = new MySqlCommand(sql9, conn);
                conn.Open();
                DataTable dt9 = new DataTable();
                new MySqlDataAdapter(cmd9).Fill(dt9);
                MySqlDataReader xxxx9 = cmd9.ExecuteReader();

                while (xxxx9.Read())
                {
                    label28.Text = xxxx9.GetString(4);
                }
                conn.Close();

                string sql10 = $"SELECT * FROM ลูกผสม4 WHERE เลขโค4 = '{label8.Text}' ";
                MySqlCommand cmd10 = new MySqlCommand(sql10, conn);
                conn.Open();
                DataTable dt10 = new DataTable();
                new MySqlDataAdapter(cmd10).Fill(dt10);
                MySqlDataReader xxxx10 = cmd10.ExecuteReader();

                while (xxxx10.Read())
                {
                    label30.Text = xxxx10.GetString(5);
                }
                conn.Close();

                string sql11 = $"SELECT * FROM เลือดร้อย WHERE เลขโค100 = '{label8.Text}' ";
                MySqlCommand cmd11 = new MySqlCommand(sql11, conn);
                conn.Open();
                DataTable dt11 = new DataTable();
                new MySqlDataAdapter(cmd11).Fill(dt11);
                MySqlDataReader xxxx11 = cmd11.ExecuteReader();

                while (xxxx11.Read())
                {
                    label28.Text = xxxx11.GetString(4);
                }
                conn.Close();

                string sql12 = $"SELECT * FROM เลือดร้อย WHERE เลขโค100 = '{label8.Text}' ";
                MySqlCommand cmd12 = new MySqlCommand(sql12, conn);
                conn.Open();
                DataTable dt12 = new DataTable();
                new MySqlDataAdapter(cmd12).Fill(dt12);
                MySqlDataReader xxxx12 = cmd12.ExecuteReader();

                while (xxxx12.Read())
                {
                    label30.Text = xxxx12.GetString(5);
                }
                conn.Close();
            }
        }
    }
}
