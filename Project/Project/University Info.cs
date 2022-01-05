using System;
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
    public partial class University_Info : Form
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30";
        public University_Info()
        {
            InitializeComponent();
        }

        private void transparent_box_Paint(object sender, PaintEventArgs e)
        {
            transparent_box.BackColor = Color.FromArgb(30, Color.White);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Fields can't be empty");
            }

            else if (comboBox1.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox1, "Please select a university");
            }

            else if (comboBox2.SelectedItem == null)
            {
                errorProvider2.SetError(comboBox2, "Please select a unit");
            }

            //DHAKA UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM DU_A", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM DU_B", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM DU_C", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM DU_D", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }


            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM CU_A", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM CU_B", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM CU_C", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM CU_D", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }


            //Rajshahi University


            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM RU_A", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM RU_B", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM RU_C", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                MessageBox.Show("Please select a proper unit");
            }



            //Jahangirnagar University

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM JU_A", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM JU_B", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM JU_C", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                using (SqlConnection Con = new SqlConnection(ConnectionString))
                {
                    Con.Open();
                    SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM JU_D", Con);
                    DataTable dtbl = new DataTable();
                    Da.Fill(dtbl);

                    Data_Grid.DataSource = dtbl;
                }
            }
        }

        private void Data_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Selection sl = new Selection();
            sl.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(30, Color.White);
        }

        private void University_Info_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Contact co = new Contact();
            co.Show();
            this.Hide();
        }

        private void Data_Grid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
