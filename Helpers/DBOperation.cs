using Microsoft.Data.SqlClient;
using Product_Sales_Reporting_Tool.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Sales_Reporting_Tool.Helpers
{
    public static class DBOperation
    {
        private static SqlConnection connection = new SqlConnection();
        private static string database = "SaleReport";

        public static bool ConnectDB()
        {
            try
            {

                string serverName = @"(localdb)\MSSQLLocalDB";
                string connectionString = $"Server={serverName};Database={database};Trusted_Connection=true;";
                connection = new SqlConnection(connectionString);
                connection.Open();

                FileOperation.AppendToLog("Connected to Database Successfully!");

                return true;
            } catch (Exception ex)
            {
                FileOperation.AppendToLog($"Failed to Connected: {ex.Message}!");
                return false;
            }

            
        }

        public static List<SaleDto>? QuerySaleBetweenDates(string startDate, string endDate, string filterName)
        {
            List<SaleDto> sales = new List<SaleDto>();

            try
            {
                //string query = "SELECT* FROM PRODUCTSALES WHERE SALEDATE BETWEEN @STARTDATE AND @ENDDATE";
                //use storedprocedure
                string query = "QuerySaleBetweenDates";

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@STARTDATE", System.Data.SqlDbType.Date).Value = startDate;
                    sqlCommand.Parameters.Add("@ENDDATE", System.Data.SqlDbType.Date).Value = endDate;
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        sales.Add(new SaleDto
                        {
                            ProductCode = reader.GetString(1),
                            ProductName = reader.GetString(2),
                            Quantity = reader.GetInt32(3),
                            UnitPrice = reader.GetDecimal(4),
                            SaleDate = reader.GetDateTime(5)
                        });
                    }
                    reader.Close();
                    FileOperation.AppendToLog("Get all Sales: Query executed successfully!");

                    //filter by productname
                    if (sales.Count > 0 && filterName != string.Empty)
                    {
                        var filterReport = sales.Where(sale => sale.ProductName.Contains(filterName, StringComparison.OrdinalIgnoreCase)).ToList();
                        return filterReport;
                    }
                }

                return sales;
            }
            catch (Exception ex)
            {
                FileOperation.AppendToLog($"Failed to query all reports: {ex.Message}!");
                return null;
            }
        }
    }
}
