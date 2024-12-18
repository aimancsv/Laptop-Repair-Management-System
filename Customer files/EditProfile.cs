using System;
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
    public partial class EditProfile : Form
    {
        private string userID = "";
        private string newDoB = "";
        private string currentDoB = "";
        private string todayDate = "";
        private string newEmail = "";
        private string newPassword = "";
        private string newPhone = "";
        private string newAddress = "";

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public EditProfile()
        {
            InitializeComponent();
        }

        public EditProfile(string un)
        {
            InitializeComponent();
            userID = un;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            Customers obj1 = new Customers(userID);

            Customers.ShowCustInfo(obj1);

            lblName.Text = obj1.Name;
            lblDoB.Text = obj1.DoB;
            txtEmail.Text = obj1.Email;
            txtPhone.Text = obj1.PhoneNum;
            //txtPassword.Text = obj1.Password;
            txtAddress.Text = obj1.Address;

            todayDate = DateTime.Today.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Customers obj1 = new Customers(userID);

            if (txtEmail.Text.Length > 0 && txtPassword.Text.Length > 0 && txtPhone.Text.Length > 0 && txtAddress.Text.Length > 0)
                MessageBox.Show(obj1.custEditProfileAll(newDoB, txtEmail.Text, txtPassword.Text, txtPhone.Text, txtAddress.Text));
            else
                MessageBox.Show("You have to fill all the blanks (New Day of birth, email, passwords, phone number, and address.");
            
        }

        private void dtpBDoB_ValueChanged(object sender, EventArgs e)
        {
            newDoB = dtpDoB.Text;
        }

        private void btnDoB_Click(object sender, EventArgs e)
        {
            Customers obj1 = new Customers(userID);

            if (currentDoB != newDoB && newDoB != todayDate)
                MessageBox.Show(obj1.custEditProfileDoB(newDoB));
            else
                MessageBox.Show("You have to choose the new date of your birth");
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            Customers obj1 = new Customers(userID);

            newEmail = txtEmail.Text;
            if (txtEmail.Text.Length > 0)
                MessageBox.Show(obj1.custEditProfileEmail(newEmail));
            else
                MessageBox.Show("You have to fill the new email");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            Customers obj1 = new Customers(userID);

            newPassword = txtPassword.Text;
            if (txtPassword.Text.Length > 0)
                MessageBox.Show(obj1.custEditProfilePassword(newPassword));
            else
                MessageBox.Show("You have to fill the new Password");
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            Customers obj1 = new Customers(userID);

            newPhone = txtPhone.Text;
            if (txtPhone.Text.Length > 0)
                MessageBox.Show(obj1.custEditProfilePhoneNum(newPhone));
            else
                MessageBox.Show("You have to fill the new Phone Number");
        }

        private void btnAddres_Click(object sender, EventArgs e)
        {
            Customers obj1 = new Customers(userID);

            newAddress = txtAddress.Text;
            if (txtAddress.Text.Length > 0)
                MessageBox.Show(obj1.custEditProfileAddress(newAddress));
            else
                MessageBox.Show("You have to fill the new Address");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(userID);
            mm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
