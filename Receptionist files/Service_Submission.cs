using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repair_Heads_compiled_program
{
    public partial class Service_Submission : Form
    {
        private string loggedUserID;
        private string selectedCustomer;
        private string selectedService;
        private string selectedUrgency;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Service_Submission()
        {
            InitializeComponent();
        }

        public Service_Submission(string u)
        {
            InitializeComponent();
            loggedUserID = u;
        }

        private void Service_Submission_Load(object sender, EventArgs e)
        {
            ArrayList CustomerUserID = new ArrayList();

            rec_Customer obj1 = new rec_Customer();
            CustomerUserID = obj1.viewAllCustomerID();
            foreach (var item in CustomerUserID)
                cmbUserID.Items.Add(item);
            cmbService.SelectedIndex = 0;
            selectedUrgency = "normal";
            lblFee.Text = "Estimated fee = RM" + rec_Service.serviceFee(selectedService, selectedUrgency);
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            User obj1 = new User(cmbUserID.SelectedItem.ToString());
            string name = obj1.readInfo("Name");
            string email = obj1.readInfo("Email");
            string phone = obj1.readInfo("Phone");
            string Address = obj1.readInfo("Address");

            lblCustomerDetails.Text = "Name :" + name + "\nEmail : " + email + "\nPhone : " + phone + "\nAddress :\n" + Address;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string urgency = "normal";
            if (rbNormal.Checked)
                urgency = "normal";
            else if (rbUrgent.Checked)
                urgency = "urgent";
            rec_Service obj2 = new rec_Service(cmbUserID.SelectedItem.ToString(), selectedService, urgency);
            MessageBox.Show(obj2.submitService());
            this.Hide();
            Receptionist_Menu obj = new Receptionist_Menu(loggedUserID);
            obj.ShowDialog();
            this.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptionist_Menu obj = new Receptionist_Menu(loggedUserID);
            obj.ShowDialog();
            this.Close();
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedService = cmbService.SelectedItem.ToString();
            lblFee.Text = "Estimated fee = RM" + rec_Service.serviceFee(selectedService, selectedUrgency);
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked)
                selectedUrgency = "normal";
            lblFee.Text = "Estimated fee = RM" + rec_Service.serviceFee(selectedService, selectedUrgency);
        }

        private void rbUrgent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUrgent.Checked)
                selectedUrgency = "urgent";
            lblFee.Text = "Estimated fee = RM" + rec_Service.serviceFee(selectedService, selectedUrgency);
        }
    }
}
