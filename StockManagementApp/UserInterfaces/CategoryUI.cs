using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementApp.Busness_Lagic_Layer;
using StockManagementApp.Data_Access_Layer;
using StockManagementApp.Models;

namespace StockManagementApp.UserInterfaces
{
    
    public partial class CategoryUI : Form
    {
        CategoryManager _categoryManager=new CategoryManager();
        public CategoryUI()
        {
            InitializeComponent();
        }

        private void CategoryUI_Load(object sender, EventArgs e)
        {
           Clear();
        }

        public Category InputText()
        {
            Category category = new Category();
            category.Name = nameTextBox.Text;
            category.LoginBy = "Rid";
            return category;

        }

        public void Clear()
        {
            nameTextBox.Text = "";
           
            idLavel.Text = "";
            CategoryDataGridView.DataSource = _categoryManager.GridViewData();
        }

      
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idLavel.Text))
                {
                    Category category = InputText();
                    var success = _categoryManager.Save(category);
                    if (success)
                    {
                        messageLabel.Text = "Save Success";
                        Clear();
                    }
                    else
                    {
                        messageLabel.Text = "Save Fail";
                        Clear();
                    }
                }
                else
                {
                    Category category = InputText();
                    int Id = Convert.ToInt32(idLavel.Text);
                    var success = _categoryManager.Update(category,Id);
                    if (success)
                    {
                        messageLabel.Text = "Update Success";
                        Clear();
                    }
                    else
                    {
                        messageLabel.Text = "Update Fail";
                        Clear();
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            messageLabel.Text = "";
        }



        private void CategoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.CategoryDataGridView.Rows[e.RowIndex];
                nameTextBox.Text = row.Cells["Name"].Value.ToString();
                idLavel.Text = row.Cells["Id"].Value.ToString();
            }
        }

      
    }
}
