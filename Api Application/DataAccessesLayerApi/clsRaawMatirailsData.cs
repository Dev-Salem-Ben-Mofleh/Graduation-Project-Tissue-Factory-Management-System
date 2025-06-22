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
    public class clsRaawMatirailsData
    {
        public class RawDTO
        {


            public RawDTO(DateTime? ProductionDate,
                string? Material_Name, int? RawAmount,int? Quantity)
            {
                this.ProductionDate = ProductionDate;
                this.Quantity = Quantity;
                this.Material_Name = Material_Name;
                this.RawAmount = RawAmount;

            }

            public DateTime? ProductionDate { get; set; }
            public string? Material_Name { get; set; }
            public int? RawAmount { get; set; }
            public int? Quantity { get; set; }



        }

        public static List<RawDTO> GetAllRows(DateTime ValueSearch)
        {

            var SaleReports = new List<RawDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetRawMatiarlsReportsForMopile", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ValueSearch", ValueSearch);


                        connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                SaleReports.Add(new RawDTO
                                (
                                reader.IsDBNull(reader.GetOrdinal("ProductionDate")) ? null :
                                reader.GetDateTime(reader.GetOrdinal("ProductionDate")),

                                reader.IsDBNull(reader.GetOrdinal("Material_Name")) ? null :
                                reader.GetString(reader.GetOrdinal("Material_Name")),

                                reader.IsDBNull(reader.GetOrdinal("RawAmount")) ? null :
                                reader.GetInt32(reader.GetOrdinal("RawAmount")),

                                 reader.IsDBNull(reader.GetOrdinal("Quantity")) ? null :
                                reader.GetInt32(reader.GetOrdinal("Quantity"))
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
        public static bool AddNewRow(RawDTO saleDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))

                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNeweRawMatrialsReportstForMobile", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductionDate", saleDTO.ProductionDate);
                        Command.Parameters.AddWithValue("@Quantity", saleDTO.Quantity);
                        Command.Parameters.AddWithValue("@Material_Name", saleDTO.Material_Name);
                        Command.Parameters.AddWithValue("@RawAmount", saleDTO.RawAmount);

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
        public static bool CheckRawMatrials_ReportsExiteForMobile(DateTime ValueSearch)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_CheckRawMatrials_ReportsExiteForMobile", connection))
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
