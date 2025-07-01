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

        public static List<SaleDto>? QuerySaleBetweenDates(string startDate, string endDate)
        {

            List<SaleDto> sales = new List<SaleDto>();

            try
            {
                string query = "SELECT* FROM PRODUCTSALES WHERE SALEDATE BETWEEN @STARTDATE AND @ENDDATE";

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@STARTDATE", startDate);
                    sqlCommand.Parameters.AddWithValue("@ENDDATE", endDate);

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
