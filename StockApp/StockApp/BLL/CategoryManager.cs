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
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();

        public bool InsertCategory(Category category)
        {
            return _categoryRepository.InsertCategory(category);
        }
        public DataTable Display()
        {
            return _categoryRepository.Display();
        }
        public bool IsExist(Category category)
        {
            return _categoryRepository.IsExist(category);
        }
    }
}
