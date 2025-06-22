using System;
using System.Data;
using System.Data.SqlClient;

namespace InstituteDataAccess 
{
    public class clsProductionData
    {
        public static bool GetProductionInfoByID(int? ProductionID,ref int? DamagedQuantity,ref int? MaterialID,ref int? ProductID,ref DateTime ProductionDate,ref int? Quantity,ref int? RawAmount,ref int? StockMovementIDMaterial,ref int? StockMovementIDProduct,ref int? UserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetProductionByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ProductionID", (object)ProductionID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                IsFound = true;

                                 DamagedQuantity = (reader["DamagedQuantity"] != DBNull.Value) ? (int?)reader["DamagedQuantity"] : null;
                                 MaterialID = (reader["MaterialID"] != DBNull.Value) ? (int?)reader["MaterialID"] : null;
                                 ProductID = (reader["ProductID"] != DBNull.Value) ? (int?)reader["ProductID"] : null;
                                 ProductionDate= (DateTime)reader["ProductionDate"];
                                 Quantity = (reader["Quantity"] != DBNull.Value) ? (int?)reader["Quantity"] : null;
                                 RawAmount = (reader["RawAmount"] != DBNull.Value) ? (int?)reader["RawAmount"] : null;
                                 StockMovementIDMaterial = (reader["StockMovementIDMaterial"] != DBNull.Value) ? (int?)reader["StockMovementIDMaterial"] : null;
                                 StockMovementIDProduct = (reader["StockMovementIDProduct"] != DBNull.Value) ? (int?)reader["StockMovementIDProduct"] : null;
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

        public static int? AddNewProduction(int? DamagedQuantity,int? MaterialID,int? ProductID,
            DateTime ProductionDate,int? Quantity,int? RawAmount,int? StockMovementIDMaterial,int? StockMovementIDProduct,int? UserID)
        {            // This function will return the new person id if succeeded and null if not
            int? ProductionID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewProduction", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DamagedQuantity", (object)DamagedQuantity ?? DBNull.Value);

                        command.Parameters.AddWithValue("@MaterialID", (object)MaterialID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@ProductID", (object)ProductID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@ProductionDate", ProductionDate);

                        command.Parameters.AddWithValue("@Quantity", (object)Quantity ?? DBNull.Value);

                        command.Parameters.AddWithValue("@RawAmount", (object)RawAmount ?? DBNull.Value);

                        command.Parameters.AddWithValue("@StockMovementIDMaterial", (object)StockMovementIDMaterial ?? DBNull.Value);

                        command.Parameters.AddWithValue("@StockMovementIDProduct", (object)StockMovementIDProduct ?? DBNull.Value);

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);




                        SqlParameter outputIdParam = new SqlParameter("@NewProductionID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        ProductionID = (int?)outputIdParam.Value;
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

            return ProductionID;
        }

        public static bool UpdateProduction(int? ProductionID,int? DamagedQuantity,int? MaterialID,int? ProductID,DateTime ProductionDate,int? Quantity,int? RawAmount,int? StockMovementIDMaterial,int? StockMovementIDProduct,int? UserID )
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateProduction", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DamagedQuantity", (object)DamagedQuantity ?? DBNull.Value);

                        command.Parameters.AddWithValue("@MaterialID", (object)MaterialID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@ProductID", (object)ProductID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@ProductionDate", ProductionDate);

                        command.Parameters.AddWithValue("@ProductionID", (object)ProductionID ?? DBNull.Value);

                        command.Parameters.AddWithValue("@Quantity", (object)Quantity ?? DBNull.Value);

                        command.Parameters.AddWithValue("@RawAmount", (object)RawAmount ?? DBNull.Value);

                        command.Parameters.AddWithValue("@StockMovementIDMaterial", (object)StockMovementIDMaterial ?? DBNull.Value);

                        command.Parameters.AddWithValue("@StockMovementIDProduct", (object)StockMovementIDProduct ?? DBNull.Value);

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

        public static bool DeleteProduction(int? ProductionID)
        {
            int RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteProduction", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ProductionID", (object)ProductionID ?? DBNull.Value);

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

        public static bool DoesProductionExist(int? ProductionID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DoesProductionExist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ProductionID", (object)ProductionID ?? DBNull.Value);

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

        public static DataTable GetAllProductions()
        {
            return clsDataAccessHelper.GetAll("SP_GetAllProductions");
        }

        public static DataTable GetReports(string Culomn, DateTime ValueSearch)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetProductionReports", connection))
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
