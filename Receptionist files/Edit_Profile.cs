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
    public partial class Edit_Profile : Form
    {
        private string loggedUserID = "";
        private string currentName = "";
        private string currentPassword = "";
        private string currentDoB = "";
        private string currentEmail = "";
        private string currentPhone = "";
        private string currentAddress = "";
        private string newPassword = "";
        private string newDoB = "";
        private string newEmail = "";
        private string newPhone = "";
        private string newAddress = "";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Edit_Profile()
        {
            InitializeComponent();
        }

        public Edit_Profile(string un)
        {
            InitializeComponent();
            loggedUserID = un;
        }

        private void updateStat()
        {
            if (!cbNewPassword.Checked && !cbNewDoB.Checked && !cbNewEmail.Checked && !cbNewPhone.Checked && !cbNewAddress.Checked)
            {
                btnUpdateProfile.Enabled = false;
            }
            else
            {
                btnUpdateProfile.Enabled = true;
            }
        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {
            txtNewPassword.Enabled = false;
            dtpDoB.Enabled = false;
            txtNewEmail.Enabled = false;
            txtNewPhone.Enabled = false;
            txtNewAddress.Enabled = false;

            User obj1 = new User(loggedUserID);
            currentName = obj1.readInfo("Name");
            currentPassword = newPassword = obj1.readInfo("Password");
            currentDoB = newDoB = Convert.ToDateTime(obj1.readInfo("DoB")).ToShortDateString();
            currentEmail = newEmail = obj1.readInfo("Email");
            currentPhone = newPhone =obj1.readInfo("Phone");
            currentAddress = newAddress = obj1.readInfo("Address");

            lblCurrentDetails.Text = "UserID: " + loggedUserID + "\nPassword: *********\nName: " + currentName + "\nDoB: " + currentDoB + "\nEmail: " + currentEmail + "\nPhone: " + currentPhone + "\nAddress:\n" + currentAddress;
            btnUpdateProfile.Enabled = false;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
                lblCurrentDetails.Text = "UserID: " + loggedUserID + "\nPassword: " + currentPassword + "\nName: " + currentName + "\nDoB: " + currentDoB + "\nEmail: " + currentEmail + "\nPhone: " + currentPhone + "\nAddress:\n" + currentAddress;
            else
                lblCurrentDetails.Text = "UserID: " + loggedUserID + "\nPassword: *********\nName: " + currentName + "\nDoB: " + currentDoB + "\nEmail: " + currentEmail + "\nPhone: " + currentPhone + "\nAddress:\n" + currentAddress;

        }

        private void cbNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            updateStat();
            if (cbNewPassword.Checked)
            {
                txtNewPassword.Enabled = true;
            }
            else
            {
                txtNewPassword.Enabled = false;
                newPassword = currentPassword;
            }

        }

        private void cbNewDoB_CheckedChanged(object sender, EventArgs e)
        {
            updateStat();
            if (cbNewDoB.Checked)
            {
                dtpDoB.Enabled = true;
                newDoB = dtpDoB.Value.ToShortDateString();
            }
            else
            {
                dtpDoB.Enabled = false;
                newDoB = currentDoB;
            }
        }

        private void cbNewEmail_CheckedChanged(object sender, EventArgs e)
        {
            updateStat();
            if (cbNewEmail.Checked)
            {
                txtNewEmail.Enabled = true;
            }
            else
            {
                txtNewEmail.Enabled = false;
                txtNewEmail.Clear();
                newEmail = currentEmail;
            }
        }

        private void cbNewPhone_CheckedChanged(object sender, EventArgs e)
        {
            updateStat();
            if (cbNewPhone.Checked)
            {
                txtNewPhone.Enabled = true;
            }
            else
            {
                txtNewPhone.Enabled = false;
                txtNewPhone.Clear();
                newPhone = currentPhone;
            }
        }

        private void cbNewAddress_CheckedChanged(object sender, EventArgs e)
        {
            updateStat();
            if (cbNewPassword.Checked)
            {
                txtNewAddress.Enabled = true;
            }
            else
            {
                txtNewAddress.Enabled = false;
                txtNewAddress.Clear();
                newAddress = currentAddress;
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            newPassword = txtNewPassword.Text;
        }

        private void txtNewEmail_TextChanged(object sender, EventArgs e)
        {
            newEmail = txtNewEmail.Text;
        }

        private void txtNewPhone_TextChanged(object sender, EventArgs e)
        {
            newPhone = txtNewPhone.Text;
        }

        private void txtNewAddress_TextChanged(object sender, EventArgs e)
        {
            newAddress = txtNewAddress.Text;
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string status = "";

            User obj1 = new User(loggedUserID, newPassword, newEmail, newPhone, newDoB, newAddress);


            int failure = 0;
            if (cbNewPassword.Checked && txtNewPassword.Text == "")
            {
                MessageBox.Show("Please insert new password");
                failure++;
            }
            if (cbNewEmail.Checked)
            {
                if (txtNewEmail.Text == "")
                {
                    MessageBox.Show("Please insert new email");
                    failure++;
                }
                else
                {
                    if (!txtNewEmail.Text.Contains("@") && !txtNewEmail.Text.Contains("."))
                    {
                        MessageBox.Show("Invalid Email input");
                        failure++;
                    }
                    else
                    {
                        int sameEmail = obj1.checkDuplicate("Email", obj1.email);
                        if (sameEmail > 0)
                        {
                            MessageBox.Show("new email already registered in other account");
                            failure++;
                        }
                    }
                }
            }
            if (cbNewPhone.Checked)
            {
                if (txtNewPhone.Text == "")
                {
                    MessageBox.Show("Please insert new phone Number");
                    failure++;
                }
                else
                {
                    if (!int.TryParse(txtNewPhone.Text, out int numericValue))
                    {
                        MessageBox.Show("Invalid Phone number  input");
                        failure++;
                    }
                    else
                    {
                        int samePhone = obj1.checkDuplicate("Phone", obj1.phone);
                        if (samePhone > 0)
                        {
                            MessageBox.Show("new phone number already registered in other account");
                            failure++;
                        }
                    }
                }
            }
            if (cbNewAddress.Checked && txtNewAddress.Text == "")
            {
                MessageBox.Show("Please insert new address");
                failure++;
            }
            
            if (failure == 0)
            {
                MessageBox.Show(obj1.UpdateProfile());

                if (loggedUserID.Contains("rec"))
                {
                    this.Hide();
                    Receptionist_Menu obj = new Receptionist_Menu(loggedUserID);
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
            }

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptionist_Menu obj = new Receptionist_Menu(loggedUserID);
            obj.ShowDialog();
            this.Close();
        }

        private void dtpDoB_ValueChanged(object sender, EventArgs e)
        {
            newDoB = dtpDoB.Value.ToShortDateString();
        }
    }
}
