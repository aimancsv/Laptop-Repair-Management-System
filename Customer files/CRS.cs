using System.Configuration;
using System.Data.SqlClient;

namespace Repair_Heads_compiled_program
{
    public partial class CRS : Form
    {
        private string userID = "";
        private string serviceType = "";
        private string urgency = "";
        private string serviceStatus = "";
        private string description = "";
        private string collectionDate = "";
        private int estimatedFee;

        private string newServiceType = "";
        private string newUrgency = "";
        private int newEstimatedFee;

        private string serviceID;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public CRS()
        {
            InitializeComponent();
        }

        public CRS(string un, string s)
        {
            InitializeComponent();
            userID = un;
            serviceID = s;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cusRS obj2 = new cusRS(userID);

            obj2.showSelectedService(serviceID);

            serviceType = obj2.ServiceType;
            urgency = obj2.Urgency;
            serviceStatus = obj2.ServiceStatus;
            lblStatus.Text = serviceStatus;
            lblCurrentService.Text = serviceType + " (" + urgency + ")";

            /*cusRS.ShowRS(obj2);

            serviceType = obj2.ServiceType;
            urgency = obj2.Urgency;
            serviceStatus = obj2.ServiceStatus;
            description = obj2.Description;

            lblStatus.Text = serviceStatus;
            lblCurrentService.Text = serviceType + " ("+ urgency + ")";*/

            /*con.Open();
            SqlCommand cmd1 = new SqlCommand("select ServiceStatus from Requested_service where UserID='" + userID + "'", con);
            serviceStatus = cmd1.ExecuteScalar().ToString();
            lblStatus.Text = serviceStatus;
            SqlCommand cmd2 = new SqlCommand("select ServiceType from Requested_service where UserID='" + userID + "'", con);
            serviceType = cmd2.ExecuteScalar().ToString();
            lblCurrentService.Text = serviceType;*/

            if (serviceStatus == "pending")
            {
                btnCS.Enabled = true;
            }
            else
            {
                btnCS.Enabled = false;
                btnCS.BackColor = Color.Gray;
                MessageBox.Show("You can't change the service if the current status is not 'Pending'");
            }


        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cusRS obj1 = new cusRS(userID);

            //Normal Services
            if (rbtnS1.Checked && rbtnNormal.Checked)
            {
                newServiceType = rbtnS1.Text;
                newUrgency = rbtnNormal.Text;
                newEstimatedFee = 50;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID,serviceID);
                crs.ShowDialog();
                this.Close();

            }
            else if (rbtnS2.Checked && rbtnNormal.Checked)
            {
                newServiceType = rbtnS2.Text;
                newUrgency = rbtnNormal.Text;
                newEstimatedFee = 60;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS3.Checked && rbtnNormal.Checked)
            {
                newServiceType = rbtnS3.Text;
                newUrgency = rbtnNormal.Text;
                newEstimatedFee = 380;
                
                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS4.Checked && rbtnNormal.Checked)
            {
                newServiceType = rbtnS4.Text;
                newUrgency = rbtnNormal.Text;
                newEstimatedFee = 160;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS5.Checked && rbtnNormal.Checked)
            {
                newServiceType = rbtnS5.Text;
                newUrgency = rbtnNormal.Text;
                newEstimatedFee = 180;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS6.Checked && rbtnNormal.Checked)
            {
                newServiceType = rbtnS6.Text;
                newUrgency = rbtnNormal.Text;
                newEstimatedFee = 100;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS7.Checked && rbtnNormal.Checked)
            {
                newServiceType = rbtnS7.Text;
                newUrgency = rbtnNormal.Text;
                newEstimatedFee = 80;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS8.Checked && rbtnNormal.Checked)
            {
                newServiceType = rbtnS8.Text;
                newUrgency = rbtnNormal.Text;
                newEstimatedFee = 70;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }

            //Urgent Services
            if (rbtnS1.Checked && rbtnUrgent.Checked)
            {
                newServiceType = rbtnS1.Text;
                newUrgency = rbtnUrgent.Text;
                newEstimatedFee = 80;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS2.Checked && rbtnUrgent.Checked)
            {
                newServiceType = rbtnS2.Text;
                newUrgency = rbtnUrgent.Text;
                newEstimatedFee = 90;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS3.Checked && rbtnUrgent.Checked)
            {
                newServiceType = rbtnS3.Text;
                newUrgency = rbtnUrgent.Text;
                newEstimatedFee = 430;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS4.Checked && rbtnUrgent.Checked)
            {
                newServiceType = rbtnS4.Text;
                newUrgency = rbtnUrgent.Text;
                newEstimatedFee = 200;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS5.Checked && rbtnUrgent.Checked)
            {
                newServiceType = rbtnS5.Text;
                newUrgency = rbtnUrgent.Text;
                newEstimatedFee = 210;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS6.Checked && rbtnUrgent.Checked)
            {
                newServiceType = rbtnS6.Text;
                newUrgency = rbtnUrgent.Text;
                newEstimatedFee = 150;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS7.Checked && rbtnUrgent.Checked)
            {
                newServiceType = rbtnS7.Text;
                newUrgency = rbtnUrgent.Text;
                newEstimatedFee = 130;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
            else if (rbtnS8.Checked && rbtnUrgent.Checked)
            {
                newServiceType = rbtnS8.Text;
                newUrgency = rbtnUrgent.Text;
                newEstimatedFee = 100;

                MessageBox.Show(obj1.custEditRS(newServiceType, newUrgency, newEstimatedFee));

                this.Hide();
                CRS crs = new CRS(userID, serviceID);
                crs.ShowDialog();
                this.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(userID);
            mm.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnS2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnS4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
