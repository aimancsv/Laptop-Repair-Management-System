using System.Configuration;
using System.Data.SqlClient;

namespace Repair_Heads_compiled_program
{
    public partial class Admin_Screen : Form
    {
        private string loggedUserID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Admin_Screen()
        {
            InitializeComponent();
        }

        public Admin_Screen(string u)
        {
            InitializeComponent();
            loggedUserID = u;
        }       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Registertion_Form obj = new Registertion_Form(loggedUserID);
                obj.ShowDialog();
                this.Close();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.ShowDialog();
            this.Close();
        }

        private void btnServiseReport_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Monthly_Report obj = new Monthly_Report(loggedUserID);
                obj.ShowDialog();
                this.Close();
            }

        }
    }
}