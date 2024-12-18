using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Heads_compiled_program
{
    internal class User
    {
        private string userID; //for log in attempt
        private string password; // for log in attempt
        private string loggedUserID; //after successfully logged in

        private string Name;
        private string Email;
        private string DoB;
        private string Address;
        private string Phone;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string email { get => Email; set => Email = value; }
        public string phone { get => Phone; set => Phone = value; }

        public User(string u, string p, string e, string ph, string d, string a)
        {
            loggedUserID = u;
            password = p;
            Email = e;
            Phone = ph;
            DoB = d;
            Address = a;
        }

        public User(string u, string p)
        {
            userID = u;
            password = p;
        }

        public User(string u)
        {
            loggedUserID = u;
        }

        public User()
        {

        }

        public string Login()
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from User_Info where UserID='" + userID + "' and Password='" + password + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
                loggedUserID = userID;
            else
                loggedUserID = "";

            con.Close();
            return loggedUserID;
        }

        public string readInfo(string str)
        {
            string infoRetrieved = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("select " + str + " from User_Info where UserID='" + loggedUserID + "'", con);
            infoRetrieved = cmd.ExecuteScalar().ToString();
            con.Close();
            return infoRetrieved;
        }

        public int checkDuplicate(string str, string val)
        {
            int sameInfo = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count (*) from User_Info where " + str + "='" + val + "'", con);
            sameInfo = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            return sameInfo;
        }

        public string UpdateProfile()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update User_Info set  Password ='" + password + "',DoB ='" + DoB + "',Address ='" + Address + "',Email ='" + Email + "',Phone ='" + Phone + "'where UserID ='" + loggedUserID + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            string status = "Profile upadted";
            return status;
        }

        
    }
}
