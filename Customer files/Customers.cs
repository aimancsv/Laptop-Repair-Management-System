using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Heads_compiled_program
{
    internal class Customers
    {
        public string userID;
        private string password;
        private string name;
        private string doB;
        private string address;
        private string email;
        private string phoneNum;


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string DoB { get => doB; set => doB = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }



        public Customers(string un)
        {
            userID = un;
        }

        public static void ShowCustInfo(Customers o1)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from User_info where userID='" + o1.userID + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.name = rd.GetString(2);
                o1.doB = rd.GetString(3);
                o1.email = rd.GetString(5);
                o1.password = rd.GetString(1);
                o1.address = rd.GetString(4);
                o1.phoneNum = rd.GetString(6);
            }
            con.Close();
        }

        public string custEditProfileAll(string a, string b, string c, string d, string e)
        {
            string status;
            con.Open();

            doB = a;
            email = b;
            password = c;
            phoneNum = d;
            address = e;

            SqlCommand cmd = new SqlCommand("update User_Info set DoB='" + doB + "', Email='" + email + "', Password='" + password + "', Phone='" + phoneNum + "',Address='" + address + "'where UserID='" + userID + "'", con);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to Update.";
            con.Close();

            return status;

        }

        public string custEditProfileDoB(string dob)
        {
            string status;
            con.Open();

            doB = dob;

            SqlCommand cmd = new SqlCommand("update User_Info set  DoB='" + doB + "'where UserID='" + userID + "'", con);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to Update.";
            con.Close();

            return status;
        }

        public string custEditProfileEmail(string em)
        {
            string status;
            con.Open();

            email = em;

            SqlCommand cmd = new SqlCommand("update User_Info set Email='" + email + "'where UserID='" + userID + "'", con);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to Update.";
            con.Close();

            return status;
        }
        public string custEditProfilePassword(string pass)
        {
            string status;
            con.Open();

            password = pass;

            SqlCommand cmd = new SqlCommand("update User_Info set Password='" + password + "'where UserID='" + userID + "'", con);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to Update.";
            con.Close();

            return status;
        }

        public string custEditProfilePhoneNum(string pn)
        {
            string status;
            con.Open();

            phoneNum = pn;

            SqlCommand cmd = new SqlCommand("update User_Info set Phone='" + phoneNum + "'where UserID='" + userID + "'", con);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to Update.";
            con.Close();

            return status;
        }
        public string custEditProfileAddress(string add)
        {
            string status;
            con.Open();

            address = add;

            SqlCommand cmd = new SqlCommand("update User_Info set Address='" + address + "'where UserID='" + userID + "'", con);
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
