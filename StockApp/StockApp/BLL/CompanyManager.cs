using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockApp.Repository;
using StockApp.Models;
using System.Data;

namespace StockApp.BLL
{
    public class CompanyManager
    {
        CompanyRepository _companyRepository = new CompanyRepository();

        public bool InsertCompany(Company company)
        {
            return _companyRepository.InsertCompany(company);
        }
        public DataTable Display()
        {
            return _companyRepository.Display();
        }
        public bool IsExist(Company company)
        {
            return _companyRepository.IsExist(company);
        }
    }
}
