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
    public partial class User_Informatiom : Form
    {
        public User_Informatiom()
        {
            InitializeComponent();
        }


        private void Data_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Project\Project\Database\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from LOGIN_TBL", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Data_Grid.AutoGenerateColumns = false;
            Data_Grid.ColumnCount = 7;
            Data_Grid.Columns[0].HeaderText = "First Name";
            Data_Grid.Columns[0].DataPropertyName = "FIRST_NAME";
            Data_Grid.Columns[1].HeaderText = "Last Name";
            Data_Grid.Columns[1].DataPropertyName = "LAST_NAME";
            Data_Grid.Columns[2].HeaderText = "Username";
            Data_Grid.Columns[2].DataPropertyName = "USERNAME";
            Data_Grid.Columns[3].HeaderText = "Email";
            Data_Grid.Columns[3].DataPropertyName = "EMAIL";
            Data_Grid.Columns[4].HeaderText = "Gender";
            Data_Grid.Columns[4].DataPropertyName = "GENDER";
            Data_Grid.Columns[5].HeaderText = "Date of birth";
            Data_Grid.Columns[5].DataPropertyName = "DOB";
            Data_Grid.Columns[6].HeaderText = "Institute";
            Data_Grid.Columns[6].DataPropertyName = "INSTITUTION";


            Data_Grid.DataSource = dt;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Admin_dashboard ad = new Admin_dashboard();
            ad.Show();
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

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Contact co = new Contact();
            co.Show();
            this.Hide();
        }
    }
}
