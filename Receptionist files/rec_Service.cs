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
    internal class rec_Service
    {
        private string SubmittedUserID;
        private string Service;
        private string Urgency;
        private string ServiceID;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        
        public rec_Service(string uid, string s, string u)
        {
            SubmittedUserID = uid;
            Service = s;
            Urgency = u;
        }

        public rec_Service(string sid)
        {
            ServiceID = sid;
        }

        public rec_Service()
        {

        }

        public string submitService()
        {
            string status = "";
            string serviceID = serviceIDGenerator();
            string submittedDate = DateTime.Now.ToShortDateString();

            int estimatedFee = serviceFee(Service, Urgency);
            MessageBox.Show(estimatedFee.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Requested_Service(ServiceID,UserID,SubmittedDate,ServiceType,Urgency,ServiceStatus,Description,CollectionDate,EstimatedFee,Payment) values(@ServiceID,@UserID,@SubmittedDate,@ServiceType,@Urgency,'pending','-','-',@EstimatedFee,'unpaid')", con);
            cmd.Parameters.AddWithValue("@ServiceID", serviceID);
            cmd.Parameters.AddWithValue("@UserID", SubmittedUserID);
            cmd.Parameters.AddWithValue("@SubmittedDate", submittedDate);
            cmd.Parameters.AddWithValue("@ServiceType", Service);
            cmd.Parameters.AddWithValue("@Urgency", Urgency);
            cmd.Parameters.AddWithValue("@EstimatedFee", estimatedFee);
            cmd.ExecuteNonQuery();
            status = "Service submitted for " + SubmittedUserID + "\nService ID: " + serviceID;

            con.Close();

            return status;
        }

        private string serviceIDGenerator()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Requested_Service", con);
            int count = (Convert.ToInt32(cmd.ExecuteScalar().ToString())) + 1;
            string newServiceID = "";

            if (count < 10 && count > 0)
                newServiceID = "S000" + count;
            else if (count < 100 && count > 0)
                newServiceID = "S00" + count;
            else if (count < 1000 && count > 0)
                newServiceID = "S0" + count;
            else if (count >= 1000)
                newServiceID = "S" + count;

            con.Close();

            return newServiceID;
        }

        public static int serviceFee(string st, string u)
        {
            int fee = 0;
            if (u == "normal")
            {
                if (st == "Remove virus, malware, or spyware")
                    fee = 50;
                else if (st == "Troubleshoot and fix computer running slow")
                    fee = 60;
                else if (st == "Laptop screen replacement")
                    fee = 380;
                else if (st == "Laptop keyboard replacement")
                    fee = 160;
                else if (st == "Laptop battery replacement")
                    fee = 180;
                else if (st == "Operating System format and installation")
                    fee = 100;
                else if (st == "Data backup and recovery")
                    fee = 80;
                else if (st == "Internet connectivity issues")
                    fee = 70;
            }
            else if (u == "urgent")
            {
                if (st == "Remove virus, malware, or spyware")
                    fee = 80;
                else if (st == "Troubleshoot and fix computer running slow")
                    fee = 90;
                else if (st == "Laptop screen replacement")
                    fee = 430;
                else if (st == "Laptop keyboard replacement")
                    fee = 200;
                else if (st == "Laptop battery replacement")
                    fee = 210;
                else if (st == "Operating System format and installation")
                    fee = 150;
                else if (st == "Data backup and recovery")
                    fee = 130;
                else if (st == "Internet connectivity issues")
                    fee = 100;
            }

            return fee;
        }

        public ArrayList viewAllServiceID()
        {
            ArrayList s = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select ServiceID from Requested_Service", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                s.Add(rd.GetString(0));
            con.Close();
            return s;
        }

        public string findCustomerIDRelated()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select UserID from Requested_Service where ServiceID = '" + ServiceID + "'", con);
            string id = cmd.ExecuteScalar().ToString();
            con.Close();
            SubmittedUserID = id;
            return id;
        }


        public string viewServiceDetail(string str)
        {
            con.Open();
            string detail = "";
            if (str == "SubmittedDate")
            {
                SqlCommand cmd = new SqlCommand("select " + str + " from Requested_Service where ServiceID = '" + ServiceID + "'", con);
                DateTime dt = Convert.ToDateTime(cmd.ExecuteScalar().ToString());
                detail = dt.ToShortDateString();

            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("select " + str + " from Requested_Service where ServiceID = '" + ServiceID + "'", con);
                detail = cmd2.ExecuteScalar().ToString();
            }
            con.Close();
            return detail;
        }

        public string viewCustomerDetail(string str)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select " + str + " from User_Info where UserID = '" + SubmittedUserID + "'", con);
            string detail = cmd.ExecuteScalar().ToString();
            con.Close();
            return detail;
        }

        public string receivePayment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Requested_Service set Payment = 'paid' where ServiceID ='" + ServiceID + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            string status = "Payment from service" + ServiceID + "received";
            return status;
        }
    }
}
