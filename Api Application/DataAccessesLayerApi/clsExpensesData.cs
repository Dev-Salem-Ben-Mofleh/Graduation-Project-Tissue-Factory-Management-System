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
    public class clsExpensesData
    {
        public class ExpDTO
        {
            public ExpDTO(DateTime? ExpenseDate, int? CountBills, decimal? Total, decimal? Amount, string? Name)
            {
                this.ExpenseDate = ExpenseDate;
                this.CountBills = CountBills;
                this.Total = Total;
                this.Amount = Amount;
                this.Name = Name;

            }

            public DateTime? ExpenseDate { get; set; }
            public int? CountBills { get; set; }
            public decimal? Total { get; set; }
            public decimal? Amount { get; set; }
            public string? Name { get; set; }

        }

        public static List<ExpDTO> GetAllRows( DateTime ValueSearch)
        {

            var SaleReports = new List<ExpDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetExpensReportsForMopile", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ValueSearch", ValueSearch);


                        connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                SaleReports.Add(new ExpDTO
                                (
                                reader.IsDBNull(reader.GetOrdinal("ExpenseDate")) ? null :
                                reader.GetDateTime(reader.GetOrdinal("ExpenseDate")),

                                reader.IsDBNull(reader.GetOrdinal("CountBills")) ? null :
                                reader.GetInt32(reader.GetOrdinal("CountBills")),

                                reader.IsDBNull(reader.GetOrdinal("Total")) ? null :
                                reader.GetDecimal(reader.GetOrdinal("Total")),

                                reader.IsDBNull(reader.GetOrdinal("Amount")) ? null :
                                reader.GetDecimal(reader.GetOrdinal("Amount")),

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
        public static bool AddNewRow(ExpDTO saleDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))

                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewExpenseReporttForMobile", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ExpenseDate", saleDTO.ExpenseDate);
                        Command.Parameters.AddWithValue("@Total", saleDTO.Total);
                        Command.Parameters.AddWithValue("@CountBills", saleDTO.CountBills);
                        Command.Parameters.AddWithValue("@Amount", saleDTO.Amount);
                        Command.Parameters.AddWithValue("@Name", saleDTO.Name);

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
        public static bool CheckExpensReportIsExiteForMobile(DateTime ValueSearch)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAccesseSetting.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_CheckExpensReportIsExiteForMobile", connection))
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
