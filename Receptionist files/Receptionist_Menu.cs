using System.Configuration;
using System.Data.SqlClient;

namespace Repair_Heads_compiled_program
{
    public partial class Receptionist_Menu : Form
    {
        private string loggedUserID;

        public Receptionist_Menu()
        {
            InitializeComponent();
        }

        public Receptionist_Menu(string u)
        {
            InitializeComponent();
            loggedUserID = u;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Receive_Payment obj1 = new Receive_Payment();
            obj1.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register_customer obj1 = new Register_customer();
            obj1.ShowDialog();
        }

        private void btnRequestService_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service_Submission obj = new Service_Submission(loggedUserID);
            obj.ShowDialog();
            this.Close();
        }

        private void Receptionist_Menu_Load(object sender, EventArgs e)
        {
            lblUserID.Text = loggedUserID;
            User obj1 = new User(loggedUserID);
            lblFullName.Text = obj1.readInfo("Name");
            lblEmail.Text = obj1.readInfo("Email");
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("proceed to logout?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Login obj = new Login();
                obj.ShowDialog();
                this.Close();
            }
        }

        private void lblEditProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Edit_Profile obj = new Edit_Profile(loggedUserID);
            obj.ShowDialog();
            this.Close();
        }

        private void btnRegisterNewCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_customer obj = new Register_customer(loggedUserID);
            obj.ShowDialog();
            this.Close();
        }

        private void btnReceivePayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receive_Payment obj = new Receive_Payment(loggedUserID);
            obj.ShowDialog();
            this.Close();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }
    }
}