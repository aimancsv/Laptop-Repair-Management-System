using System.Configuration;
using System.Data.SqlClient;

namespace Repair_Heads_compiled_program
{
    internal class Admin
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // Log in
        public static string Login(string userID, string password)
        {
            string loggedUserID = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from User_Info where UserID='"
                + userID + "' and password='" + password + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
                loggedUserID = userID;

            con.Close();
            return loggedUserID;
        }
        // Register new technician.
        public static bool RegisterNewTechnician(string e, string p, string n, string d, string a)
        {
            bool status = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count (*) from User_Info where Email='" + e + "'", con);
            int sameEmail = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            SqlCommand cmd2 = new SqlCommand("Select count (*) from User_Info where Phone='" + p + "'", con);
            int samePhone = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            if (sameEmail == 0 && samePhone == 0)
            {
                string newTechnicianID = technicianUserIDGenerator();
                string newTechnicianPassword = newTechnicianID + "pass";
                SqlCommand cmd3 = new SqlCommand("insert into User_Info(UserID,Password,Name,DoB,Address,Email,Phone) values(@UserID,@Password,@Name,@DoB,@Address,@Email,@Phone)", con);
                cmd3.Parameters.AddWithValue("@UserID", newTechnicianID);
                cmd3.Parameters.AddWithValue("@Password", newTechnicianPassword);
                cmd3.Parameters.AddWithValue("@Name", n);
                cmd3.Parameters.AddWithValue("@DoB", d);
                cmd3.Parameters.AddWithValue("@Address", a);
                cmd3.Parameters.AddWithValue("@Email", e);
                cmd3.Parameters.AddWithValue("@Phone", p);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("New technician succesfully registered\nUserID: " 
                    + newTechnicianID + "\nPassword: " + newTechnicianPassword);
                status = true;
            }
            else
            {
                if (sameEmail > 0)
                    MessageBox.Show("Email already registered in other account");
                if (samePhone > 0)
                    MessageBox.Show("Phone Number already registered in other account");
            }
            con.Close();
            return status;
        }

        // Register new receptionist.
        public static bool RegisterNewReceptionist(string e, string p, string n, string d, string a)
        {
            bool status = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count (*) from User_Info where Email='" + e + "'", con);
            int sameEmail = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            SqlCommand cmd2 = new SqlCommand("Select count (*) from User_Info where Phone='" + p + "'", con);
            int samePhone = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            if (sameEmail == 0 && samePhone == 0)
            {
                string newReceptionistID = receptionistUserIDGenerator();
                string newReceptionistPassword = newReceptionistID + "pass";
                SqlCommand cmd3 = new SqlCommand("insert into User_Info(UserID,Password,Name,DoB,Address,Email,Phone) values(@UserID,@Password,@Name,@DoB,@Address,@Email,@Phone)", con);
                cmd3.Parameters.AddWithValue("@UserID", newReceptionistID);
                cmd3.Parameters.AddWithValue("@Password", newReceptionistPassword);
                cmd3.Parameters.AddWithValue("@Name", n);
                cmd3.Parameters.AddWithValue("@DoB", d);
                cmd3.Parameters.AddWithValue("@Address", a);
                cmd3.Parameters.AddWithValue("@Email", e);
                cmd3.Parameters.AddWithValue("@Phone", p);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("New receptionist succesfully registered\nUserID: " + newReceptionistID + "\nPassword: " + newReceptionistPassword);
                status = true;
            }
            else
            {
                if (sameEmail > 0)
                    MessageBox.Show("Email already registered in other account");
                if (samePhone > 0)
                    MessageBox.Show("Phone Number already registered in other account");
            }
            con.Close();
            return status;
        }
        // Generate Technician UserID
        private static string technicianUserIDGenerator()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from User_info where UserID like 'tec%'", con);
            int count = (Convert.ToInt32(cmd.ExecuteScalar().ToString())) + 1;
            string newUserID = "";
            if (count < 10 && count > 0)
                newUserID = "tec00" + count;
            else if (count < 100 && count > 0)
                newUserID = "tec0" + count;
            else if (count >= 100)
                newUserID = "tec" + count;

            con.Close();

            return newUserID;
        }
        // Generate Receptionist UserID
        private static string receptionistUserIDGenerator()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from User_info where UserID like 'rec%'", con);
            int count = (Convert.ToInt32(cmd.ExecuteScalar().ToString())) + 1;
            string newUserID = "";
            if (count < 10 && count > 0)
                newUserID = "rec00" + count;
            else if (count < 100 && count > 0)
                newUserID = "rec0" + count;
            else if (count >= 100)
                newUserID = "rec" + count;

            con.Close();

            return newUserID;
        }

        public static int checkDuplicate(string str, string val)
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
