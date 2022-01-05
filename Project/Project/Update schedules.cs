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
    public partial class Update_schedules : Form
    {
        public Update_schedules()
        {
            InitializeComponent();
        }

        private void Update_schedules_Load(object sender, EventArgs e)
        {
            transparent_box.BackColor = Color.FromArgb(30, Color.White);
        }

        //SHOWING DATA

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a University");
            }


            //DHAKA UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            //JAHANGIRNAGAR UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }

            //RAJSHAHI UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from RU", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }



        }


        //UPDATING DATA


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Select a University");
            }

            //DHAKA UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update DU set EXAM_DATE = @EXAM_DATE, EXAM_DAY = @EXAM_DAY, EXAM_TIME = @EXAM_TIME where UNIT = @UNIT", con);
                cmd.Parameters.AddWithValue("@EXAM_DATE", (textBox2.Text));
                cmd.Parameters.AddWithValue("@EXAM_DAY", (textBox3.Text));
                cmd.Parameters.AddWithValue("@EXAM_TIME", (textBox4.Text));
                cmd.Parameters.AddWithValue("@UNIT", (textBox1.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");

            }

            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update CU set EXAM_DATE = @EXAM_DATE, EXAM_DAY = @EXAM_DAY, EXAM_TIME = @EXAM_TIME where UNIT = @UNIT", con);
                cmd.Parameters.AddWithValue("@EXAM_DATE", (textBox2.Text));
                cmd.Parameters.AddWithValue("@EXAM_DAY", (textBox3.Text));
                cmd.Parameters.AddWithValue("@EXAM_TIME", (textBox4.Text));
                cmd.Parameters.AddWithValue("@UNIT", (textBox1.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");

            }

            //JAHANGIRNAGAR UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update JU set EXAM_DATE = @EXAM_DATE, EXAM_DAY = @EXAM_DAY, EXAM_TIME = @EXAM_TIME where UNIT = @UNIT", con);
                cmd.Parameters.AddWithValue("@EXAM_DATE", (textBox2.Text));
                cmd.Parameters.AddWithValue("@EXAM_DAY", (textBox3.Text));
                cmd.Parameters.AddWithValue("@EXAM_TIME", (textBox4.Text));
                cmd.Parameters.AddWithValue("@UNIT", (textBox1.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");

            }

            //RAJSHAHI UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update RU set EXAM_DATE = @EXAM_DATE, EXAM_DAY = @EXAM_DAY, EXAM_TIME = @EXAM_TIME where UNIT = @UNIT", con);
                cmd.Parameters.AddWithValue("@EXAM_DATE", (textBox2.Text));
                cmd.Parameters.AddWithValue("@EXAM_DAY", (textBox3.Text));
                cmd.Parameters.AddWithValue("@EXAM_TIME", (textBox4.Text));
                cmd.Parameters.AddWithValue("@UNIT", (textBox1.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");

            }
        }

        //ADDING DATA

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Fields can't be empty");
            }

            //DHAKA UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into DU values (@UNIT, @EXAM_DATE, @EXAM_DAY, @EXAM_TIME)", con);
                cmd.Parameters.AddWithValue("@UNIT", (textBox1.Text));
                cmd.Parameters.AddWithValue("@EXAM_DATE", (textBox2.Text));
                cmd.Parameters.AddWithValue("@EXAM_DAY", (textBox3.Text));
                cmd.Parameters.AddWithValue("@EXAM_TIME", (textBox4.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into CU values (@UNIT, @EXAM_DATE, @EXAM_DAY, @EXAM_TIME)", con);
                cmd.Parameters.AddWithValue("@UNIT", (textBox1.Text));
                cmd.Parameters.AddWithValue("@EXAM_DATE", (textBox2.Text));
                cmd.Parameters.AddWithValue("@EXAM_DAY", (textBox3.Text));
                cmd.Parameters.AddWithValue("@EXAM_TIME", (textBox4.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            //JAHANGIRNAGAR UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into JU values (@UNIT, @EXAM_DATE, @EXAM_DAY, @EXAM_TIME)", con);
                cmd.Parameters.AddWithValue("@UNIT", (textBox1.Text));
                cmd.Parameters.AddWithValue("@EXAM_DATE", (textBox2.Text));
                cmd.Parameters.AddWithValue("@EXAM_DAY", (textBox3.Text));
                cmd.Parameters.AddWithValue("@EXAM_TIME", (textBox4.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }

            //RAJSHAHI UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into RU values (@UNIT, @EXAM_DATE, @EXAM_DAY, @EXAM_TIME)", con);
                cmd.Parameters.AddWithValue("@UNIT", (textBox1.Text));
                cmd.Parameters.AddWithValue("@EXAM_DATE", (textBox2.Text));
                cmd.Parameters.AddWithValue("@EXAM_DAY", (textBox3.Text));
                cmd.Parameters.AddWithValue("@EXAM_TIME", (textBox4.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }
        }

        //DELETING DATA

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Fields can't be empty");
            }

            //DHAKA UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete DU where UNIT = '"+this.textBox1.Text+"' "), con);
           
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete CU where UNIT = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            //JAHANGIRNAGAR UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete JU where UNIT = '" + this.textBox1.Text + "' "), con);
                
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }

            //RAJSHAHI UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete RU where UNIT = '" + this.textBox1.Text + "' "), con);
                
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }
        }


        //SEARCHING DATA

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Fields can't be empty");
            }

            //DHAKA UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Dhaka University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from DU where UNIT = @UNIT", con);
                cmd.Parameters.AddWithValue("UNIT", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
                
            }

            //CHITTAGONG UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Chittagong University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CU where UNIT = @UNIT", con);
                cmd.Parameters.AddWithValue("UNIT", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            //JAHANGIRNAGAR UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Jahangirnagar University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from JU where UNIT = @UNIT", con);
                cmd.Parameters.AddWithValue("UNIT", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }

            //RAJSHAHI UNIVERSITY

            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University")
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Desktop\Project\Project\Database\SchedulesDB.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from RU where UNIT = @UNIT", con);
                cmd.Parameters.AddWithValue("UNIT", (textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(30, Color.White);
        }

        private void transparent_box_Paint(object sender, PaintEventArgs e)
        {
            transparent_box.BackColor = Color.FromArgb(30, Color.White);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
