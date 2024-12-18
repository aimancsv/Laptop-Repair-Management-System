using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Heads_compiled_program
{
    internal class cusRS
    {
        public string userID;
        private string serviceType;
        private string urgency;
        private string serviceStatus;
        private string description;
        private string collectionDate;
        private int estimatedFee;
        private string serviceID;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string ServiceType { get => serviceType; set => serviceType = value; }
        public string Urgency { get => urgency; set => urgency = value; }
        public string ServiceStatus { get => serviceStatus; set => serviceStatus = value; }
        public string Description { get => description; set => description = value; }
        public string CollectionDate { get => collectionDate; set => collectionDate = value; }
        public int EstimatedFee { get => estimatedFee; set => estimatedFee = value; }
        
        public cusRS(string un)
        {
            userID = un;
        }

        public static void ShowRS(cusRS o2)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select ServiceID from Requested_service where UserID='" + o2.userID + "'", con);
            o2.serviceID = cmd2.ExecuteScalar().ToString();
            SqlCommand cmd1 = new SqlCommand("select * from Requested_Service where UserID='" + o2.userID + "'", con);
            SqlDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
                o2.serviceType = rd.GetString(3);
                o2.urgency = rd.GetString(4);
                o2.serviceStatus = rd.GetString(5);
                o2.description = rd.GetString(6);
                //o2.collectionDate = rd.Getstring(7);
                //o2.estimatedFee = rd.GetInt32(8);

            }
            con.Close();
        }

        public ArrayList viewAllCusRS()
        {
            ArrayList ServiceID = new ArrayList();

            con.Open();
            SqlCommand cmd = new SqlCommand("select ServiceID from Requested_Service where UserID='" + userID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                ServiceID.Add(rd.GetString(0));
            con.Close();

            return ServiceID;
        }

        public void showSelectedService(string sid)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            con.Open();

            SqlCommand cmd1 = new SqlCommand("select * from Requested_Service where ServiceID='" + sid + "'", con);
            SqlDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
                serviceType = rd.GetString(3);
                urgency = rd.GetString(4);
                serviceStatus = rd.GetString(5);
                description = rd.GetString(6);
                collectionDate = rd.GetString(7);
                estimatedFee = rd.GetInt32(8);
            }
            con.Close();
        }

        public string custEditRS(string a, string b, int c)
        {
            string status;
            con.Open();

            serviceType = a;
            urgency = b;
            estimatedFee = c;

            SqlCommand cmd = new SqlCommand("update Requested_Service set ServiceType='" + serviceType + "', Urgency='" + urgency + "',EstimatedFee='" + estimatedFee + "'where UserID='" + userID + "'", con);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to Update.";
            con.Close();

            return status;
        }

    }
}
