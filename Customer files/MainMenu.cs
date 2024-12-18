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
    public partial class MainMenu : Form
    {
        private string userID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(string n)
        {
            InitializeComponent();
            userID = n;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //userID = "cus001";
            
            Customers obj1 = new Customers(userID);

            Customers.ShowCustInfo(obj1);

            lblName.Text = obj1.Name;
            lblUserID.Text = userID;
            lblDoB.Text = obj1.DoB;
            lblEmail.Text = obj1.Email;
            lblPhone.Text = obj1.PhoneNum;
            lblAddress.Text = obj1.Address;

            cusRS obj2 = new cusRS(userID);
            ArrayList ServiceID = obj2.viewAllCusRS();

            foreach (var item in ServiceID)
                cmbServiceID.Items.Add(item.ToString());

            cmbServiceID.SelectedIndex = 0;

            cusRS obj = new cusRS(userID);
            obj.showSelectedService(cmbServiceID.SelectedItem.ToString());

            lblServiceType.Text = obj.ServiceType;
            lblUrgency.Text = obj.Urgency;
            lblDescription.Text = obj.Description;
            lblStatus.Text = obj.ServiceStatus;
            lblCollectionDate.Text = obj.CollectionDate;
            lblFee.Text = obj.EstimatedFee.ToString();


            /*cusRS obj2 = new cusRS(userID);
            cusRS.ShowRS(obj2);

            lblServiceType.Text = obj2.ServiceType;
            lblUrgency.Text = obj2.Urgency;
            lblDescription.Text = obj2.Description;
            lblStatus.Text = obj2.ServiceStatus;

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select CollectionDate from Requested_service where UserID='" + userID + "'", con);
            lblCollectionDate.Text = cmd1.ExecuteScalar().ToString();
            SqlCommand cmd2 = new SqlCommand("select EstimatedFee from Requested_service where UserID='" + userID + "'", con);
            lblFee.Text = cmd2.ExecuteScalar().ToString();/*




            /*SqlCommand cmd4 = new SqlCommand("select ServiceType from Requested_service where UserID='" + userID + "'", con);
            lblServiceType.Text = cmd4.ExecuteScalar().ToString();
            SqlCommand cmd5 = new SqlCommand("select Description from Requested_service where UserID='" + userID + "'", con);
            lblDescription.Text = cmd5.ExecuteScalar().ToString();
            SqlCommand cmd6 = new SqlCommand("select Urgency from Requested_service where UserID='" + userID + "'", con);
            lblUrgency.Text = cmd6.ExecuteScalar().ToString();
            SqlCommand cmd7 = new SqlCommand("select ServiceStatus from Requested_service where UserID='" + userID + "'", con);
            lblStatus.Text = cmd7.ExecuteScalar().ToString();
            
            SqlCommand cmd9 = new SqlCommand("select EstimatedFee from Requested_service where UserID='" + userID + "'", con);
            lblFee.Text = cmd9.ExecuteScalar().ToString();*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfile ep = new EditProfile(userID);
            ep.ShowDialog();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRS crs = new CRS(userID, cmbServiceID.SelectedItem.ToString());
            crs.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblUrgency_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblDoB_Click(object sender, EventArgs e)
        {

        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }

        private void cmbServiceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cusRS obj = new cusRS(userID);
            obj.showSelectedService(cmbServiceID.SelectedItem.ToString());

            lblServiceType.Text = obj.ServiceType;
            lblUrgency.Text = obj.Urgency;
            lblDescription.Text = obj.Description;
            lblStatus.Text = obj.ServiceStatus;
            lblCollectionDate.Text = obj.CollectionDate;
            lblFee.Text = obj.EstimatedFee.ToString();
        }
    }
}
