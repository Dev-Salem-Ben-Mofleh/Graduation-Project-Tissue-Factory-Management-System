using System;
using System.Data;
using System.Data.SqlClient;

namespace InstituteDataAccess 
{
    public class clsExpenseData
    {
        public static bool GetExpenseInfoByID(int? ExpenseID,ref decimal Amount,ref int? BoxMovementID,ref string Description,ref DateTime ExpenseDate,ref int? TypesOfExpenseID,ref int? UserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetExpenseByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ExpenseID", (object)ExpenseID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                 Amount= (decimal)reader["Amount"];
                                 BoxMovementID = (reader["BoxMovementID"] != DBNull.Value) ? (int?)reader["BoxMovementID"] : null;
                                 Description = (reader["Description"] != DBNull.Value) ? (string)reader["Description"] : null;
                                 ExpenseDate= (DateTime)reader["ExpenseDate"];
                                 TypesOfExpenseID = (reader["TypesOfExpenseID"] != DBNull.Value) ? (int?)reader["TypesOfExpenseID"] : null;
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

        public static int? AddNewExpense(decimal Amount,int? BoxMovementID,string Description,DateTime ExpenseDate,int? TypesOfExpenseID,
            int? UserID)
        {
            // This function will return the new person id if succeeded and null if not
            int? ExpenseID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewExpense", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Amount", Amount);

                        command.Parameters.AddWithValue("@BoxMovementID", (object)BoxMovementID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value );

                        command.Parameters.AddWithValue("@ExpenseDate", ExpenseDate);

                        command.Parameters.AddWithValue("@TypesOfExpenseID", (object)TypesOfExpenseID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);




                        SqlParameter outputIdParam = new SqlParameter("@NewExpenseID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        ExpenseID = (int?)outputIdParam.Value;
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

            return ExpenseID;
        }

        public static bool UpdateExpense(int? ExpenseID,decimal Amount,int? BoxMovementID,string Description,DateTime ExpenseDate,int? TypesOfExpenseID,int? UserID )
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateExpense", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Amount", Amount);

                        command.Parameters.AddWithValue("@BoxMovementID", (object)BoxMovementID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value );

                        command.Parameters.AddWithValue("@ExpenseDate", ExpenseDate);

                        command.Parameters.AddWithValue("@ExpenseID", (object)ExpenseID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@TypesOfExpenseID", (object)TypesOfExpenseID ?? DBNull.Value);

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

        public static bool DeleteExpense(int? ExpenseID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteExpense", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ExpenseID", (object)ExpenseID ?? DBNull.Value);

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

        public static bool DoesExpenseExist(int? ExpenseID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DoesExpenseExist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ExpenseID", (object)ExpenseID ?? DBNull.Value);

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

        public static DataTable GetAllExpenses()
        {
            return clsDataAccessHelper.GetAll("SP_GetAllExpenses");
        }

        public static DataTable GetReports(string Culomn, DateTime ValueSearch)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetExpensReports", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Culomn", Culomn);
                        command.Parameters.AddWithValue("@ValueSearch", ValueSearch);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
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

            return dt;
        }

    }
}
