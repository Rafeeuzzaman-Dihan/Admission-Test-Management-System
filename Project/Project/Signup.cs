using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Signup : Form
    {
        string Gender;
        public Signup()
        {
            InitializeComponent();
        }
        private void Signup_Load(object sender, EventArgs e)
        {

        }
        private void transparent_box_Paint(object sender, PaintEventArgs e)
        {
            transparent_box.BackColor = Color.FromArgb(30, Color.White);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(30, Color.White);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == null && textBox2.Text == null && textBox3.Text == null && textBox4.Text == null && textBox5.Text == null && textBox6.Text == null && textBox7.Text == null && radioButton1.Checked == false && radioButton2.Checked == false  )
            {
                MessageBox.Show("FIELDS CAN'T BE EMPTY");
            }

            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into LOGIN_TBL values (@FIRST_NAME, @LAST_NAME, @USERNAME, @EMAIL, @GENDER, @DOB, @INSTITUTION, @PASSWORD)", con);
                cmd.Parameters.AddWithValue("@FIRST_NAME", (textBox1.Text));
                cmd.Parameters.AddWithValue("@LAST_NAME", (textBox2.Text));
                cmd.Parameters.AddWithValue("@USERNAME", (textBox3.Text));
                cmd.Parameters.AddWithValue("@EMAIL", (textBox4.Text));
                cmd.Parameters.AddWithValue("@GENDER", (Gender));
                cmd.Parameters.AddWithValue("@DOB", (Datepicker.Value.ToString()));
                cmd.Parameters.AddWithValue("@INSTITUTION", (textBox5.Text));
                cmd.Parameters.AddWithValue("@PASSWORD", (textBox6.Text));

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Your account is successfully created");

                Login li = new Login();
                li.Show();
                this.Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {

        }

    }
}
