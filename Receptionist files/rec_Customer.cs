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
    internal class rec_Customer
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        string newCusID;
        string newCusPassword;
        string newCusName;
        string newCusDoB;
        string newCusAddress;
        string newCusEmail;
        string newCusPhone;

        public rec_Customer(string n, string d, string a, string e, string ph)
        {
            newCusName = n;
            newCusDoB = d;
            newCusAddress = a;
            newCusEmail = e;
            newCusPhone = ph;
        }

        public rec_Customer()
        {

        }

        public bool RegisterNewCustomer()
        {
            bool status = false;
            con.Open();
           
            newCusID = customerUserIDGenerator();
            newCusPassword = newCusID + "pass";

            SqlCommand cmd3 = new SqlCommand("insert into User_Info(UserID,Password,Name,DoB,Address,Email,Phone) values(@UserID,@Password,@Name,@DoB,@Address,@Email,@Phone)", con);
            cmd3.Parameters.AddWithValue("@UserID", newCusID);
            cmd3.Parameters.AddWithValue("@Password", newCusPassword);
            cmd3.Parameters.AddWithValue("@Name", newCusName);
            cmd3.Parameters.AddWithValue("@DoB", newCusDoB);
            cmd3.Parameters.AddWithValue("@Address", newCusAddress);
            cmd3.Parameters.AddWithValue("@Email", newCusEmail);
            cmd3.Parameters.AddWithValue("@Phone", newCusPhone);
            cmd3.ExecuteNonQuery();
            MessageBox.Show("New customer succesfully registered\nUserID: " + newCusID + "\nPassword: " + newCusPassword);
            status = true;

            con.Close();
            return status;
        }

        private string customerUserIDGenerator()
        {
            //con.Open(); << it said connection was already opened because it's being called by other method that already opened the connection
            SqlCommand cmd = new SqlCommand("select count(*) from User_info where UserID like 'cus%'", con);
            int count = (Convert.ToInt32(cmd.ExecuteScalar().ToString())) + 1;
            string newUserID = "";
            if (count < 10 && count > 0)
                newUserID = "cus00" + count;
            else if (count < 100 && count > 0)
                newUserID = "cus0" + count;
            else if (count >= 100)
                newUserID = "cus" + count;

            //con.Close();

            return newUserID;
        }

        public ArrayList viewAllCustomerID()
        {
            ArrayList c = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select UserID from User_Info where UserID like 'cus%'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                c.Add(rd.GetString(0));
            con.Close();
            return c;
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
    }
}
