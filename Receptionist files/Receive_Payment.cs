using System;
using System.Collections;
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
    public partial class Receive_Payment : Form
    {
        private string loggedUserID;
        public Receive_Payment()
        {
            InitializeComponent();
        }

        public Receive_Payment(string u)
        {
            InitializeComponent();
            loggedUserID = u;
        }

        private void Receive_Payment_Load(object sender, EventArgs e)
        {
            ArrayList ServiceID = new ArrayList();

            rec_Service obj1 = new rec_Service();
            ServiceID = obj1.viewAllServiceID();
            foreach (var item in ServiceID)
                cmbServiceID.Items.Add(item);
            btnAccept.Enabled = false;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptionist_Menu obj = new Receptionist_Menu(loggedUserID);
            obj.ShowDialog();
            this.Close();
        }

        private void cmbServiceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            rec_Service obj1 = new rec_Service(cmbServiceID.SelectedItem.ToString());
            string CustomerID = obj1.findCustomerIDRelated();
            string name = obj1.viewCustomerDetail("Name");
            string email = obj1.viewCustomerDetail("Email");
            string phone = obj1.viewCustomerDetail("Phone");
            string Address = obj1.viewCustomerDetail("Address");

            lblCustomerDetails.Text = "UserID : " + CustomerID+ "\nName :" + name + "\nEmail : " + email + "\nPhone : " + phone + "\nAddress :\n" + Address;

            string ServiceType = obj1.viewServiceDetail("ServiceType");
            string Description = obj1.viewServiceDetail("Description");
            string SubmittedDate = obj1.viewServiceDetail("SubmittedDate");
            string fees = obj1.viewServiceDetail("EstimatedFee");

            lblOrderDetails.Text = "Service type:\n" + ServiceType + "\n\nDescription:\n" + Description + "\n\nService submitted date:\n" + SubmittedDate + "\n\nTotal fees: RM" + fees;

            string payment = obj1.viewServiceDetail("Payment");
            if (payment == "paid")
            {
                btnAccept.Text = "paid";
                btnAccept.BackColor = Color.OrangeRed;
                btnAccept.Enabled = false;
            }
            else if (payment == "unpaid")
            {
                btnAccept.Text = "Accept Payment";
                btnAccept.BackColor= Color.LightGreen;
                btnAccept.Enabled = true;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            rec_Service obj1 = new rec_Service(cmbServiceID.SelectedItem.ToString());

            MessageBox.Show(obj1.receivePayment());
            this.Hide();
            Receptionist_Menu obj = new Receptionist_Menu(loggedUserID);
            obj.ShowDialog();
            this.Close();
        }
    }
}
