namespace Repair_Heads_compiled_program
{
    public partial class Registertion_Form : Form
    {
        private string loggedUserID;

        public Registertion_Form(string u)
        {
            InitializeComponent();
            loggedUserID = u;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtContact.Text != "" && dtpDoB.Value.ToShortDateString()!= "")
            {
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".") || !int.TryParse(txtContact.Text, out int numericValue))
                {
                    if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                        MessageBox.Show("Incorrect Email input");
                    if (!int.TryParse(txtContact.Text, out int numericValue2))
                        MessageBox.Show("Incorrect Phone Number input");
                }
                else if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".") && int.TryParse(txtContact.Text, out int numericValue3))
                {
                    int sameEmail = Admin.checkDuplicate("Email", txtEmail.Text);
                    int samePhone = Admin.checkDuplicate("Phone", txtContact.Text);
                    if (sameEmail > 0 || samePhone > 0)
                        if (sameEmail > 0)
                            MessageBox.Show("Email already registered in other account");
                    if (samePhone > 0)
                        MessageBox.Show("Phone Number already registered in other account");
                    else if (sameEmail == 0 && samePhone == 0)
                    {
                        if (cmbAccountType.Text == "Technician")
                        {
                            // Calling RegisterNewTechnician.
                            bool RegistrationAttempt = Admin.RegisterNewTechnician
                                (txtEmail.Text, txtContact.Text, txtName.Text, dtpDoB.Value.ToShortDateString(), txtAddress.Text);
                            if (RegistrationAttempt == true)
                            {
                                this.Hide();
                                Admin_Screen obj = new Admin_Screen(loggedUserID);
                                obj.ShowDialog();
                                this.Close();
                            }
                        }
                        else if (cmbAccountType.Text == "Receptionist")
                        {
                            // Calling RegisterNewReceptionist.
                            bool RegistrationAttempt = Admin.RegisterNewReceptionist
                                (txtEmail.Text, txtContact.Text, txtName.Text, dtpDoB.Value.ToShortDateString(), txtAddress.Text);
                            if (RegistrationAttempt == true)
                            {
                                this.Hide();
                                Admin_Screen obj = new Admin_Screen(loggedUserID);
                                obj.ShowDialog();
                                this.Close();
                            }
                        }

                    }
                }
            }
            else
                MessageBox.Show("Please fill in all details");
        }


            /*if (txtName.Text != "" && txtEmail.Text != "" && txtContact.Text
                != "" && txtBirth.Text != "" && cmbAccountType.Text == "Technician")
            {
                // Calling RegisterNewTechnician.
                bool RegistrationAttempt = Admin.RegisterNewTechnician
                    (txtEmail.Text, txtContact.Text, txtName.Text, txtBirth.Text, txtAddress.Text);
                if (RegistrationAttempt == true)
                {
                    this.Hide();
                    Admin_Screen obj = new Admin_Screen(loggedUserID);
                    obj.ShowDialog();
                    this.Close();
                }
            }
            else if (txtName.Text != "" && txtEmail.Text != "" && txtContact.Text 
                != "" && txtBirth.Text != "" && cmbAccountType.Text == "Receptionist")
            {
                // Calling RegisterNewReceptionist.
                bool RegistrationAttempt = Admin.RegisterNewReceptionist
                    (txtEmail.Text, txtContact.Text, txtName.Text, txtBirth.Text, txtAddress.Text);
                if (RegistrationAttempt == true)
                {
                    this.Hide();
                    Admin_Screen obj = new Admin_Screen(loggedUserID);
                    obj.ShowDialog();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please fill in all details");
        }*/

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Screen form = new Admin_Screen(loggedUserID);
            form.ShowDialog();
            this.Close();

        }
    }
}
