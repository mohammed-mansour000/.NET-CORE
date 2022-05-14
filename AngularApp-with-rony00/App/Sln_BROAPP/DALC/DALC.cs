using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DALC
{
    public class DALC
    {
        public string connStr = "";
        public List<Court> GetAllCourts()
        {
            List<Court> oList = new List<Court>();
            
            // 2. Create sql connection object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the connection
                oConn.Open();

                // 4. Prepare sql command object
                using (SqlCommand command = new SqlCommand("UP_GET_COURT"))
                {
                    // 5. Set the command type either a text or storedProcedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // 6. Inform the command on which connection it should work
                    command.Connection = oConn;

                    // 7. Execute the command
                    // 8. The reader is a kind of hand/cursor pointing to data retrieved by the command 
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Court oCourt = new Court();

                                oCourt.COURT_ID = (int)reader["COURT_ID"];
                                oCourt.NAME = reader["NAME"].ToString();
                                oCourt.ADDRESS = reader["ADDRESS"].ToString();

                                oList.Add(oCourt);
                            }
                        }
                    }
                }
            }
            //When retrieving the data there is some errors in data's name
            //So we need to download a package called newtonsoftjson
            //oList = oList.OrderByDescending(e => e.COURT_ID).ToList();
            return oList;
        }

        //You should always create a complex type (Class) which has properties matching parameters
        public void Delete_Court(Params_Delete_Court i_Params_Delete_Court)
        {
            // 2. Create sql connection object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the connection
                oConn.Open();

                // 4. Prepare sql command object
                using (SqlCommand command = new SqlCommand("UP_DELETE_COURT"))
                {
                    // 5. Set the command type either a text or storedProcedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // 6. Inform the command on which connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "COURT_ID", Value = i_Params_Delete_Court.COURT_ID });

                    command.ExecuteNonQuery();
                }
            }
        }


        public void Add_Court(Court i_COURT)
        {
            // 2. Create sql connection object
            using (SqlConnection oConn = new SqlConnection(connStr))
            {
                // 3. Open the connection
                oConn.Open();

                // 4. Prepare sql command object
                using (SqlCommand command = new SqlCommand("UP_EDIT_COURT"))
                {
                    // 5. Set the command type either a text or storedProcedure
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // 6. Inform the command on which connection it should work
                    command.Connection = oConn;

                    command.Parameters.Add(new SqlParameter() { ParameterName = "COURT_ID", Value = i_COURT.COURT_ID });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "NAME", Value = i_COURT.NAME });
                    command.Parameters.Add(new SqlParameter() { ParameterName = "ADDRESS", Value = i_COURT.ADDRESS });

                    command.ExecuteNonQuery();
                }
            }
        }
    }


}
