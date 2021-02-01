namespace OnionArchitecture.WinFormsUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addPartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.searchPartsButton = new System.Windows.Forms.Button();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.productsGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.partsGridView = new System.Windows.Forms.DataGridView();
            this.products_bindings = new System.Windows.Forms.BindingSource(this.components);
            this.parts_bindings = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_bindings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parts_bindings)).BeginInit();
            this.SuspendLayout();
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(397, 587);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(101, 46);
            this.addPartButton.TabIndex = 3;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.Location = new System.Drawing.Point(519, 587);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(113, 46);
            this.modifyPartButton.TabIndex = 4;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.modifyPartButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(652, 587);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(104, 46);
            this.deletePartButton.TabIndex = 5;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(1114, 587);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(150, 46);
            this.addProductButton.TabIndex = 9;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(1284, 587);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(150, 46);
            this.modifyProductButton.TabIndex = 10;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(1454, 587);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(150, 46);
            this.deleteProductButton.TabIndex = 11;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.Location = new System.Drawing.Point(1303, 104);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(95, 39);
            this.searchProductsButton.TabIndex = 6;
            this.searchProductsButton.Text = "Search";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            // 
            // searchPartsButton
            // 
            this.searchPartsButton.Location = new System.Drawing.Point(436, 104);
            this.searchPartsButton.Name = "searchPartsButton";
            this.searchPartsButton.Size = new System.Drawing.Size(113, 39);
            this.searchPartsButton.TabIndex = 0;
            this.searchPartsButton.Text = "Search";
            this.searchPartsButton.UseVisualStyleBackColor = true;
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(555, 104);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(200, 39);
            this.partSearchBox.TabIndex = 1;
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(1404, 104);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(200, 39);
            this.productSearchBox.TabIndex = 7;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(1454, 716);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(150, 46);
            this.exit_button.TabIndex = 12;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(886, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Products";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(791, 490);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 16;
            // 
            // productsGridView1
            // 
            this.productsGridView1.AllowUserToAddRows = false;
            this.productsGridView1.AllowUserToDeleteRows = false;
            this.productsGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView1.Location = new System.Drawing.Point(890, 153);
            this.productsGridView1.Name = "productsGridView1";
            this.productsGridView1.ReadOnly = true;
            this.productsGridView1.RowHeadersWidth = 82;
            this.productsGridView1.RowTemplate.Height = 41;
            this.productsGridView1.Size = new System.Drawing.Size(714, 425);
            this.productsGridView1.TabIndex = 8;
            this.productsGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Inventory Management System";
            // 
            // partsGridView
            // 
            this.partsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGridView.Location = new System.Drawing.Point(44, 153);
            this.partsGridView.MinimumSize = new System.Drawing.Size(714, 425);
            this.partsGridView.Name = "partsGridView";
            this.partsGridView.RowHeadersWidth = 82;
            this.partsGridView.RowTemplate.Height = 41;
            this.partsGridView.Size = new System.Drawing.Size(714, 425);
            this.partsGridView.TabIndex = 2;
            // 
            // parts_bindings
            // 
            this.parts_bindings.CurrentChanged += new System.EventHandler(this.bindingSource2_CurrentChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1674, 807);
            this.Controls.Add(this.partsGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productsGridView1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.searchPartsButton);
            this.Controls.Add(this.searchProductsButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.deletePartButton);
            this.Controls.Add(this.modifyPartButton);
            this.Controls.Add(this.addPartButton);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_bindings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parts_bindings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button searchProductsButton;
        private System.Windows.Forms.Button searchPartsButton;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView productsGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView partsGridView;
        private System.Windows.Forms.BindingSource products_bindings;
        private System.Windows.Forms.BindingSource parts_bindings;
    }
}

