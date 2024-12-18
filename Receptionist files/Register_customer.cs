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
    public partial class Register_customer : Form
    {
        private string loggedUserID;

        public Register_customer()
        {
            InitializeComponent();
        }

        public Register_customer(string u)
        {
            InitializeComponent();
            loggedUserID = u;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtPhone.Text != "" && dtpDoB.Value.ToShortDateString() != "" && txtAddress.Text != "")
            {
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".") || !int.TryParse(txtPhone.Text, out int numericValue))
                {
                    if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                        MessageBox.Show("Incorrect Email input");
                    if (!int.TryParse(txtPhone.Text, out int numericValue2))
                        MessageBox.Show("Incorrect Phone Number input");
                }
                else if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".") && int.TryParse(txtPhone.Text, out int numericValue3))
                {
                    rec_Customer obj1 = new rec_Customer(txtName.Text, dtpDoB.Value.ToShortDateString(), txtAddress.Text, txtEmail.Text, txtPhone.Text);
                    int sameEmail = obj1.checkDuplicate("Email", txtEmail.Text);
                    int samePhone = obj1.checkDuplicate("Phone", txtPhone.Text);
                    if (sameEmail > 0 || samePhone > 0)
                        if (sameEmail > 0)
                            MessageBox.Show("Email already registered in other account");
                    if (samePhone > 0)
                        MessageBox.Show("Phone Number already registered in other account");
                    else if (sameEmail == 0 && samePhone == 0)
                    {
                        bool RegistrationAttempt = obj1.RegisterNewCustomer();
                        if (RegistrationAttempt == true)
                        {
                            this.Hide();
                            Receptionist_Menu obj = new Receptionist_Menu(loggedUserID);
                            obj.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
            else
                MessageBox.Show("Please fill in all details");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptionist_Menu obj = new Receptionist_Menu(loggedUserID);
            obj.ShowDialog();
            this.Close();
        }

        private void Register_customer_Load(object sender, EventArgs e)
        {

        }

        private void dtpDoB_ValueChanged(object sender, EventArgs e)
        {

        }

        Control ctrl;
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);    
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
        }

        private void dtpDoB_KeyDown(object sender, KeyEventArgs e)
        {
            ctrl = (Control)sender;
            if (ctrl is DateTimePicker)
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
            else
            {
                if (e.KeyCode == Keys.Right)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
                else
                    return;
            }
        }
    }
}
