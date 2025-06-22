using System;
using System.Data;
using System.Data.SqlClient;

namespace InstituteDataAccess 
{
    public class clsBoxMovementData
    {
        public static bool GetBoxMovementInfoByID(int? BoxMovementID,ref decimal Amount,ref int? BoxID,ref DateTime BoxMovementDate,ref string Description,ref int? MovementType,ref int? UserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetBoxMovementByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BoxMovementID", (object)BoxMovementID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                 Amount= (decimal)reader["Amount"];
                                 BoxID = (reader["BoxID"] != DBNull.Value) ? (int?)reader["BoxID"] : null;
                                 BoxMovementDate= (DateTime)reader["BoxMovementDate"];
                                Description = (reader["Description"] != DBNull.Value) ? (string)reader["Description"] : null;
                                 MovementType = (reader["MovementType"] != DBNull.Value) ? (int?)reader["MovementType"] : null;
                                 UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                            }
                            else
                            {
                                // The record was not found
                                IsFound = false;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                IsFound = false;

                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("Database Exception", ex);
            }
            catch (Exception ex)
            {
                IsFound = false;

                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("General Exception", ex);
            }

            return IsFound;
        }

        public static int? AddNewBoxMovement(decimal Amount,int? BoxID,DateTime BoxMovementDate,string Description,int? MovementType,int? UserID)
        {
            // This function will return the new person id if succeeded and null if not
            int? BoxMovementID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewBoxMovement", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Amount", Amount);

                        command.Parameters.AddWithValue("@BoxID", (object)BoxID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@BoxMovementDate", BoxMovementDate);

                        command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);

                        command.Parameters.AddWithValue("@MovementType", (object)MovementType ?? DBNull.Value);

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);




                        SqlParameter outputIdParam = new SqlParameter("@NewBoxMovementID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        BoxMovementID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (SqlException ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("Database Exception", ex);
            }
            catch (Exception ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("General Exception", ex);
            }

            return BoxMovementID;
        }

        public static bool UpdateBoxMovement(int? BoxMovementID,decimal Amount,int? BoxID,DateTime BoxMovementDate,string Description,int? MovementType,int? UserID )
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateBoxMovement", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Amount", Amount);

                        command.Parameters.AddWithValue("@BoxID", (object)BoxID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@BoxMovementDate", BoxMovementDate);

                        command.Parameters.AddWithValue("@BoxMovementID", (object)BoxMovementID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);

                        command.Parameters.AddWithValue("@MovementType", (object)MovementType ?? DBNull.Value);

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);




                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("Database Exception", ex);
            }
            catch (Exception ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("General Exception", ex);
            }

            return (RowAffected > 0);
        }

        public static bool DeleteBoxMovement(int? BoxMovementID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteBoxMovement", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BoxMovementID", (object)BoxMovementID ?? DBNull.Value);

                        RowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("Database Exception", ex);
            }
            catch (Exception ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("General Exception", ex);
            }

            return (RowAffected > 0);
        }

        public static bool DoesBoxMovementExist(int? BoxMovementID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DoesBoxMovementExist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BoxMovementID", (object)BoxMovementID ?? DBNull.Value);

                        // @ReturnVal could be any name, and we don't need to add it to the SP, just use it here in the code.
                        SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        command.Parameters.Add(returnParameter);

                        command.ExecuteNonQuery();

                        IsFound = (int)returnParameter.Value == 1;
                    }
                }
            }
            catch (SqlException ex)
            {
                IsFound = false;

                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("Database Exception", ex);
            }
            catch (Exception ex)
            {
                IsFound = false;

                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("General Exception", ex);
            }

            return IsFound;
        }

        public static DataTable GetAllBoxMovements()
        {
            return clsDataAccessHelper.GetAll("SP_GetAllBoxMovements");
        }


    }
}
