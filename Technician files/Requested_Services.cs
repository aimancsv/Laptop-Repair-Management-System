using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.VisualBasic;

namespace Repair_Heads_compiled_program
{
    public partial class frmRequestedServices : Form
    {
        int index;
        string loggedUserID;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmRequestedServices(string u)
        {
            InitializeComponent();
            // To allow selection of full row instead of single cell
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loggedUserID = u;
        }



        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save before leaving?", "Return To Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Technician obj = new Technician(txtAddDescription.Text, cmbServiceStatus.Text, dtPicker.Value.ToShortDateString(), txtServiceID.Text);
                obj.updateDatabase();
                MessageBox.Show("Details updated", "Saving Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Hide();
                frmTechMenu frm1 = new frmTechMenu(loggedUserID);
                frm1.ShowDialog();
                this.Close();
            } 
            else
            {
                this.Hide();
                frmTechMenu frm1 = new frmTechMenu(loggedUserID);
                frm1.ShowDialog();
                this.Close();
            }

        }

        private void frmRequestedServices_Load(object sender, EventArgs e)
        {
            // To add data to the dataviewgrid
         
            con.Open();

            string Query = "SELECT * FROM Requested_Service";
            
            SqlCommand cmd = new SqlCommand(Query, con);
            
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {   
                dataGridView1.Rows.Add(reader["ServiceID"], reader["UserID"], reader["SubmittedDate"], reader["ServiceType"], reader["Urgency"], reader["ServiceStatus"], reader["Description"], reader["CollectionDate"]);
            }


            con.Close();


        }

                     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // retriving data from datagridview into the text boxes

            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txtServiceID.Text = row.Cells[0].Value.ToString();
            cmbServiceStatus.Text = row.Cells[5].Value.ToString();
            txtAddDescription.Text = row.Cells[6].Value.ToString();
            if (row.Cells[7].Value.ToString() == "-")
                dtPicker.Value = DateTime.Now;
            else
                dtPicker.Value = Convert.ToDateTime(row.Cells[7].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // updating the datagridview

            DataGridViewRow newData = dataGridView1.Rows[index];
            newData.Cells[0].Value = txtServiceID.Text;
            newData.Cells[5].Value = cmbServiceStatus.Text;
            newData.Cells[6].Value = txtAddDescription.Text;
            newData.Cells[7].Value = dtPicker.Value.ToShortDateString();

            // MessageBox.Show("Record updated", "Updating Record", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save the changes?", "Updating Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Updating the database

                Technician obj = new Technician(txtAddDescription.Text, cmbServiceStatus.Text, dtPicker.Value.ToShortDateString(), txtServiceID.Text);
                obj.updateDatabase();
                MessageBox.Show("Details updated", "Saving Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
