﻿using System;
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
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void Form32_Load(object sender, EventArgs e)
        {
            label10.Text = Form13.globalTable.Rows[0][0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form28 form28 = new Form28();
            form28.Show();
            this.Close();
        }

        private MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
        private void Form32_Shown(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM ลูกผสม";
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn);
            conn.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                comboBox2.Items.Add($"{xxxx.GetString(1)}");
            }
            conn.Close();

            string sql6 = "SELECT * FROM เลือดร้อยตัวผู้";
            MySqlCommand cmd7 = new MySqlCommand(sql6, conn);
            conn.Open();
            DataTable dt7 = new DataTable();
            new MySqlDataAdapter(cmd7).Fill(dt7);
            MySqlDataReader xxxx3 = cmd7.ExecuteReader();

            while (xxxx3.Read())
            {
                comboBox5.Items.Add($"{xxxx3.GetString(1)}");
                comboBox1.Items.Add($"{xxxx3.GetString(0)}");
            }
            conn.Close();

            string sql0 = "SELECT * FROM สมัครสมาชิกสมาคม";
            MySqlCommand cmd0 = new MySqlCommand(sql0, conn);
            conn.Open();
            DataTable dt0 = new DataTable();
            new MySqlDataAdapter(cmd0).Fill(dt0);
            MySqlDataReader xxx0 = cmd0.ExecuteReader();

            while (xxx0.Read())
            {
                comboBox6.Items.Add($"{xxx0.GetString(0)}");
            }
            conn.Close();

            string sql01 = "SELECT * FROM สมัครสมาชิกสมาคม";
            MySqlCommand cmd01 = new MySqlCommand(sql01, conn);
            conn.Open();
            DataTable dt01 = new DataTable();
            new MySqlDataAdapter(cmd01).Fill(dt01);
            MySqlDataReader xxx01 = cmd01.ExecuteReader();

            while (xxx01.Read())
            {
                comboBox7.Items.Add($"{xxx01.GetString(3)}");
            }
            conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM ลูกผสม WHERE เลขโค like '" + comboBox2.Text + "' ";
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn);
            conn.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx = cmd4.ExecuteReader();

            while (xxxx.Read())
            {
                textBox1.Text = xxxx.GetString(0);
                textBox2.Text = xxxx.GetString(1);
                comboBox1.Text = xxxx.GetString(2);
                textBox5.Text = xxxx.GetString(3);
                comboBox5.Text = xxxx.GetString(4);
                textBox3.Text = xxxx.GetString(5);
                comboBox6.Text = xxxx.GetString(6);
                comboBox7.Text = xxxx.GetString(7);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Trim() == "" || textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || comboBox1.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox5.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox6.Text.Trim() == "" || comboBox7.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกให้ครบ");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
                string sql6 = $"SELECT * FROM ลูกผสม WHERE เลขโค = '{textBox2.Text}'";
                var cmd6 = new MySqlCommand(sql6, conn);
                DataTable dt6 = new DataTable();
                new MySqlDataAdapter(cmd6).Fill(dt6);
                if (dt6.Rows.Count < 2)
                {
                    String sql = "UPDATE ลูกผสม SET ชื่อโค = '" + textBox1.Text + "',เลขโค = '" + textBox2.Text + "',ชื่อพ่อโค = '" + comboBox1.Text + "',ชื่อแม่โค = '" + textBox5.Text + "',เลขพ่อโค = '" + comboBox5.Text + "',เลขแม่โค = '" + textBox3.Text + "',ชื่อเจ้าของ = '" + comboBox6.Text + "',ชื่อฟาร์ม = '" + comboBox7.Text + "' WHERE เลขโค = '" + textBox2.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                        Form28 form28 = new Form28();
                        form28.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("ข้อมูลซ้ำ");
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM เลือดร้อยตัวผู้ WHERE เลขโค100ตัวผู้ like '" + comboBox5.Text + "' ";
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn);
            conn.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx3 = cmd4.ExecuteReader();

            while (xxxx3.Read())
            {
                comboBox1.Text = xxxx3.GetString(0);
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM เลือดร้อยตัวผู้ WHERE ชื่อโค100ตัวผู้ like '" + comboBox1.Text + "' ";
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd4 = new MySqlCommand(sql2, conn);
            conn.Open();
            DataTable dt4 = new DataTable();
            new MySqlDataAdapter(cmd4).Fill(dt4);
            MySqlDataReader xxxx3 = cmd4.ExecuteReader();

            while (xxxx3.Read())
            {
                comboBox5.Text = xxxx3.GetString(1);
            }
            conn.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql0 = "SELECT * FROM สมัครสมาชิกสมาคม WHERE ชื่อ = '" + comboBox6.Text + "' ";
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd0 = new MySqlCommand(sql0, conn);
            conn.Open();
            DataTable dt0 = new DataTable();
            new MySqlDataAdapter(cmd0).Fill(dt0);
            MySqlDataReader xxxx0 = cmd0.ExecuteReader();

            while (xxxx0.Read())
            {
                comboBox7.Text = xxxx0.GetString(3);
            }
            conn.Close();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql01 = "SELECT * FROM สมัครสมาชิกสมาคม WHERE ชื่อฟาร์ม = '" + comboBox7.Text + "' ";
            MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=สมาคมฟาร์มโค");
            MySqlCommand cmd01 = new MySqlCommand(sql01, conn);
            conn.Open();
            DataTable dt01 = new DataTable();
            new MySqlDataAdapter(cmd01).Fill(dt01);
            MySqlDataReader xxxx01 = cmd01.ExecuteReader();

            while (xxxx01.Read())
            {
                comboBox6.Text = xxxx01.GetString(0);
            }
            conn.Close();
        }
    }
}
