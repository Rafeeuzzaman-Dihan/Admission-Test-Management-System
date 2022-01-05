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
    public partial class Update_clash_exams : Form
    {
        public Update_clash_exams()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
        //SHOWING DATA

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null && textBox3.Text == null && textBox4.Text == null)
            {
                MessageBox.Show("Fields can't be empty");
            }


            else 
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\Clash ExamsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CLASH_EXAMS", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;
            }
        }


        //UPDATING DATA

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null && textBox3.Text == null && textBox4.Text == null)
            {
                MessageBox.Show("Fields can't be empty");
            }


            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\Clash ExamsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update CLASH_EXAMS set EXAM_DATE = @EXAM_DATE, UNIVERSITY_NAME = @UNIVERSITY_NAME, UNIT = @UNIT where SLN = @SLN", con);
                cmd.Parameters.AddWithValue("@EXAM_DATE", (textBox2.Text));
                cmd.Parameters.AddWithValue("@UNIVERSITY_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@UNIT", (textBox4.Text));
                cmd.Parameters.AddWithValue("@SLN", (textBox1.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Updated Succesfully");

            }
        }


        //ADDING DATA

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null && textBox3.Text == null && textBox4.Text == null)
            {
                MessageBox.Show("Fields can't be empty");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\Clash ExamsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into CLASH_EXAMS values (@SLN, @EXAM_DATE, @UNIVERSITY_NAME, @UNIT)", con);
                cmd.Parameters.AddWithValue("@SLN", (textBox1.Text));
                cmd.Parameters.AddWithValue("@EXAM_DATE", (textBox2.Text));
                cmd.Parameters.AddWithValue("@UNIVERSITY_NAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@UNIT", (textBox4.Text));
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Added Succesfully");
            }
        }


        //DELETING_DATA

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null && textBox3.Text == null && textBox4.Text == null)
            {
                MessageBox.Show("Fields can't be empty");
            }

            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\Clash ExamsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand(("Delete CLASH_EXAMS where SLN = '" + this.textBox1.Text + "' "), con);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Deleted Succesfully");
            }
        }



        //SEARCHING_DATA

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null && textBox3.Text == null && textBox4.Text == null)
            {
                MessageBox.Show("Fields can't be empty");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\Clash ExamsDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CLASH_EXAMS where EXAM_DATE = @EXAM_DATE", con);
                cmd.Parameters.AddWithValue("EXAM_DATE", (textBox2.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_Grid.DataSource = dt;

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

        private void Update_clash_exams_Load(object sender, EventArgs e)
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
    }
}
