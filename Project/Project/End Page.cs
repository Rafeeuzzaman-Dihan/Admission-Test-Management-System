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
    public partial class End_Page : Form
    {
        public End_Page()
        {
            InitializeComponent();
        }

        private void transparent_box_Paint(object sender, PaintEventArgs e)
        {
            transparent_box.BackColor = Color.FromArgb(30, Color.White);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
               {
                    MessageBox.Show("Please write something about this application");
               }
            else 
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\FeedbackDB.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into FEEDBACK values (@FEEDBACK)", con);
                    cmd.Parameters.AddWithValue("FEEDBACK", (textBox1.Text));
               
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Your feedback has been submitted. Thank You");
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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

        private void End_Page_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(30, Color.White);
        }
    }
}
