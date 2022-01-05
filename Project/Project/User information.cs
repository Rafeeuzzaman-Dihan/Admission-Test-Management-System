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
    public partial class User_information : Form
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        public User_information()
        {
            InitializeComponent();
        }

        private void User_information_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                Con.Open();
                SqlDataAdapter Da = new SqlDataAdapter("SELECT * FROM LOGIN_TBL", Con);
                DataTable dtbl = new DataTable();
                Da.Fill(dtbl);

                Data_Grid.DataSource = dtbl;
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
    }
}
