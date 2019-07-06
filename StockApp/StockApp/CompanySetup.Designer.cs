namespace StockApp
{
    partial class CompanySetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(105, 32);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyNameTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(130, 89);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.AutoGenerateColumns = false;
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.companyNameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.displayDataGridView.DataSource = this.companyBindingSource2;
            this.displayDataGridView.Location = new System.Drawing.Point(40, 148);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.Size = new System.Drawing.Size(348, 150);
            this.displayDataGridView.TabIndex = 3;
  //          this.displayDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.displayDataGridView_RowPostPaint);
            // 
            // SL
            // 
            this.SL.DataPropertyName = "ID";
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "companyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // companyBindingSource2
            // 
            this.companyBindingSource2.DataSource = typeof(StockApp.Models.Company);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockApp.Models.Company);
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataSource = typeof(StockApp.Models.Company);
            // 
            // CompanySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 325);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CompanySetup";
            this.Text = "Company Setup";
            this.Load += new System.EventHandler(this.CompanySetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.BindingSource companyBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}

