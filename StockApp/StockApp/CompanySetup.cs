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
    public partial class CompanySetup : Form
    {
        public CompanySetup()
        {
            InitializeComponent();
        }
        Company company;
        CompanyManager _companyManager = new CompanyManager();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            company = new Company();
            if (isBlank(companyNameTextBox.Text)) { return; };
            company.companyName = companyNameTextBox.Text;

            bool isExist = _companyManager.IsExist(company);
            if (!isExist)
            {
                MessageBox.Show("Duplicate");
                return;
            }
            else
            {
                bool inserted = _companyManager.InsertCompany(company);
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

        private void CompanySetup_Load(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = _companyManager.Display();
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
    }
}
