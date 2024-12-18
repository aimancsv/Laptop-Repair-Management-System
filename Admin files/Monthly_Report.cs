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
    public partial class Monthly_Report : Form
    {
        // Opening Sql SqlConnection
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        string loggedUserID;
        public Monthly_Report(string u)
        {
            InitializeComponent();
            loggedUserID = u;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Screen form = new Admin_Screen(loggedUserID);
            form.ShowDialog();
            this.Close();
        }

        private void Monthly_Report_Load(object sender, EventArgs e)
        {
            dateTimePickerMonth.Format = DateTimePickerFormat.Custom;
            dateTimePickerMonth.CustomFormat = "MM";
            dateTimePickerMonth.ShowUpDown = true;
            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
            dateTimePickerYear.ShowUpDown = true;
            MonthlyReport();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            MonthlyReport();
        }

        //Monthly Report 
        private void MonthlyReport()
        {
            listSerReport.Items.Clear();
            int year = Convert.ToInt32(dateTimePickerYear.Value.ToString("yyyy"));
            int month = Convert.ToInt32(dateTimePickerMonth.Value.ToString("MM"));
            var firstDayOfMonth = new DateTime(year, month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            string monthYearSelected = "__/" + dateTimePickerMonth.Value.ToString("MM") + "/" + dateTimePickerYear.Value.ToString("yyyy");

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from [Requested_Service] WHERE SubmittedDate like '" + monthYearSelected + "' order by SubmittedDate", con);
            SqlDataReader read = cmd1.ExecuteReader();


            while (read.Read())
            {
                ListViewItem listitem = new ListViewItem(read["ServiceID"].ToString());
                listitem.SubItems.Add(read["SubmittedDate"].ToString());
                listitem.SubItems.Add(read["Urgency"].ToString());
                listitem.SubItems.Add(read["ServiceStatus"].ToString());
                listitem.SubItems.Add(read["CollectionDate"].ToString());
                listitem.SubItems.Add(read["EstimatedFee"].ToString());
                listitem.SubItems.Add(read["Payment"].ToString());
                listSerReport.Items.Add(listitem);

            }
            con.Close();

        }
        private void btnTotIncome_Click(object sender, EventArgs e)
        {
            MonthlyIncome();
        }

        //Monthly Income 

        private void MonthlyIncome()
        {

            string monthYearSelected = "__/" + dateTimePickerMonth.Value.ToString("MM") + "/" + dateTimePickerYear.Value.ToString("yyyy");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select sum(EstimatedFee) as monthlyincome from [Requested_Service] WHERE SubmittedDate LIKE '" + monthYearSelected + "' and Payment = 'paid'", con);
            SqlDataReader read = cmd1.ExecuteReader();

            while (read.Read())
            {
                lblTotal.Text = read["monthlyincome"].ToString();
            }
            con.Close();
        }

        private void dateTimePickerMonth_ValueChanged(object sender, EventArgs e)
        {
            MonthlyReport();
            lblTotal.Text = "";
        }

        private void dateTimePickerYear_ValueChanged(object sender, EventArgs e)
        {
            MonthlyReport();
            lblTotal.Text = "";
        }
    }
}
