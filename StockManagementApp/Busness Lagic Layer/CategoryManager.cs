﻿using StockManagementApp.Data_Access_Layer;
using StockManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace StockManagementApp.Busness_Lagic_Layer
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();

        public bool Save(Category category)
        {
            var save = _categoryRepository.Save(category);
            return save;
        }

        public bool IsNameExist(string name)
        {
            var isExist = false;
            var category = _categoryRepository.GetByName(name);
            if (category != null)
                isExist = true;
            return isExist;
        }

        public List<Category> GetAll()
        {
            try
            {
                var dataTable = _categoryRepository.GetAll();
                List<Category> categoryList = new List<Category>();
                int serialNo = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    Category category = new Category();
                    category.Serial = serialNo;
                    category.Id = Convert.ToInt32(row["Id"]);
                    category.Name = row["Name"].ToString();
                    categoryList.Add(category);
                    serialNo++;
                }

                return categoryList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable GridViewData()
        {
            var dataTable = _categoryRepository.GetAll();
            return dataTable;
        }
        public bool Update(Category category, int id)
        {
            var update = _categoryRepository.Update(category,id);
            return update;
        }
    }
}