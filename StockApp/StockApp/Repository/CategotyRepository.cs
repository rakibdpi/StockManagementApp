using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StockApp.Models;

namespace StockApp.Repository
{
    public class CategoryRepository
    {
        string connectionString = @"Server=DESKTOP-IOCVPPE\SQLEXPRESS; Database=StockManagementDB; Integrated Security=true";
        Category category = new Category();
        private SqlConnection sqlConnection;
        private string commandString;
        private SqlCommand sqlCommand;

        public bool InsertCategory(Category category)
        {
            sqlConnection = new SqlConnection();
            commandString = @"insert into Categories values ('" + category.categoryName + "')";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (isExecuted > 0)
            { return true; }
            else return false;
        }
        public DataTable Display()
        {
            commandString = @"select * from Categories";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public bool IsExist(Category category)
        {
            sqlConnection = new SqlConnection(connectionString);
            bool isExist = false;
            commandString = @"SELECT count(*) FROM Categories WHERE CategoryName='" + category.categoryName + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted;
            isExecuted = (int)sqlCommand.ExecuteScalar();
            if (isExecuted == 0) { isExist = true; }
            sqlConnection.Close();
            return isExist;
        }
    }
}
