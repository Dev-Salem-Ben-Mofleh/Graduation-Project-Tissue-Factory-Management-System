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
    public class clsDataPurchases
    {
        public class PurchDTO
        {
            public PurchDTO(DateTime? SaleDate, int? CountBills, decimal? Total, string? RawMatiral, string? Name, decimal? PaidBill, decimal? NotPaidBill)
            {
                this.SaleDate = SaleDate;
                this.CountBills = CountBills;
                this.Total = Total;
                this.RawMatiral = RawMatiral;
                this.Name = Name;
                this.PaidBill = PaidBill;
                this.NotPaidBill = NotPaidBill;

            }

            public DateTime? SaleDate { get; set; }
            public int? CountBills { get; set; }
            public decimal? Total { get; set; }
            public string? RawMatiral { get; set; }
            public string? Name { get; set; }
            public decimal? PaidBill { get; set; }
            public decimal? NotPaidBill { get; set; }



        }

        public static List<PurchDTO> GetAllRows( DateTime ValueSearch)
        {

            var SaleReports = new List<PurchDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPrunchesReportsForMopile", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ValueSearch", ValueSearch);


                        connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                SaleReports.Add(new PurchDTO
                                (
                                reader.IsDBNull(reader.GetOrdinal("SaleDate")) ? null :
                                reader.GetDateTime(reader.GetOrdinal("SaleDate")),

                                reader.IsDBNull(reader.GetOrdinal("CountBills")) ? null :
                                reader.GetInt32(reader.GetOrdinal("CountBills")),

                                reader.IsDBNull(reader.GetOrdinal("Total")) ? null :
                                reader.GetDecimal(reader.GetOrdinal("Total")),

                                reader.IsDBNull(reader.GetOrdinal("RawMatiral")) ? null :
                                reader.GetString(reader.GetOrdinal("RawMatiral")),

                                reader.IsDBNull(reader.GetOrdinal("Name")) ? null :
                                reader.GetString(reader.GetOrdinal("Name")),

                                reader.IsDBNull(reader.GetOrdinal("PaidBill")) ? null :
                                reader.GetDecimal(reader.GetOrdinal("PaidBill")),

                                reader.IsDBNull(reader.GetOrdinal("NotPaidBill")) ? null :
                                reader.GetDecimal(reader.GetOrdinal("NotPaidBill"))
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

        public static bool AddNewRow(PurchDTO saleDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))

                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewPurchaseReporttForMobile", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@SaleDate", saleDTO.SaleDate);
                        Command.Parameters.AddWithValue("@Total", saleDTO.Total);
                        Command.Parameters.AddWithValue("@CountBills", saleDTO.CountBills);
                        Command.Parameters.AddWithValue("@RawMatiral", saleDTO.RawMatiral);
                        Command.Parameters.AddWithValue("@Name", saleDTO.Name);
                        Command.Parameters.AddWithValue("@PaidBill", saleDTO.PaidBill);
                        Command.Parameters.AddWithValue("@NotPaidBill", saleDTO.NotPaidBill);

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
        public static bool CheckPurches_ReportsExiteForMobile(DateTime ValueSearch)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_CheckPurches_ReportsExiteForMobile", connection))
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
