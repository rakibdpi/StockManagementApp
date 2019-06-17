﻿using StockManagementApp.Models;
using System;
using System.Data;

namespace StockManagementApp.Data_Access_Layer
{
    public class CompanyRepository
    {
        private readonly string _connectionString = GenericRepository.ConnectionString();
        readonly GenericRepository _genericRepository = new GenericRepository();

        public bool Save(Company company)
        {
            try
            {
                var query = "INSERT INTO Companies VALUES('" + company.Name + "', '" + company.CreateBy + "','" +
                            company.CreateDate + "')";
                var rowAffected = _genericRepository.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Company GetByName(string name)
        {
            try
            {
                var query = "SELECT * FROM Companies WHERE Name='" + name + "'";
                var reader = _genericRepository.ExecuteReader(query, _connectionString);
                if (reader.HasRows)
                {
                    reader.Read();
                    var company = new Company()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        CreateBy = reader["CreateBy"].ToString()
                    };
                    return company;
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable GetAll()
        {
            try
            {
                string query = "SELECT * FROM Companies";
                var dataAdapter = _genericRepository.ExecuteAdapter(query, _connectionString);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Update(Company company)
        {
            try
            {
                var query = "UPDATE Companies SET Name='" + company.Name + "', UpdateBy='" + company.UpdateBy + "', UpdateDate='" + company.UpdateDate + "'" +
                            " WHERE Id='" + company.Id + "'";
                var rowAffected = _genericRepository.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}