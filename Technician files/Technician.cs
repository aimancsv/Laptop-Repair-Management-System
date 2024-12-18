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

namespace Repair_Heads_compiled_program
{
    internal class Technician
    {
        

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private string description;
        private string serviceStatus;
        private string collectionDate;
        private string serviceID;

        public Technician(string d, string ss, string cd, string sid)
        {
            description = d;
            serviceStatus = ss;
            collectionDate = cd;
            serviceID = sid;
        }
        

        public void updateDatabase()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("update Requested_Service set  Description ='" + description + "', ServiceStatus ='" + serviceStatus + "', CollectionDate ='" + collectionDate + "'where ServiceID ='" + serviceID + "'", con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
