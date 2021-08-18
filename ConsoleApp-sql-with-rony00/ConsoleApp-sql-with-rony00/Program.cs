using System;
using System.Data.SqlClient;

namespace ConsoleApp_sql_with_rony00
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Define your connection string
            string connStr = @"Data Source=DESKTOP-FI4HSGV\MANSURSQL;Initial Catalog=Training;Integrated Security=True";
            // 2. Create sql connection object
            using(SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the connection
                oConn.Open();
                
                // 4. Prepare sql command object
                using(SqlCommand command = new SqlCommand("TEST"))
                {
                    // 5. Set the command type either a text or storedProcedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // 6. Inform the command on which connection it should work
                    command.Connection = oConn;

                    // 7. Execute the command
                    // 8. The reader is a kind of hand/cursor pointing to data retrieved by the command 
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine(
                                        String.Format(
                                        "{0} {1} : {2}",
                                        reader["FIRST_NAME"].ToString(),
                                        reader["LAST_NAME"].ToString(),
                                        reader["Program name"].ToString()
                                        )
                                    );
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
