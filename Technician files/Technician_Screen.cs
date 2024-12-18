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
using System.Configuration;

namespace Repair_Heads_compiled_program
{
    public partial class frmTechMenu : Form
    {
        string loggedUserID = "";
        SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        public frmTechMenu()
        {
            InitializeComponent();
        }

            public frmTechMenu(string u)
        {
            InitializeComponent();
            loggedUserID = u;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // Retrieving user details from database

            conn1.Open();
            lblUserID.Text = loggedUserID;
            SqlCommand cmd = new SqlCommand("select Name from User_Info where UserID ='" + loggedUserID + "'", conn1);
            lblFullName.Text = cmd.ExecuteScalar().ToString();
            SqlCommand cmd2 = new SqlCommand("select Email from User_Info where UserID ='" + loggedUserID + "'", conn1);
            lblEmail.Text = cmd2.ExecuteScalar().ToString();
            conn1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            // this opens the requested services page

            this.Hide();
            frmRequestedServices obj2 = new frmRequestedServices(loggedUserID);
            obj2.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // this opens the Edit profile page

            this.Hide();
            Edit_Profile obj = new Edit_Profile(loggedUserID);
            obj.ShowDialog();
            this.Close();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Hide();
                Login obj3 = new Login();
                obj3.ShowDialog();
                this.Close();
               
            }
        }
    }
}