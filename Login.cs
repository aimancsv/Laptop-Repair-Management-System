using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repair_Heads_compiled_program
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User obj1 = new User(txtUserID.Text, txtPassword.Text);
            string loggedUserID = obj1.Login();
            if (loggedUserID != "")
            {
                if (loggedUserID.Contains("rec"))
                {
                    this.Hide();
                    Receptionist_Menu obj = new Receptionist_Menu(loggedUserID);
                    obj.ShowDialog();
                    this.Close();
                }
                else if (loggedUserID.Contains("cus"))
                {
                    this.Hide();
                    MainMenu obj = new MainMenu(loggedUserID);
                    obj.ShowDialog();
                    this.Close();
                }
                else if (loggedUserID.Contains("tec"))
                {
                    this.Hide();
                    frmTechMenu obj = new frmTechMenu(loggedUserID);
                    obj.ShowDialog();
                    this.Close();
                }
                else if (loggedUserID.Contains("adm"))
                {
                    this.Hide();
                    Admin_Screen obj = new Admin_Screen(loggedUserID);
                    obj.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("incorrect username/password");
                txtUserID.Clear();
                txtPassword.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
