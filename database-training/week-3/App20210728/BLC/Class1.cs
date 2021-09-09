using System;
using System.Data;
using System.Data.SqlClient;

namespace BLC
{
    public class BLC
    {
        #region Get CUSTOMER
        public static void GetData(SqlConnection _con)
        {
            string query = "UP_GET_CUSTOMERS";
            using (SqlCommand _cmd = new SqlCommand(query, _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter _dap = new SqlDataAdapter(_cmd);
                _dap.Fill(dt);
                Console.WriteLine("Customers list: ");
                Console.WriteLine("first name - last name - country name - purchase date - total");
                foreach (DataRow item in dt.Rows)
                {
                    Console.WriteLine($"{item["FNAME"]}  -  {item["LNAME"]}  -  {item["COUNTRY_NAME"]}  -  {item["PDATE"]}  -  {item["TOTAL"]}");
                }
                Console.WriteLine("");
            }
        }
        #endregion

        #region Get Country
        public static void GetCountries(SqlConnection _con)
        {
            string query = "UP_GET_COUNTRY";
            using (SqlCommand _cmd = new SqlCommand(query, _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter _dap = new SqlDataAdapter(_cmd);
                _dap.Fill(dt);
                Console.WriteLine("Countries list: ");
                Console.WriteLine("country ID - country name");
                foreach (DataRow item in dt.Rows)
                {
                    Console.WriteLine($"{item["ID"]} - {item["NAME"]}");
                }
                Console.WriteLine("");
            }
        }
        #endregion

        #region Insert CUSTOMER
        public static void InsertCustomer(SqlConnection _con)
        {

            Console.WriteLine("Enter fname name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter lname name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter country ID");
            string countryId = Console.ReadLine();
            Console.WriteLine("Enter purchase date");
            string pdate = Console.ReadLine();
            Console.WriteLine("Enter total");
            string total = Console.ReadLine();

            string query = "UP_INSERT_CUSTOMER";
            using (SqlCommand _cmd = new SqlCommand(query, _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;

                _cmd.Parameters.Add("FNAME", SqlDbType.NVarChar);
                _cmd.Parameters["FNAME"].Value = fname;

                _cmd.Parameters.Add("LNAME", SqlDbType.NVarChar);
                _cmd.Parameters["LNAME"].Value = lname;

                _cmd.Parameters.Add("PDATE", SqlDbType.Date);
                _cmd.Parameters["PDATE"].Value = pdate;

                _cmd.Parameters.Add("TOTAL", SqlDbType.Real);
                _cmd.Parameters["TOTAL"].Value = total;

                _cmd.Parameters.Add("COUNTRY_ID", SqlDbType.Int);
                _cmd.Parameters["COUNTRY_ID"].Value = countryId;

                _con.Open();
                _cmd.ExecuteNonQuery();
                Console.WriteLine("Customer Inserted");
                _con.Close();
            }
        }
        #endregion

        #region update CUSTOMER
        public static void updateCustomer(SqlConnection _con)
        {

            Console.WriteLine("Enter fname name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter lname name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter customer ID");
            string customerId = Console.ReadLine();

            string query = "UP_UPDATE_CUSTOMER";

            using (SqlCommand _cmd = new SqlCommand(query, _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;

                _cmd.Parameters.Add("@FNAME", SqlDbType.NVarChar);
                _cmd.Parameters["@FNAME"].Value = fname;

                _cmd.Parameters.Add("@LNAME", SqlDbType.NVarChar);
                _cmd.Parameters["@LNAME"].Value = lname;

                _cmd.Parameters.Add("@ID", SqlDbType.Int);
                _cmd.Parameters["@ID"].Value = customerId;

                _con.Open();
                _cmd.ExecuteNonQuery();
                Console.WriteLine("Customer Updated");
                _con.Close();
            }
        }
        #endregion

        #region Insert COUNTRY
        public static void InsertCountry(SqlConnection _con)
        {

            Console.WriteLine("Enter country name");
            string countryName = Console.ReadLine();
            string query = "UP_INSERT_COUNTRY";
            using (SqlCommand _cmd = new SqlCommand(query, _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;

                _cmd.Parameters.Add("@NAME", SqlDbType.NVarChar);
                _cmd.Parameters["@NAME"].Value = countryName;

                _con.Open();
                _cmd.ExecuteNonQuery();
                Console.WriteLine("Country Inserted");
                _con.Close();
            }
        }
        #endregion

        #region delete COUNTRY
        public static void deleteCountry(SqlConnection _con)
        {

            Console.WriteLine("Enter Country ID to Delete");
            string countryId = Console.ReadLine();

            string query = "UP_DELETE_COUNTRY";
            
            using (SqlCommand _cmd = new SqlCommand(query, _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;

                _cmd.Parameters.Add("@ID", SqlDbType.Int);
                _cmd.Parameters["@ID"].Value = countryId;

                _con.Open();
                _cmd.ExecuteNonQuery();
                Console.WriteLine("Country Deleted");
                _con.Close();
            }
        }
        #endregion

        #region delete CUSTOMER
        public static void deleteCustomer(SqlConnection _con)
        {

            Console.WriteLine("Enter Customer ID to Delete");
            string customerId = Console.ReadLine();

            string query = "UP_DELETE_CUSTOMER";
            
            using (SqlCommand _cmd = new SqlCommand(query, _con))
            {
                _cmd.CommandType = CommandType.StoredProcedure;

                _cmd.Parameters.Add("@ID", SqlDbType.Int);
                _cmd.Parameters["@ID"].Value = customerId;

                _con.Open();
                _cmd.ExecuteNonQuery();
                Console.WriteLine("Customer Deleted");
                _con.Close();
            }
        }
        #endregion
    }
}
