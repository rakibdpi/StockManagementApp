using StockManagementApp.Data_Access_Layer;
using StockManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace StockManagementApp.Busness_Lagic_Layer
{
    public class CompanyManager
    {
        CompanyRepository _companyRepository = new CompanyRepository();

        public bool Save(Company company)
        {
            var save = _companyRepository.Save(company);
            return save;
        }
        public bool IsNameExist(string name)
        {
            bool isExist = false;
            var company = _companyRepository.GetByName(name);
            if (company != null)
                isExist = true;

            return isExist;
        }

        public bool Update(Company company)
        {
            var update = _companyRepository.Update(company);
            return update;
        }
        public List<Company> GetAll()
        {
            DataTable dataTable = _companyRepository.GetAll();
            var companies = new List<Company>();
            var serial = 1;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                var company = new Company();
                company.Id = Convert.ToInt32(dataRow["Id"]);
                company.SerialNo = serial;
                company.Name = dataRow["Name"].ToString();
                company.CreateBy = dataRow["CreateBy"].ToString();
                company.CreateDate = Convert.ToDateTime(dataRow["CreateDate"]);

                companies.Add(company);
                serial++;
            }

            return companies;
        }


    }
}