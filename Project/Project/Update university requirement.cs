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
    public partial class Update_university_recruitments : Form
    {
        public Update_university_recruitments()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_university_recruitments_Load(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        //SHOWING DATA


        private void bunifuFlatButton7_Click(object sender, EventArgs e)
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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU_A", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU_B", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU_C", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU_D", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }


            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU_A", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU_B", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU_C", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU_D", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }


            //Jahangirnagar University


            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU_A", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU_B", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU_C", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU_D", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }


            //Rajshahi University


            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from RU_A", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from RU_B", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from RU_C", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                MessageBox.Show("Please select a proper unit");
            }
        }


        //UPDATING DATA


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update DU_A set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update DU_B set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update DU_C set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update DU_D set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update CU_A set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update CU_B set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update CU_C set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update CU_D set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            //JAHANGIRNAGAR UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update JU_A set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update JU_B set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update JU_C set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update JU_D set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            //RAJSHAHI UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update RU_A set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update RU_B set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\University InfoDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update RU_C set SSC=@SSC, HSC=@HSC, TOTAL=@TOTAL", con);
                cmd.Parameters.AddWithValue("@SSC", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HSC", (textBox2.Text));
                cmd.Parameters.AddWithValue("@TOTAL", (textBox3.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                MessageBox.Show("Please select a proper unit");
            }
        }

        private void Data_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void transparent_box_Paint(object sender, PaintEventArgs e)
        {
            transparent_box.BackColor = Color.FromArgb(30, Color.White);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(30, Color.White);
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

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Contact co = new Contact();
            co.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Admin_dashboard ad = new Admin_dashboard();
            ad.Show();
            this.Hide();
        }
    }
}
