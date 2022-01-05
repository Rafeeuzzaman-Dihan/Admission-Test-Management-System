using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Set_Reminder : Form
    {
        public Set_Reminder()
        {
            InitializeComponent();
        }

        private void transparent_box_Paint(object sender, PaintEventArgs e)
        {
            transparent_box.BackColor = Color.FromArgb(30, Color.White);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Fields can't be empty");
            }
            else if (comboBox1.SelectedItem.ToString() == "Dhaka University")
            {
                MessageBox.Show("You will be notified before 24 hour of the exam");
            }
            else if (comboBox1.SelectedItem.ToString() == "Chittagong University")
            {
                MessageBox.Show("You will be notified before 24 hour of the exam");
            }
            else if (comboBox1.SelectedItem.ToString() == "Jahangirnogor University")
            {
                MessageBox.Show("You will be notified before 24 hour of the exam");
            }
            else if (comboBox1.SelectedItem.ToString() == "Rajshahi University")
            {
                MessageBox.Show("You will be notified before 24 hour of the exam");
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Selection sl = new Selection();
            sl.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(30, Color.White);
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Contact co = new Contact();
            co.Show();
            this.Hide();
        }

        private void Set_Reminder_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            End_Page ep = new End_Page();
            ep.Show();
            this.Hide();
        }
    }
}
