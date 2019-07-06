namespace StockApp
{
    partial class CategorySetup
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(187, 97);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(187, 51);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryNameTextBox.TabIndex = 2;
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.AutoGenerateColumns = false;
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.iDDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn});
            this.displayDataGridView.DataSource = this.categoryBindingSource;
            this.displayDataGridView.Location = new System.Drawing.Point(90, 144);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.Size = new System.Drawing.Size(240, 150);
            this.displayDataGridView.TabIndex = 3;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "ID";
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Category Name";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockApp.Models.Category);
            // 
            // CategorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 320);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Name = "CategorySetup";
            this.Text = "Category Setup";
            this.Load += new System.EventHandler(this.CategorySetup_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}