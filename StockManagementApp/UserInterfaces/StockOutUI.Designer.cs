namespace StockManagementApp.UserInterfaces
{
    partial class StockOutUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stockOutDataGridView = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.stockInQuantityLabel = new System.Windows.Forms.Label();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.availableQuantityLabel = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.reorderLevelLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.SellButton = new System.Windows.Forms.Button();
            this.LostButton = new System.Windows.Forms.Button();
            this.DamageButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stockOutDataGridView);
            this.groupBox1.Controls.Add(this.DamageButton);
            this.groupBox1.Controls.Add(this.LostButton);
            this.groupBox1.Controls.Add(this.SellButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.availableQuantityTextBox);
            this.groupBox1.Controls.Add(this.stockInQuantityLabel);
            this.groupBox1.Controls.Add(this.reorderLevelTextBox);
            this.groupBox1.Controls.Add(this.availableQuantityLabel);
            this.groupBox1.Controls.Add(this.itemComboBox);
            this.groupBox1.Controls.Add(this.reorderLevelLabel);
            this.groupBox1.Controls.Add(this.itemLabel);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.categoryLabel);
            this.groupBox1.Controls.Add(this.companyComboBox);
            this.groupBox1.Controls.Add(this.companyLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(92, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 536);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Out";
            // 
            // stockOutDataGridView
            // 
            this.stockOutDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stockOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockOutDataGridView.Location = new System.Drawing.Point(79, 287);
            this.stockOutDataGridView.Name = "stockOutDataGridView";
            this.stockOutDataGridView.Size = new System.Drawing.Size(495, 180);
            this.stockOutDataGridView.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(382, 248);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(86, 33);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(295, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 29);
            this.textBox1.TabIndex = 2;
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQuantityTextBox.Location = new System.Drawing.Point(295, 178);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.Size = new System.Drawing.Size(173, 29);
            this.availableQuantityTextBox.TabIndex = 2;
            // 
            // stockInQuantityLabel
            // 
            this.stockInQuantityLabel.AutoSize = true;
            this.stockInQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInQuantityLabel.Location = new System.Drawing.Point(107, 213);
            this.stockInQuantityLabel.Name = "stockInQuantityLabel";
            this.stockInQuantityLabel.Size = new System.Drawing.Size(159, 24);
            this.stockInQuantityLabel.TabIndex = 0;
            this.stockInQuantityLabel.Text = "Stock In Quantity :";
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLevelTextBox.Location = new System.Drawing.Point(295, 143);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(173, 29);
            this.reorderLevelTextBox.TabIndex = 2;
            // 
            // availableQuantityLabel
            // 
            this.availableQuantityLabel.AutoSize = true;
            this.availableQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQuantityLabel.Location = new System.Drawing.Point(107, 178);
            this.availableQuantityLabel.Name = "availableQuantityLabel";
            this.availableQuantityLabel.Size = new System.Drawing.Size(169, 24);
            this.availableQuantityLabel.TabIndex = 0;
            this.availableQuantityLabel.Text = "Available Quantity :";
            // 
            // itemComboBox
            // 
            this.itemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(295, 105);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(173, 32);
            this.itemComboBox.TabIndex = 1;
            // 
            // reorderLevelLabel
            // 
            this.reorderLevelLabel.AutoSize = true;
            this.reorderLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLevelLabel.Location = new System.Drawing.Point(132, 146);
            this.reorderLevelLabel.Name = "reorderLevelLabel";
            this.reorderLevelLabel.Size = new System.Drawing.Size(144, 24);
            this.reorderLevelLabel.TabIndex = 0;
            this.reorderLevelLabel.Text = " Reorder Level :";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(221, 105);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(55, 24);
            this.itemLabel.TabIndex = 0;
            this.itemLabel.Text = "Item :";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(295, 67);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(173, 32);
            this.categoryComboBox.TabIndex = 1;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(181, 70);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(95, 24);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category :";
            // 
            // companyComboBox
            // 
            this.companyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(295, 29);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(173, 32);
            this.companyComboBox.TabIndex = 1;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.Location = new System.Drawing.Point(175, 29);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(101, 24);
            this.companyLabel.TabIndex = 0;
            this.companyLabel.Text = "Company :";
            // 
            // SellButton
            // 
            this.SellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellButton.Location = new System.Drawing.Point(269, 473);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(86, 33);
            this.SellButton.TabIndex = 3;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            // 
            // LostButton
            // 
            this.LostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LostButton.Location = new System.Drawing.Point(382, 473);
            this.LostButton.Name = "LostButton";
            this.LostButton.Size = new System.Drawing.Size(86, 33);
            this.LostButton.TabIndex = 3;
            this.LostButton.Text = "Lost";
            this.LostButton.UseVisualStyleBackColor = true;
            // 
            // DamageButton
            // 
            this.DamageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageButton.Location = new System.Drawing.Point(488, 473);
            this.DamageButton.Name = "DamageButton";
            this.DamageButton.Size = new System.Drawing.Size(86, 33);
            this.DamageButton.TabIndex = 3;
            this.DamageButton.Text = "Damage";
            this.DamageButton.UseVisualStyleBackColor = true;
            // 
            // StockOutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(843, 570);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockOutUI";
            this.Text = "Stock Out ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView stockOutDataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.Label stockInQuantityLabel;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.Label availableQuantityLabel;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label reorderLevelLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Button DamageButton;
        private System.Windows.Forms.Button LostButton;
        private System.Windows.Forms.Button SellButton;
    }
}