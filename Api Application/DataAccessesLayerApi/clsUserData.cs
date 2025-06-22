using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessesLayerApi
{
    public class clsUserData
    {
        public class UserDTO
        {
            public UserDTO(string? Name)
            {
                this.Name = Name;
            }

            public string? Name { get; set; }


        }

        public static List<UserDTO> GetAllRows(string UserName, string Password)
        {

            var SaleReports = new List<UserDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_GetUserByUserNameAndPasswordApi", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@UserName", UserName);
                        Command.Parameters.AddWithValue("@Password", Password);


                        connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                SaleReports.Add(new UserDTO
                                (
                                reader.IsDBNull(reader.GetOrdinal("Name")) ? null :
                                reader.GetString(reader.GetOrdinal("Name"))
                                ));
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return SaleReports;

        }

    }
}
