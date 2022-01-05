﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Schedules : Form
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Schedules()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Selection sl = new Selection();
            sl.Show();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            About_us au = new About_us();
            au.Show();
            this.Hide();
        }

        private void transparent_box_Paint(object sender, PaintEventArgs e)
        {
            transparent_box.BackColor = Color.FromArgb(30, Color.White);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(30, Color.White);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a university");
            }

            //DHAKA UNIVERSITY
            else if (comboBox1.SelectedItem.ToString() == "Dhaka University")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM DU", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }


            //CHITTAGONG UNIVERSITY
            else if (comboBox1.SelectedItem.ToString() == "Chittagong University")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM CU", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }


            //RAJSHAHI UNIVERSITY
            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM RU", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }


            //JAHANGIRNAGAR UNIVERSITY
            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM JU", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Set_Reminder sr = new Set_Reminder();
            sr.Show();
            this.Hide();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Contact co = new Contact();
            co.Show();
            this.Hide();
        }
    }
}
