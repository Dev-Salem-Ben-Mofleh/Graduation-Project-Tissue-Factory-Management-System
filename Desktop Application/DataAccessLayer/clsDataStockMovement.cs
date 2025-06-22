using System;
using System.Data;
using System.Data.SqlClient;

namespace InstituteDataAccess 
{
    public class clsStockMovementData
    {
        public static bool GetStockMovementInfoByID(int? StockMovementID,ref int? MaterialID,ref int? ProductID,
            ref int? Quantity,ref DateTime StockMovementDate,ref int? StockMovementType,ref int? UserID,  ref int? TypeOfOperation
            ,ref int? SaleID, ref int? PurchaseID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetStockMovementByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StockMovementID", (object)StockMovementID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                 MaterialID = (reader["MaterialID"] != DBNull.Value) ? (int?)reader["MaterialID"] : null;
                                 ProductID = (reader["ProductID"] != DBNull.Value) ? (int?)reader["ProductID"] : null;
                                 Quantity = (reader["Quantity"] != DBNull.Value) ? (int?)reader["Quantity"] : null;
                                 StockMovementDate= (DateTime)reader["StockMovementDate"];
                                 StockMovementType = (reader["StockMovementType"] != DBNull.Value) ? (int?)reader["StockMovementType"] : null;
                                 UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                 TypeOfOperation = (reader["TypeOfOperation"] != DBNull.Value) ? (int?)reader["TypeOfOperation"] : null;
                                TypeOfOperation = (reader["SaleID"] != DBNull.Value) ? (int?)reader["SaleID"] : null;
                                TypeOfOperation = (reader["PurchaseID"] != DBNull.Value) ? (int?)reader["PurchaseID"] : null;

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


        public static bool GetStockMovementInfoBySaleID( int? SaleID,  int? ProductID, ref int? StockMovementID, ref int? MaterialID, 
    ref int? Quantity, ref DateTime StockMovementDate, ref int? StockMovementType, ref int? UserID, ref int? TypeOfOperation
    , ref int? PurchaseID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetStockMovementBySaleID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SaleID", (object)SaleID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ProductID", (object)ProductID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                MaterialID = (reader["MaterialID"] != DBNull.Value) ? (int?)reader["MaterialID"] : null;
                                ProductID = (reader["ProductID"] != DBNull.Value) ? (int?)reader["ProductID"] : null;
                                Quantity = (reader["Quantity"] != DBNull.Value) ? (int?)reader["Quantity"] : null;
                                StockMovementDate = (DateTime)reader["StockMovementDate"];
                                StockMovementType = (reader["StockMovementType"] != DBNull.Value) ? (int?)reader["StockMovementType"] : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                TypeOfOperation = (reader["TypeOfOperation"] != DBNull.Value) ? (int?)reader["TypeOfOperation"] : null;
                                StockMovementID = (reader["StockMovementID"] != DBNull.Value) ? (int?)reader["StockMovementID"] : null;
                                TypeOfOperation = (reader["PurchaseID"] != DBNull.Value) ? (int?)reader["PurchaseID"] : null;

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


        public static int? AddNewStockMovement(int? MaterialID,int? ProductID,int? Quantity,DateTime StockMovementDate,
            int? StockMovementType,int? UserID, int? TypeOfOperation ,  int? SaleID,int? PurchaseID)
        {
            // This function will return the new person id if succeeded and null if not
            int? StockMovementID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewStockMovement", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaterialID", (object)MaterialID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@ProductID", (object)ProductID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@Quantity", (object)Quantity ?? DBNull.Value);

                        command.Parameters.AddWithValue("@StockMovementDate", (object)StockMovementDate ?? DBNull.Value);

                        command.Parameters.AddWithValue("@StockMovementType", (object)StockMovementType ?? DBNull.Value);

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TypeOfOperation", (object)TypeOfOperation ?? DBNull.Value);
                        command.Parameters.AddWithValue("@SaleID", (object)SaleID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PurchaseID", (object)PurchaseID ?? DBNull.Value);




                        SqlParameter outputIdParam = new SqlParameter("@NewStockMovementID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        StockMovementID = (int?)outputIdParam.Value;
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

            return StockMovementID;
        }

        public static bool UpdateStockMovement(int? StockMovementID,int? MaterialID,int? ProductID,int? Quantity,DateTime StockMovementDate,
            int? StockMovementType,int? UserID, int? TypeOfOperation, int? SaleID,int? PurchaseID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateStockMovement", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaterialID", (object)MaterialID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@ProductID", (object)ProductID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@Quantity", (object)Quantity ?? DBNull.Value);

                        command.Parameters.AddWithValue("@StockMovementDate", StockMovementDate);

                        command.Parameters.AddWithValue("@StockMovementID", (object)StockMovementID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@StockMovementType", (object)StockMovementType ?? DBNull.Value);

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@TypeOfOperation", (object)TypeOfOperation ?? DBNull.Value);
                        command.Parameters.AddWithValue("@SaleID", (object)SaleID ?? DBNull.Value);
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

        public static bool DeleteStockMovement(int? StockMovementID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteStockMovement", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StockMovementID", (object)StockMovementID ?? DBNull.Value);

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

        public static bool DeleteStockMovementBySaleID(int? SaleID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteStockMovementBySaleID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SaleID", (object)SaleID ?? DBNull.Value);

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

        public static bool DeleteStockMovementByPurchaseID(int? PurchaseID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteStockMovementByPurchaseID", connection))
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

        public static bool DoesStockMovementExist(int? StockMovementID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DoesStockMovementExist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StockMovementID", (object)StockMovementID ?? DBNull.Value);

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

        public static DataTable GetAllStockMovements()
        {
            return clsDataAccessHelper.GetAll("SP_GetAllStockMovements");
        }



    }
}
