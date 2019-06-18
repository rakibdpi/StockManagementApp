namespace StockManagementApp.UserInterfaces
{
    partial class ViewDatesUI
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
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.fromDateTextBox = new System.Windows.Forms.TextBox();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.toDateTextBox = new System.Windows.Forms.TextBox();
            this.soldRadioButton = new System.Windows.Forms.RadioButton();
            this.damagedRadioButton = new System.Windows.Forms.RadioButton();
            this.lostRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.viewDateDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewDateDataGridView);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.lostRadioButton);
            this.groupBox1.Controls.Add(this.damagedRadioButton);
            this.groupBox1.Controls.Add(this.soldRadioButton);
            this.groupBox1.Controls.Add(this.toDateTextBox);
            this.groupBox1.Controls.Add(this.toDateLabel);
            this.groupBox1.Controls.Add(this.fromDateTextBox);
            this.groupBox1.Controls.Add(this.fromDateLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Between Two Dates Report";
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateLabel.Location = new System.Drawing.Point(168, 57);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(108, 24);
            this.fromDateLabel.TabIndex = 0;
            this.fromDateLabel.Text = "From Date :";
            // 
            // fromDateTextBox
            // 
            this.fromDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateTextBox.Location = new System.Drawing.Point(292, 57);
            this.fromDateTextBox.Name = "fromDateTextBox";
            this.fromDateTextBox.Size = new System.Drawing.Size(135, 29);
            this.fromDateTextBox.TabIndex = 1;
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateLabel.Location = new System.Drawing.Point(190, 99);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(86, 24);
            this.toDateLabel.TabIndex = 0;
            this.toDateLabel.Text = "To Date :";
            // 
            // toDateTextBox
            // 
            this.toDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateTextBox.Location = new System.Drawing.Point(292, 94);
            this.toDateTextBox.Name = "toDateTextBox";
            this.toDateTextBox.Size = new System.Drawing.Size(135, 29);
            this.toDateTextBox.TabIndex = 1;
            // 
            // soldRadioButton
            // 
            this.soldRadioButton.AutoSize = true;
            this.soldRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldRadioButton.Location = new System.Drawing.Point(164, 166);
            this.soldRadioButton.Name = "soldRadioButton";
            this.soldRadioButton.Size = new System.Drawing.Size(66, 28);
            this.soldRadioButton.TabIndex = 2;
            this.soldRadioButton.TabStop = true;
            this.soldRadioButton.Text = "Sold";
            this.soldRadioButton.UseVisualStyleBackColor = true;
            // 
            // damagedRadioButton
            // 
            this.damagedRadioButton.AutoSize = true;
            this.damagedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damagedRadioButton.Location = new System.Drawing.Point(262, 166);
            this.damagedRadioButton.Name = "damagedRadioButton";
            this.damagedRadioButton.Size = new System.Drawing.Size(110, 28);
            this.damagedRadioButton.TabIndex = 2;
            this.damagedRadioButton.TabStop = true;
            this.damagedRadioButton.Text = "Damaged";
            this.damagedRadioButton.UseVisualStyleBackColor = true;
            // 
            // lostRadioButton
            // 
            this.lostRadioButton.AutoSize = true;
            this.lostRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostRadioButton.Location = new System.Drawing.Point(389, 166);
            this.lostRadioButton.Name = "lostRadioButton";
            this.lostRadioButton.Size = new System.Drawing.Size(62, 28);
            this.lostRadioButton.TabIndex = 2;
            this.lostRadioButton.TabStop = true;
            this.lostRadioButton.Text = "Lost";
            this.lostRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(476, 166);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(87, 36);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // viewDateDataGridView
            // 
            this.viewDateDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.viewDateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDateDataGridView.Location = new System.Drawing.Point(67, 214);
            this.viewDateDataGridView.Name = "viewDateDataGridView";
            this.viewDateDataGridView.Size = new System.Drawing.Size(538, 166);
            this.viewDateDataGridView.TabIndex = 8;
            // 
            // ViewDatesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(783, 508);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewDatesUI";
            this.Text = "View Between Two Dates Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDateDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton lostRadioButton;
        private System.Windows.Forms.RadioButton damagedRadioButton;
        private System.Windows.Forms.RadioButton soldRadioButton;
        private System.Windows.Forms.TextBox toDateTextBox;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.TextBox fromDateTextBox;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView viewDateDataGridView;
    }
}