
namespace OnionArchitecture.WinFormsUI
{
    partial class Form1
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
            this.add_Product_Parts_OnProduct_View = new System.Windows.Forms.DataGridView();
            this.add_Product_Associated_Parts_View = new System.Windows.Forms.DataGridView();
            this.add_Product_Price_Field = new System.Windows.Forms.NumericUpDown();
            this.add_Product_Min_Field = new System.Windows.Forms.NumericUpDown();
            this.add_Product_Max_Field = new System.Windows.Forms.NumericUpDown();
            this.add_Product_Inventory_Field = new System.Windows.Forms.NumericUpDown();
            this.add_Product_Name_Field = new System.Windows.Forms.TextBox();
            this.add_Product_ID_Field = new System.Windows.Forms.TextBox();
            this.add_Product_Search_Field = new System.Windows.Forms.TextBox();
            this.add_Product_Search_Button = new System.Windows.Forms.Button();
            this.add_Product_Add_Part_Procuct_Button = new System.Windows.Forms.Button();
            this.add_Product_Delete_Button = new System.Windows.Forms.Button();
            this.add_Product_Save_Button = new System.Windows.Forms.Button();
            this.add_Product_Cancel_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_Product_ID = new System.Windows.Forms.Label();
            this.add_Product_Name = new System.Windows.Forms.Label();
            this.add_Product_Inventory = new System.Windows.Forms.Label();
            this.add_Product_Price = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Parts_OnProduct_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Associated_Parts_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Price_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Min_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Max_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Inventory_Field)).BeginInit();
            this.SuspendLayout();
            // 
            // add_Product_Parts_OnProduct_View
            // 
            this.add_Product_Parts_OnProduct_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.add_Product_Parts_OnProduct_View.Location = new System.Drawing.Point(417, 99);
            this.add_Product_Parts_OnProduct_View.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Parts_OnProduct_View.Name = "add_Product_Parts_OnProduct_View";
            this.add_Product_Parts_OnProduct_View.RowHeadersWidth = 82;
            this.add_Product_Parts_OnProduct_View.RowTemplate.Height = 41;
            this.add_Product_Parts_OnProduct_View.Size = new System.Drawing.Size(417, 150);
            this.add_Product_Parts_OnProduct_View.TabIndex = 8;
            this.add_Product_Parts_OnProduct_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // add_Product_Associated_Parts_View
            // 
            this.add_Product_Associated_Parts_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.add_Product_Associated_Parts_View.Location = new System.Drawing.Point(417, 308);
            this.add_Product_Associated_Parts_View.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Associated_Parts_View.Name = "add_Product_Associated_Parts_View";
            this.add_Product_Associated_Parts_View.RowHeadersWidth = 82;
            this.add_Product_Associated_Parts_View.RowTemplate.Height = 41;
            this.add_Product_Associated_Parts_View.Size = new System.Drawing.Size(417, 148);
            this.add_Product_Associated_Parts_View.TabIndex = 10;
            // 
            // add_Product_Price_Field
            // 
            this.add_Product_Price_Field.DecimalPlaces = 2;
            this.add_Product_Price_Field.Location = new System.Drawing.Point(191, 334);
            this.add_Product_Price_Field.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Price_Field.Name = "add_Product_Price_Field";
            this.add_Product_Price_Field.Size = new System.Drawing.Size(108, 23);
            this.add_Product_Price_Field.TabIndex = 3;
            // 
            // add_Product_Min_Field
            // 
            this.add_Product_Min_Field.Location = new System.Drawing.Point(276, 372);
            this.add_Product_Min_Field.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Min_Field.Name = "add_Product_Min_Field";
            this.add_Product_Min_Field.Size = new System.Drawing.Size(65, 23);
            this.add_Product_Min_Field.TabIndex = 5;
            // 
            // add_Product_Max_Field
            // 
            this.add_Product_Max_Field.Location = new System.Drawing.Point(146, 375);
            this.add_Product_Max_Field.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Max_Field.Name = "add_Product_Max_Field";
            this.add_Product_Max_Field.Size = new System.Drawing.Size(65, 23);
            this.add_Product_Max_Field.TabIndex = 4;
            // 
            // add_Product_Inventory_Field
            // 
            this.add_Product_Inventory_Field.Location = new System.Drawing.Point(191, 296);
            this.add_Product_Inventory_Field.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Inventory_Field.Name = "add_Product_Inventory_Field";
            this.add_Product_Inventory_Field.Size = new System.Drawing.Size(108, 23);
            this.add_Product_Inventory_Field.TabIndex = 2;
            // 
            // add_Product_Name_Field
            // 
            this.add_Product_Name_Field.Location = new System.Drawing.Point(191, 260);
            this.add_Product_Name_Field.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Name_Field.Name = "add_Product_Name_Field";
            this.add_Product_Name_Field.Size = new System.Drawing.Size(110, 23);
            this.add_Product_Name_Field.TabIndex = 1;
            // 
            // add_Product_ID_Field
            // 
            this.add_Product_ID_Field.Location = new System.Drawing.Point(191, 218);
            this.add_Product_ID_Field.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_ID_Field.Name = "add_Product_ID_Field";
            this.add_Product_ID_Field.ReadOnly = true;
            this.add_Product_ID_Field.Size = new System.Drawing.Size(110, 23);
            this.add_Product_ID_Field.TabIndex = 0;
            // 
            // add_Product_Search_Field
            // 
            this.add_Product_Search_Field.Location = new System.Drawing.Point(727, 63);
            this.add_Product_Search_Field.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Search_Field.Name = "add_Product_Search_Field";
            this.add_Product_Search_Field.Size = new System.Drawing.Size(110, 23);
            this.add_Product_Search_Field.TabIndex = 7;
            // 
            // add_Product_Search_Button
            // 
            this.add_Product_Search_Button.Location = new System.Drawing.Point(648, 63);
            this.add_Product_Search_Button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Search_Button.Name = "add_Product_Search_Button";
            this.add_Product_Search_Button.Size = new System.Drawing.Size(51, 22);
            this.add_Product_Search_Button.TabIndex = 6;
            this.add_Product_Search_Button.Text = "Search";
            this.add_Product_Search_Button.UseVisualStyleBackColor = true;
            // 
            // add_Product_Add_Part_Procuct_Button
            // 
            this.add_Product_Add_Part_Procuct_Button.Location = new System.Drawing.Point(784, 260);
            this.add_Product_Add_Part_Procuct_Button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Add_Part_Procuct_Button.Name = "add_Product_Add_Part_Procuct_Button";
            this.add_Product_Add_Part_Procuct_Button.Size = new System.Drawing.Size(51, 22);
            this.add_Product_Add_Part_Procuct_Button.TabIndex = 9;
            this.add_Product_Add_Part_Procuct_Button.Text = "Add";
            this.add_Product_Add_Part_Procuct_Button.UseVisualStyleBackColor = true;
            this.add_Product_Add_Part_Procuct_Button.Click += new System.EventHandler(this.add_Product_Add_Part_Procuct_Button_Click);
            // 
            // add_Product_Delete_Button
            // 
            this.add_Product_Delete_Button.Location = new System.Drawing.Point(784, 472);
            this.add_Product_Delete_Button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Delete_Button.Name = "add_Product_Delete_Button";
            this.add_Product_Delete_Button.Size = new System.Drawing.Size(51, 22);
            this.add_Product_Delete_Button.TabIndex = 11;
            this.add_Product_Delete_Button.Text = "Delete";
            this.add_Product_Delete_Button.UseVisualStyleBackColor = true;
            this.add_Product_Delete_Button.Click += new System.EventHandler(this.add_Product_Delete_Button_Click);
            // 
            // add_Product_Save_Button
            // 
            this.add_Product_Save_Button.Location = new System.Drawing.Point(713, 510);
            this.add_Product_Save_Button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Save_Button.Name = "add_Product_Save_Button";
            this.add_Product_Save_Button.Size = new System.Drawing.Size(51, 22);
            this.add_Product_Save_Button.TabIndex = 12;
            this.add_Product_Save_Button.Text = "Save";
            this.add_Product_Save_Button.UseVisualStyleBackColor = true;
            this.add_Product_Save_Button.Click += new System.EventHandler(this.add_Product_Save_Button_Click);
            // 
            // add_Product_Cancel_Button
            // 
            this.add_Product_Cancel_Button.Location = new System.Drawing.Point(784, 510);
            this.add_Product_Cancel_Button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.add_Product_Cancel_Button.Name = "add_Product_Cancel_Button";
            this.add_Product_Cancel_Button.Size = new System.Drawing.Size(51, 22);
            this.add_Product_Cancel_Button.TabIndex = 13;
            this.add_Product_Cancel_Button.Text = "Cancel";
            this.add_Product_Cancel_Button.UseVisualStyleBackColor = true;
            this.add_Product_Cancel_Button.Click += new System.EventHandler(this.add_Product_Cancel_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add/Modify Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "All Candidate Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 285);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Parts Associated with the Product";
            // 
            // add_Product_ID
            // 
            this.add_Product_ID.AutoSize = true;
            this.add_Product_ID.Location = new System.Drawing.Point(133, 221);
            this.add_Product_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.add_Product_ID.Name = "add_Product_ID";
            this.add_Product_ID.Size = new System.Drawing.Size(18, 15);
            this.add_Product_ID.TabIndex = 17;
            this.add_Product_ID.Text = "ID";
            // 
            // add_Product_Name
            // 
            this.add_Product_Name.AutoSize = true;
            this.add_Product_Name.Location = new System.Drawing.Point(111, 263);
            this.add_Product_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.add_Product_Name.Name = "add_Product_Name";
            this.add_Product_Name.Size = new System.Drawing.Size(39, 15);
            this.add_Product_Name.TabIndex = 18;
            this.add_Product_Name.Text = "Name";
            // 
            // add_Product_Inventory
            // 
            this.add_Product_Inventory.AutoSize = true;
            this.add_Product_Inventory.Location = new System.Drawing.Point(91, 299);
            this.add_Product_Inventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.add_Product_Inventory.Name = "add_Product_Inventory";
            this.add_Product_Inventory.Size = new System.Drawing.Size(57, 15);
            this.add_Product_Inventory.TabIndex = 19;
            this.add_Product_Inventory.Text = "Inventory";
            // 
            // add_Product_Price
            // 
            this.add_Product_Price.AutoSize = true;
            this.add_Product_Price.Location = new System.Drawing.Point(118, 338);
            this.add_Product_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.add_Product_Price.Name = "add_Product_Price";
            this.add_Product_Price.Size = new System.Drawing.Size(33, 15);
            this.add_Product_Price.TabIndex = 20;
            this.add_Product_Price.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 377);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 375);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 579);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.add_Product_Price);
            this.Controls.Add(this.add_Product_Inventory);
            this.Controls.Add(this.add_Product_Name);
            this.Controls.Add(this.add_Product_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_Product_Cancel_Button);
            this.Controls.Add(this.add_Product_Save_Button);
            this.Controls.Add(this.add_Product_Delete_Button);
            this.Controls.Add(this.add_Product_Add_Part_Procuct_Button);
            this.Controls.Add(this.add_Product_Search_Button);
            this.Controls.Add(this.add_Product_Search_Field);
            this.Controls.Add(this.add_Product_ID_Field);
            this.Controls.Add(this.add_Product_Name_Field);
            this.Controls.Add(this.add_Product_Inventory_Field);
            this.Controls.Add(this.add_Product_Max_Field);
            this.Controls.Add(this.add_Product_Min_Field);
            this.Controls.Add(this.add_Product_Price_Field);
            this.Controls.Add(this.add_Product_Associated_Parts_View);
            this.Controls.Add(this.add_Product_Parts_OnProduct_View);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimumSize = new System.Drawing.Size(959, 507);
            this.Name = "Form1";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Parts_OnProduct_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Associated_Parts_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Price_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Min_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Max_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Product_Inventory_Field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView add_Product_Parts_OnProduct_View;
        private System.Windows.Forms.DataGridView add_Product_Associated_Parts_View;
        private System.Windows.Forms.NumericUpDown add_Product_Price_Field;
        private System.Windows.Forms.NumericUpDown add_Product_Min_Field;
        private System.Windows.Forms.NumericUpDown add_Product_Max_Field;
        private System.Windows.Forms.NumericUpDown add_Product_Inventory_Field;
        private System.Windows.Forms.TextBox add_Product_Name_Field;
        private System.Windows.Forms.TextBox add_Product_ID_Field;
        private System.Windows.Forms.TextBox add_Product_Search_Field;
        private System.Windows.Forms.Button add_Product_Search_Button;
        private System.Windows.Forms.Button add_Product_Add_Part_Procuct_Button;
        private System.Windows.Forms.Button add_Product_Delete_Button;
        private System.Windows.Forms.Button add_Product_Save_Button;
        private System.Windows.Forms.Button add_Product_Cancel_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label add_Product_ID;
        private System.Windows.Forms.Label add_Product_Name;
        private System.Windows.Forms.Label add_Product_Inventory;
        private System.Windows.Forms.Label add_Product_Price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}