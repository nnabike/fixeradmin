using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixer.Data
{
    public class DataLayer
    {
        string connectionString = ConfigurationManager.AppSettings["connectionString"];
        string orderField = ConfigurationManager.AppSettings["orderField"];
        int rowCount = Convert.ToInt32(ConfigurationManager.AppSettings["rowCount"]);

        public DataTable GetTableData(string tableName)
        {
            return GetPagedData(tableName, 1);
        }

        public DataTable GetPagedData(string tableName, int pageNumber)
        {
            DataTable dataTable = new DataTable(tableName);
            using (var connection = new SqlConnection(connectionString))
            {
                string commandString = $"Select * from {tableName} Order By {orderField} Offset {rowCount} * {pageNumber - 1} Rows Fetch Next {rowCount} Rows Only";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(commandString, connection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
        }

    }
}
