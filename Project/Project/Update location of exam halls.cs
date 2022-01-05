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
    public partial class Update_location_of_exam_halls : Form
    {
        public Update_location_of_exam_halls()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU_A", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }
            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU_B", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU_C", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU_A", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU_B", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU_C", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU_A", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU_B", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU_C", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from RU_A", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from RU_B", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
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
            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null && textBox1.Text == null && textBox3.Text == null && textBox2.Text == null)
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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update DU_A set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update DU_B set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update DU_C set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update DU_D set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update CU_A set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update CU_B set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update CU_C set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update CU_D set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            //JAHANGIRNAGAR UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update JU_A set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update JU_B set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update JU_C set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update JU_D set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            //RAJSHAHI UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update RU_A set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update RU_B set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update RU_C set ROOM_NUMBER = @ROOM_NUMBER, HALL_NAME = @HALL_NAME where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                MessageBox.Show("Please select a proper a unit");
            }
        }



        //ADDING DATA

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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into DU_A values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into DU_B values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into DU_C values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into DU_D values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into CU_A values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into CU_B values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into CU_C values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into CU_D values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            //JAHANGIRNAGAR UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into JU_A values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into JU_B values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into JU_C values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into JU_D values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            //RAJSHAHI UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into RU_A values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into RU_B values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into RU_C values (@ROLL_NUMBER, @HALL_NAME, @ROOM_NUMBER)", con);
                cmd.Parameters.AddWithValue("@ROLL_NUMBER", (textBox1.Text));
                cmd.Parameters.AddWithValue("@HALL_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@ROOM_NUMBER", (textBox2.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                MessageBox.Show("Please select a proper unit");
            }
        }



        //DELETING DATA

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete DU_A where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete DU_B where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete DU_C where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete DU_D where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete CU_A where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete CU_B where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete CU_C where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete CU_D where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            //JAHANGIRNAGAR UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete JU_A where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete JU_B where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete JU_C where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete JU_D where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            //RAJSHAHI UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete RU_A where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete RU_B where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete RU_C where ROLL_NUMBER = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                MessageBox.Show("Please select a proper unit");
            }
        }



        //SEARCHING DATA

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU_A where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU_B where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU_C where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU_D where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU_A where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU_B where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU_C where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU_D where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            //JAHANGIRNAGAR UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU_A where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU_B where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU_C where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University" && comboBox2.SelectedItem.ToString() == "D Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU_D where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            //RAJSHAHI UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "A Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from RU_A where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "B Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from RU_B where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University" && comboBox2.SelectedItem.ToString() == "C Unit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LocationsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from RU_C where ROLL_NUMBER = @ROLL_NUMBER", con);
                cmd.Parameters.AddWithValue("ROLL_NUMBER", (textBox1.Text));
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

        private void transparent_box_Paint(object sender, PaintEventArgs e)
        {
            transparent_box.BackColor = Color.FromArgb(30, Color.White);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(30, Color.White);
        }

        private void Update_location_of_exam_halls_Load(object sender, EventArgs e)
        {

        }
    }
}
