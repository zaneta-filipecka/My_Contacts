using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace My_Contacts.MyContactsClasses
{
    class Contact
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }

        static string myContactConnectionString = ConfigurationManager.ConnectionStrings["My_Contacts.Properties.Settings.MyContactsConnectionString"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myContactConnectionString);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Contacts";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                
            }
            finally 
            {
                conn.Close();
            }
            return dt;
        }

        public bool Insert(Contact c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myContactConnectionString);
            try
            {
                string sql = @"INSERT INTO Contacts ([FirstName], [LastName], [Address], [E-mail], [Phone], [Company]) VALUES (@FirstName, @LastName, @Address, @Email, @Phone, @Company)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Company", c.Company);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Update(Contact c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myContactConnectionString);
            try
            {
                string sql = @"UPDATE Contacts SET [FirstName]=@FirstName, [LastName]=@LastName, [Address]=@Address, [E-mail]=@Email, [Phone]=@Phone, [Company]=@Company WHERE [ContactID]=@ContactID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Company", c.Company);
                cmd.Parameters.AddWithValue("ContactID", c.ContactID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Delete(Contact c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myContactConnectionString);
            try
            {
                string sql = "DELETE FROM Contacts WHERE ContactID=@ContactID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
