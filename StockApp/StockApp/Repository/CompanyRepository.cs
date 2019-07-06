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
    public class CompanyRepository
    {
        string connectionString = @"Server=DESKTOP-IOCVPPE\SQLEXPRESS; Database=StockManagementDB; Integrated Security=true";
        Company company = new Company();
        private SqlConnection sqlConnection;
        private string commandString;
        private SqlCommand sqlCommand;

        public bool InsertCompany(Company company)
        {
            sqlConnection = new SqlConnection();
            commandString = @"insert into Companies values ('"+company.companyName+"')";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            if (isExecuted>0)
            { return true; }
            else return false;
        }
        public DataTable Display()
        {
            commandString = @"select * from Companies";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public bool IsExist(Company company)
        {
            sqlConnection = new SqlConnection(connectionString);
            bool isExist = false;
            commandString = @"SELECT count(*) FROM Companies WHERE CompanyName='" + company.companyName + "'";
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
