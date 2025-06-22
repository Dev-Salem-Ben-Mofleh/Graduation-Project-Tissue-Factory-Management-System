using System;
using System.Data;
using System.Data.SqlClient;

namespace InstituteDataAccess 
{
    public class clsPurchaseData
    {
        public static bool GetPurchaseInfoByID(int? PurchaseID,ref int? BoxMovementID,ref int? CurrencyTypeID,
            ref decimal Discount,ref decimal NetAmount,ref int? PaymentStatuID,ref DateTime PurchaseDate,ref decimal TotalAmount,
            
            ref int? UserID,ref int? PersonID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPurchaseByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PurchaseID", (object)PurchaseID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                 BoxMovementID = (reader["BoxMovementID"] != DBNull.Value) ? (int?)reader["BoxMovementID"] : null;
                                 CurrencyTypeID = (reader["CurrencyTypeID"] != DBNull.Value) ? (int?)reader["CurrencyTypeID"] : null;
                                 Discount= (decimal)reader["Discount"];
                                 NetAmount = (decimal)reader["NetAmount"];
                                 PaymentStatuID = (reader["PaymentStatuID"] != DBNull.Value) ? (int?)reader["PaymentStatuID"] : null;
                                 PurchaseDate =(DateTime) reader["PurchaseDate"];
                                 TotalAmount= (decimal)reader["TotalAmount"];
                                 UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                 PersonID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;

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

        public static int? AddNewPurchase(int? BoxMovementID,int? CurrencyTypeID,decimal Discount,
            decimal NetAmount,int? PaymentStatuID, DateTime PurchaseDate,decimal TotalAmount,int? UserID,int?PersonID)
        {
            // This function will return the new person id if succeeded and null if not
            int? PurchaseID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewPurchase", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BoxMovementID", (object)BoxMovementID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@CurrencyTypeID", (object)CurrencyTypeID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@Discount", Discount);

                        command.Parameters.AddWithValue("@NetAmount", (object)NetAmount ?? DBNull.Value);

                        command.Parameters.AddWithValue("@PaymentStatuID", (object)PaymentStatuID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@PurchaseDate", PurchaseDate);

                        command.Parameters.AddWithValue("@TotalAmount", TotalAmount);

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);





                        SqlParameter outputIdParam = new SqlParameter("@NewPurchaseID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        PurchaseID = (int?)outputIdParam.Value;
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

            return PurchaseID;
        }

        public static bool UpdatePurchase(int? PurchaseID,int? BoxMovementID,int? CurrencyTypeID,decimal Discount,
            decimal NetAmount,int? PaymentStatuID,DateTime PurchaseDate,decimal TotalAmount,int? UserID
            ,int? PersonID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdatePurchase", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BoxMovementID", (object)BoxMovementID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@CurrencyTypeID", (object)CurrencyTypeID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@Discount", Discount);

                        command.Parameters.AddWithValue("@NetAmount", (object)NetAmount ?? DBNull.Value);

                        command.Parameters.AddWithValue("@PaymentStatuID", (object)PaymentStatuID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@PurchaseDate", PurchaseDate);

                        command.Parameters.AddWithValue("@PurchaseID", (object)PurchaseID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@TotalAmount", TotalAmount);

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);





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

        public static bool DeletePurchase(int? PurchaseID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeletePurchase", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PurchaseID", (object)PurchaseID ?? DBNull.Value);

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

        public static bool DoesPurchaseExist(int? PurchaseID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DoesPurchaseExist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PurchaseID", (object)PurchaseID ?? DBNull.Value);

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

        public static DataTable GetAllPurchases()
        {
            return clsDataAccessHelper.GetAll("SP_GetAllPurchases");
        }

        public static DataTable GetReports(string Culomn, DateTime ValueSearch)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPrunchesReports", connection))
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


        public static DataTable GetPruchesPaid(DateTime Datefrom, DateTime DateTo)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPruchesPaid", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Datefrom", Datefrom);
                        command.Parameters.AddWithValue("@DateTo", DateTo);


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

        public static DataTable GetPurchesNoPaid(DateTime Datefrom, DateTime DateTo)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPurchesNoPaid", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Datefrom", Datefrom);
                        command.Parameters.AddWithValue("@DateTo", DateTo);


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

        public static DataTable GetPurcheseTotal(DateTime Datefrom, DateTime DateTo)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetPurcheseTotal", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Datefrom", Datefrom);
                        command.Parameters.AddWithValue("@DateTo", DateTo);


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

        public static DataTable GetPurchesReportForDashboard(DateTime Datefrom, DateTime DateTo)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM dbo.GetPurchesReportForDashboard(@Datefrom, @DateTo)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text; // ÌÃ» √‰ ÌﬂÊ‰ Text Ê·Ì” TableDirect

                        command.Parameters.AddWithValue("@Datefrom", Datefrom);
                        command.Parameters.AddWithValue("@DateTo", DateTo);

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
