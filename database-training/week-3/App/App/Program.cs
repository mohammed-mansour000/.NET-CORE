using System;
using System.Data;
using System.Data.SqlClient;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=DESKTOP-FI4HSGV\MANSURSQL;Initial Catalog=TEST_17072021;Integrated Security=True";
            using (SqlConnection _con = new SqlConnection(constr))
            {
                #region Get Data
                //string query = "SELECT * FROM CUSTOMER";
                //using(SqlCommand _cmd = new SqlCommand(query, _con))
                //{
                //    DataTable dt = new DataTable();
                //    SqlDataAdapter _adp = new SqlDataAdapter(_cmd);

                //    _adp.Fill(dt);
                //    foreach (DataRow item in dt.Rows)
                //    {
                //        Console.WriteLine($"{item["ID"]} - {item["FNAME"]} {item["LNAME"]}");
                //    }
                //}
                #endregion

                #region Insert Data
                Console.WriteLine("enter firstname:");
                string fname = Console.ReadLine();
                Console.WriteLine("enter lastname:");
                string lname = Console.ReadLine();
                string query = "INSERT INTO [CUSTOMER] (FNAME, LNAME, COUNTRY_ID) VALUES (@fname, @lname, 1)";
                using (SqlCommand _cmd = new SqlCommand(query, _con))
                {
                    _cmd.Parameters.Add("@fname", SqlDbType.NVarChar);
                    _cmd.Parameters["@fname"].Value = fname;

                    _cmd.Parameters.Add("@lname", SqlDbType.NVarChar);
                    _cmd.Parameters["@lname"].Value = lname;

                    _con.Open();
                    _cmd.ExecuteNonQuery();
                    _con.Close();
                }
                #endregion
            }
        }
    }
}
