using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockApp.Models;
using StockApp.BLL;

namespace StockApp
{
    public partial class CategorySetup : Form
    {
        public CategorySetup()
        {
            InitializeComponent();
        }
        Category category;
        CategoryManager _categoryManager = new CategoryManager();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            category = new Category();
            if (isBlank(categoryNameTextBox.Text)) { return; };
            category.categoryName = categoryNameTextBox.Text;

            bool isExist = _categoryManager.IsExist(category);
            if (!isExist)
            {
                MessageBox.Show("Duplicate");
                return;
            }
            else
            {
                bool inserted = _categoryManager.InsertCategory(category);
                if (inserted)
                {
                    MessageBox.Show("Inserted");
                }
                else
                {
                    MessageBox.Show("Not inserted");
                }
            }
        }

        private bool isBlank(String input)
        {
            bool isNull = false;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please fill out all fields!!!");
                isNull = true;
            }
            return isNull;
        }

        private void CategorySetup_Load_1(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = _categoryManager.Display();

        }
    }
}
