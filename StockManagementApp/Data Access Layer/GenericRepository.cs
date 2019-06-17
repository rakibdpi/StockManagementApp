﻿using System;
using System.Data.SqlClient;

namespace StockManagementApp.Data_Access_Layer
{
    public class GenericRepository
    {
        public static string ConnectionString()
        {
            var connectionString = @"Server=localhost; Database=StockManagementDB; Trusted_Connection= true";
            return connectionString;
        }
        public int ExecuteNonQuery(string query, string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var command = new SqlCommand(query, connection);
                var rowAffected = command.ExecuteNonQuery();
                connection.Close();
                return rowAffected;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SqlDataReader ExecuteReader(string query, string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SqlDataAdapter ExecuteAdapter(string query, string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var command = new SqlCommand(query, connection);
                var adapter = new SqlDataAdapter(command);
                return adapter;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}