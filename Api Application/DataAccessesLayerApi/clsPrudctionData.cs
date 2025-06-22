using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessesLayerApi.clsDataSaleReportss;

namespace DataAccessesLayerApi
{
    public class clsPrudctionData
    {
        public class ProdctionDTO
        {

            public ProdctionDTO(DateTime? ProductionDate, string? ProductName, int? Quantity, int? DamagedQuantity, 
                string? Material_Name, int? RawAmount)
            {
                this.ProductionDate = ProductionDate;
                this.ProductName = ProductName;
                this.Quantity = Quantity;
                this.DamagedQuantity = DamagedQuantity;
                this.Material_Name = Material_Name;
                this.RawAmount = RawAmount;

            }

            public DateTime? ProductionDate { get; set; }
            public string? ProductName { get; set; }
            public int? Quantity { get; set; }
            public int? DamagedQuantity { get; set; }
            public string? Material_Name { get; set; }
            public int? RawAmount { get; set; }



        }

        public static List<ProdctionDTO> GetAllRows( DateTime ValueSearch)
        {

            var SaleReports = new List<ProdctionDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetProductionReportsForMopile", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ValueSearch", ValueSearch);


                        connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                SaleReports.Add(new ProdctionDTO
                                (
                                reader.IsDBNull(reader.GetOrdinal("ProductionDate")) ? null :
                                reader.GetDateTime(reader.GetOrdinal("ProductionDate")),

                                reader.IsDBNull(reader.GetOrdinal("ProductName")) ? null :
                                reader.GetString(reader.GetOrdinal("ProductName")),

                                reader.IsDBNull(reader.GetOrdinal("Quantity")) ? null :
                                reader.GetInt32(reader.GetOrdinal("Quantity")),

                                reader.IsDBNull(reader.GetOrdinal("DamagedQuantity")) ? null :
                                reader.GetInt32(reader.GetOrdinal("DamagedQuantity")),

                                reader.IsDBNull(reader.GetOrdinal("Material_Name")) ? null :
                                reader.GetString(reader.GetOrdinal("Material_Name")),

                                reader.IsDBNull(reader.GetOrdinal("RawAmount")) ? null :
                                reader.GetInt32(reader.GetOrdinal("RawAmount"))
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

        public static bool AddNewRow(ProdctionDTO saleDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))

                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNeweProductionReportstForMobile", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductionDate", saleDTO.ProductionDate);
                        Command.Parameters.AddWithValue("@ProductName", saleDTO.ProductName);
                        Command.Parameters.AddWithValue("@Quantity", saleDTO.Quantity);
                        Command.Parameters.AddWithValue("@DamagedQuantity", saleDTO.DamagedQuantity);
                        Command.Parameters.AddWithValue("@Material_Name", saleDTO.Material_Name);
                        Command.Parameters.AddWithValue("@Amount", saleDTO.RawAmount);

                        connection.Open();
                        Command.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }
            return false;

        }
        public static bool CheckProduction_ReportssExiteForMobile(DateTime ValueSearch)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_CheckProduction_ReportssExiteForMobile", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ValueSearch", ValueSearch);

                        connection.Open();

                        SqlParameter returnParameter = new SqlParameter(@"ReturnVal", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);

                        Command.ExecuteNonQuery();

                        IsFound = ((int)returnParameter.Value == 1);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLoggingEvent.LoogingEvent("Error: " + ex.Message);
            }


            return IsFound;
        }

    }
}
