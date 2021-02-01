
namespace OnionArchitecture.WinFormsUI
{
    partial class ModifyPart
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
            this.label1 = new System.Windows.Forms.Label();
            this.modify_Part_Inhouse_Radio = new System.Windows.Forms.RadioButton();
            this.modify_Part_Outsourced_Radio = new System.Windows.Forms.RadioButton();
            this.modify_Part_ID_Field = new System.Windows.Forms.TextBox();
            this.modify_Part_Name_Field = new System.Windows.Forms.TextBox();
            this.modify_Part_Inventory_Field = new System.Windows.Forms.NumericUpDown();
            this.modify_Part_Price_Field = new System.Windows.Forms.NumericUpDown();
            this.modify_Part_Max_Field = new System.Windows.Forms.NumericUpDown();
            this.modify_Part_Min_Field = new System.Windows.Forms.NumericUpDown();
            this.modify_Part_MachineID_Field = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modify_Part_MachineID_Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modify_Part_Save_Button = new System.Windows.Forms.Button();
            this.modify_Part_Cancel_Button = new System.Windows.Forms.Button();
            this.modify_Part_CompanyName_Label = new System.Windows.Forms.Label();
            this.modify_Part_Companyname_Field = new System.Windows.Forms.TextBox();
            this.Inventory_Validation_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modify_Part_Inventory_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_Part_Price_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_Part_Max_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_Part_Min_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_Part_MachineID_Field)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Part";
            // 
            // modify_Part_Inhouse_Radio
            // 
            this.modify_Part_Inhouse_Radio.AutoSize = true;
            this.modify_Part_Inhouse_Radio.Location = new System.Drawing.Point(216, 40);
            this.modify_Part_Inhouse_Radio.Name = "modify_Part_Inhouse_Radio";
            this.modify_Part_Inhouse_Radio.Size = new System.Drawing.Size(143, 36);
            this.modify_Part_Inhouse_Radio.TabIndex = 1;
            this.modify_Part_Inhouse_Radio.TabStop = true;
            this.modify_Part_Inhouse_Radio.Text = "In-House";
            this.modify_Part_Inhouse_Radio.UseVisualStyleBackColor = true;
            this.modify_Part_Inhouse_Radio.CheckedChanged += new System.EventHandler(this.modify_Part_Inhouse_Radio_CheckedChanged);
            // 
            // modify_Part_Outsourced_Radio
            // 
            this.modify_Part_Outsourced_Radio.AutoSize = true;
            this.modify_Part_Outsourced_Radio.Location = new System.Drawing.Point(482, 40);
            this.modify_Part_Outsourced_Radio.Name = "modify_Part_Outsourced_Radio";
            this.modify_Part_Outsourced_Radio.Size = new System.Drawing.Size(169, 36);
            this.modify_Part_Outsourced_Radio.TabIndex = 2;
            this.modify_Part_Outsourced_Radio.TabStop = true;
            this.modify_Part_Outsourced_Radio.Text = "Outsourced";
            this.modify_Part_Outsourced_Radio.UseVisualStyleBackColor = true;
            this.modify_Part_Outsourced_Radio.CheckedChanged += new System.EventHandler(this.modify_Part_Outsourced_Radio_CheckedChanged);
            // 
            // modify_Part_ID_Field
            // 
            this.modify_Part_ID_Field.Location = new System.Drawing.Point(274, 148);
            this.modify_Part_ID_Field.Name = "modify_Part_ID_Field";
            this.modify_Part_ID_Field.ReadOnly = true;
            this.modify_Part_ID_Field.Size = new System.Drawing.Size(200, 39);
            this.modify_Part_ID_Field.TabIndex = 0;
            // 
            // modify_Part_Name_Field
            // 
            this.modify_Part_Name_Field.BackColor = System.Drawing.Color.Tomato;
            this.modify_Part_Name_Field.Location = new System.Drawing.Point(274, 218);
            this.modify_Part_Name_Field.Name = "modify_Part_Name_Field";
            this.modify_Part_Name_Field.Size = new System.Drawing.Size(200, 39);
            this.modify_Part_Name_Field.TabIndex = 1;
            // 
            // modify_Part_Inventory_Field
            // 
            this.modify_Part_Inventory_Field.BackColor = System.Drawing.Color.Tomato;
            this.modify_Part_Inventory_Field.Location = new System.Drawing.Point(274, 289);
            this.modify_Part_Inventory_Field.Name = "modify_Part_Inventory_Field";
            this.modify_Part_Inventory_Field.Size = new System.Drawing.Size(240, 39);
            this.modify_Part_Inventory_Field.TabIndex = 2;
            this.modify_Part_Inventory_Field.ValueChanged += new System.EventHandler(this.modify_Part_Inventory_Field_ValueChanged);
            // 
            // modify_Part_Price_Field
            // 
            this.modify_Part_Price_Field.BackColor = System.Drawing.Color.Tomato;
            this.modify_Part_Price_Field.Location = new System.Drawing.Point(274, 380);
            this.modify_Part_Price_Field.Name = "modify_Part_Price_Field";
            this.modify_Part_Price_Field.Size = new System.Drawing.Size(240, 39);
            this.modify_Part_Price_Field.TabIndex = 4;
            // 
            // modify_Part_Max_Field
            // 
            this.modify_Part_Max_Field.BackColor = System.Drawing.Color.Tomato;
            this.modify_Part_Max_Field.Location = new System.Drawing.Point(274, 452);
            this.modify_Part_Max_Field.Name = "modify_Part_Max_Field";
            this.modify_Part_Max_Field.Size = new System.Drawing.Size(119, 39);
            this.modify_Part_Max_Field.TabIndex = 5;
            // 
            // modify_Part_Min_Field
            // 
            this.modify_Part_Min_Field.BackColor = System.Drawing.Color.Tomato;
            this.modify_Part_Min_Field.Location = new System.Drawing.Point(532, 452);
            this.modify_Part_Min_Field.Name = "modify_Part_Min_Field";
            this.modify_Part_Min_Field.Size = new System.Drawing.Size(100, 39);
            this.modify_Part_Min_Field.TabIndex = 6;
            // 
            // modify_Part_MachineID_Field
            // 
            this.modify_Part_MachineID_Field.BackColor = System.Drawing.Color.Tomato;
            this.modify_Part_MachineID_Field.Location = new System.Drawing.Point(274, 526);
            this.modify_Part_MachineID_Field.Name = "modify_Part_MachineID_Field";
            this.modify_Part_MachineID_Field.Size = new System.Drawing.Size(240, 39);
            this.modify_Part_MachineID_Field.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price/Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max";
            // 
            // modify_Part_MachineID_Label
            // 
            this.modify_Part_MachineID_Label.AutoSize = true;
            this.modify_Part_MachineID_Label.Location = new System.Drawing.Point(106, 526);
            this.modify_Part_MachineID_Label.Name = "modify_Part_MachineID_Label";
            this.modify_Part_MachineID_Label.Size = new System.Drawing.Size(136, 32);
            this.modify_Part_MachineID_Label.TabIndex = 15;
            this.modify_Part_MachineID_Label.Text = "Machine ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Min";
            // 
            // modify_Part_Save_Button
            // 
            this.modify_Part_Save_Button.Location = new System.Drawing.Point(274, 675);
            this.modify_Part_Save_Button.Name = "modify_Part_Save_Button";
            this.modify_Part_Save_Button.Size = new System.Drawing.Size(150, 46);
            this.modify_Part_Save_Button.TabIndex = 17;
            this.modify_Part_Save_Button.Text = "Save";
            this.modify_Part_Save_Button.UseVisualStyleBackColor = true;
            this.modify_Part_Save_Button.Click += new System.EventHandler(this.modify_Part_Save_Button_Click);
            // 
            // modify_Part_Cancel_Button
            // 
            this.modify_Part_Cancel_Button.Location = new System.Drawing.Point(532, 675);
            this.modify_Part_Cancel_Button.Name = "modify_Part_Cancel_Button";
            this.modify_Part_Cancel_Button.Size = new System.Drawing.Size(150, 46);
            this.modify_Part_Cancel_Button.TabIndex = 18;
            this.modify_Part_Cancel_Button.Text = "Cancel";
            this.modify_Part_Cancel_Button.UseVisualStyleBackColor = true;
            this.modify_Part_Cancel_Button.Click += new System.EventHandler(this.modify_Part_Cancel_Button_Click);
            // 
            // modify_Part_CompanyName_Label
            // 
            this.modify_Part_CompanyName_Label.AutoSize = true;
            this.modify_Part_CompanyName_Label.Location = new System.Drawing.Point(59, 532);
            this.modify_Part_CompanyName_Label.Name = "modify_Part_CompanyName_Label";
            this.modify_Part_CompanyName_Label.Size = new System.Drawing.Size(183, 32);
            this.modify_Part_CompanyName_Label.TabIndex = 19;
            this.modify_Part_CompanyName_Label.Text = "Company name";
            // 
            // modify_Part_Companyname_Field
            // 
            this.modify_Part_Companyname_Field.BackColor = System.Drawing.Color.Tomato;
            this.modify_Part_Companyname_Field.Location = new System.Drawing.Point(274, 526);
            this.modify_Part_Companyname_Field.Name = "modify_Part_Companyname_Field";
            this.modify_Part_Companyname_Field.Size = new System.Drawing.Size(240, 39);
            this.modify_Part_Companyname_Field.TabIndex = 7;
            // 
            // Inventory_Validation_label
            // 
            this.Inventory_Validation_label.AutoSize = true;
            this.Inventory_Validation_label.ForeColor = System.Drawing.Color.Crimson;
            this.Inventory_Validation_label.Location = new System.Drawing.Point(178, 331);
            this.Inventory_Validation_label.Name = "Inventory_Validation_label";
            this.Inventory_Validation_label.Size = new System.Drawing.Size(454, 32);
            this.Inventory_Validation_label.TabIndex = 21;
            this.Inventory_Validation_label.Text = "Inventory must be between min and max";
            this.Inventory_Validation_label.Visible = false;
            this.Inventory_Validation_label.Click += new System.EventHandler(this.Inventory_Validation_label_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 763);
            this.Controls.Add(this.Inventory_Validation_label);
            this.Controls.Add(this.modify_Part_Companyname_Field);
            this.Controls.Add(this.modify_Part_CompanyName_Label);
            this.Controls.Add(this.modify_Part_Cancel_Button);
            this.Controls.Add(this.modify_Part_Save_Button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.modify_Part_MachineID_Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modify_Part_MachineID_Field);
            this.Controls.Add(this.modify_Part_Min_Field);
            this.Controls.Add(this.modify_Part_Max_Field);
            this.Controls.Add(this.modify_Part_Price_Field);
            this.Controls.Add(this.modify_Part_Inventory_Field);
            this.Controls.Add(this.modify_Part_Name_Field);
            this.Controls.Add(this.modify_Part_ID_Field);
            this.Controls.Add(this.modify_Part_Outsourced_Radio);
            this.Controls.Add(this.modify_Part_Inhouse_Radio);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(840, 834);
            this.Name = "ModifyPart";
            this.Text = "Company name";
            ((System.ComponentModel.ISupportInitialize)(this.modify_Part_Inventory_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_Part_Price_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_Part_Max_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_Part_Min_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_Part_MachineID_Field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton modify_Part_Inhouse_Radio;
        private System.Windows.Forms.RadioButton modify_Part_Outsourced_Radio;
        private System.Windows.Forms.TextBox modify_Part_ID_Field;
        private System.Windows.Forms.TextBox modify_Part_Name_Field;
        private System.Windows.Forms.NumericUpDown modify_Part_Inventory_Field;
        private System.Windows.Forms.NumericUpDown modify_Part_Price_Field;
        private System.Windows.Forms.NumericUpDown modify_Part_Max_Field;
        private System.Windows.Forms.NumericUpDown modify_Part_Min_Field;
        private System.Windows.Forms.NumericUpDown modify_Part_MachineID_Field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label modify_Part_MachineID_Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button modify_Part_Save_Button;
        private System.Windows.Forms.Button modify_Part_Cancel_Button;
        private System.Windows.Forms.Label modify_Part_CompanyName_Label;
        private System.Windows.Forms.TextBox modify_Part_Companyname_Field;
        private System.Windows.Forms.Label Inventory_Validation_label;
    }
}