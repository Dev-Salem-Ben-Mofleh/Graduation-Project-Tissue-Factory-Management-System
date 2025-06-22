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
    public class clsElectrictyData
    {
        public class ElectDTO
        {
            public ElectDTO(DateTime? date,
                string? TypeOf, int? Total, int? Quantity)
            {
                this.date = date;
                this.Quantity = Quantity;
                this.TypeOf = TypeOf;
                this.Total = Total;

            }

            public DateTime? date { get; set; }
            public string? TypeOf { get; set; }
            public int? Total { get; set; }
            public int? Quantity { get; set; }



        }

        public static List<ElectDTO> GetAllRows( DateTime ValueSearch)
        {

            var SaleReports = new List<ElectDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetElectrictyReportsForMopile", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ValueSearch", ValueSearch);


                        connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                SaleReports.Add(new ElectDTO
                                (
                                reader.IsDBNull(reader.GetOrdinal("date")) ? null :
                                reader.GetDateTime(reader.GetOrdinal("date")),

                                reader.IsDBNull(reader.GetOrdinal("TypeOf")) ? null :
                                reader.GetString(reader.GetOrdinal("TypeOf")),

                                reader.IsDBNull(reader.GetOrdinal("Total")) ? null :
                                reader.GetInt32(reader.GetOrdinal("Total")),

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

        public static bool AddNewRow(ElectDTO saleDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))

                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNeweElectrictyReportstForMobile", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@date", saleDTO.date);
                        Command.Parameters.AddWithValue("@TypeOf", saleDTO.TypeOf);
                        Command.Parameters.AddWithValue("@Quantity", saleDTO.Quantity);
                        Command.Parameters.AddWithValue("@Total", saleDTO.Total);

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

        public static bool CheckElectricty_ReportsExiteForMobile(DateTime ValueSearch)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_CheckElectricty_ReportsExiteForMobile", connection))
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
