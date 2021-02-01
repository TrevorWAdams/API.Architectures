
namespace OnionArchitecture.WinFormsUI
{
    partial class AddPart
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.inhouse_radio = new System.Windows.Forms.RadioButton();
            this.outsourced_radio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add_Part_Name_Field = new System.Windows.Forms.TextBox();
            this.add_Part_Outsourced_Field = new System.Windows.Forms.TextBox();
            this.add_Part_Save_Button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.name_label1 = new System.Windows.Forms.Label();
            this.inventory_label = new System.Windows.Forms.Label();
            this.price_cost_label = new System.Windows.Forms.Label();
            this.max_label = new System.Windows.Forms.Label();
            this.Min_label = new System.Windows.Forms.Label();
            this.inhouse_label = new System.Windows.Forms.Label();
            this.add_Part_Main_Label = new System.Windows.Forms.Label();
            this.outsourced_label = new System.Windows.Forms.Label();
            this.add_Part_Min_Field = new System.Windows.Forms.NumericUpDown();
            this.add_Part_Max_Field = new System.Windows.Forms.NumericUpDown();
            this.add_Part_Inventory_Field = new System.Windows.Forms.NumericUpDown();
            this.add_Part_Price_Field = new System.Windows.Forms.NumericUpDown();
            this.add_Part_Inhouse_Field = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Part_Min_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Part_Max_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Part_Inventory_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Part_Price_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Part_Inhouse_Field)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // inhouse_radio
            // 
            this.inhouse_radio.AutoSize = true;
            this.inhouse_radio.Location = new System.Drawing.Point(222, 44);
            this.inhouse_radio.Name = "inhouse_radio";
            this.inhouse_radio.Size = new System.Drawing.Size(143, 36);
            this.inhouse_radio.TabIndex = 0;
            this.inhouse_radio.TabStop = true;
            this.inhouse_radio.Text = "In-House";
            this.inhouse_radio.UseVisualStyleBackColor = true;
            this.inhouse_radio.CheckedChanged += new System.EventHandler(this.inhouse_radio_CheckedChanged);
            // 
            // outsourced_radio
            // 
            this.outsourced_radio.AutoSize = true;
            this.outsourced_radio.Location = new System.Drawing.Point(488, 44);
            this.outsourced_radio.Name = "outsourced_radio";
            this.outsourced_radio.Size = new System.Drawing.Size(169, 36);
            this.outsourced_radio.TabIndex = 1;
            this.outsourced_radio.TabStop = true;
            this.outsourced_radio.Text = "Outsourced";
            this.outsourced_radio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outsourced_radio.UseVisualStyleBackColor = true;
            this.outsourced_radio.CheckedChanged += new System.EventHandler(this.outsourced_radio_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 39);
            this.textBox1.TabIndex = 2;
            // 
            // add_Part_Name_Field
            // 
            this.add_Part_Name_Field.Location = new System.Drawing.Point(311, 217);
            this.add_Part_Name_Field.Name = "add_Part_Name_Field";
            this.add_Part_Name_Field.Size = new System.Drawing.Size(200, 39);
            this.add_Part_Name_Field.TabIndex = 3;
            // 
            // add_Part_Outsourced_Field
            // 
            this.add_Part_Outsourced_Field.Location = new System.Drawing.Point(311, 526);
            this.add_Part_Outsourced_Field.Name = "add_Part_Outsourced_Field";
            this.add_Part_Outsourced_Field.Size = new System.Drawing.Size(200, 39);
            this.add_Part_Outsourced_Field.TabIndex = 8;
            // 
            // add_Part_Save_Button
            // 
            this.add_Part_Save_Button.Location = new System.Drawing.Point(311, 680);
            this.add_Part_Save_Button.Name = "add_Part_Save_Button";
            this.add_Part_Save_Button.Size = new System.Drawing.Size(150, 46);
            this.add_Part_Save_Button.TabIndex = 9;
            this.add_Part_Save_Button.Text = "Save";
            this.add_Part_Save_Button.UseVisualStyleBackColor = true;
            this.add_Part_Save_Button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(532, 680);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(150, 46);
            this.cancel_button.TabIndex = 10;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(243, 154);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(37, 32);
            this.ID.TabIndex = 11;
            this.ID.Text = "ID";
            // 
            // name_label1
            // 
            this.name_label1.AutoSize = true;
            this.name_label1.Location = new System.Drawing.Point(202, 224);
            this.name_label1.Name = "name_label1";
            this.name_label1.Size = new System.Drawing.Size(78, 32);
            this.name_label1.TabIndex = 12;
            this.name_label1.Text = "Name";
            // 
            // inventory_label
            // 
            this.inventory_label.AutoSize = true;
            this.inventory_label.Location = new System.Drawing.Point(165, 295);
            this.inventory_label.Name = "inventory_label";
            this.inventory_label.Size = new System.Drawing.Size(115, 32);
            this.inventory_label.TabIndex = 13;
            this.inventory_label.Text = "Inventory";
            // 
            // price_cost_label
            // 
            this.price_cost_label.AutoSize = true;
            this.price_cost_label.Location = new System.Drawing.Point(145, 376);
            this.price_cost_label.Name = "price_cost_label";
            this.price_cost_label.Size = new System.Drawing.Size(135, 32);
            this.price_cost_label.TabIndex = 14;
            this.price_cost_label.Text = "Price / Cost";
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Location = new System.Drawing.Point(221, 446);
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(59, 32);
            this.max_label.TabIndex = 15;
            this.max_label.Text = "Max";
            // 
            // Min_label
            // 
            this.Min_label.AutoSize = true;
            this.Min_label.Location = new System.Drawing.Point(468, 446);
            this.Min_label.Name = "Min_label";
            this.Min_label.Size = new System.Drawing.Size(56, 32);
            this.Min_label.TabIndex = 16;
            this.Min_label.Text = "Min";
            // 
            // inhouse_label
            // 
            this.inhouse_label.AutoSize = true;
            this.inhouse_label.Location = new System.Drawing.Point(168, 533);
            this.inhouse_label.Name = "inhouse_label";
            this.inhouse_label.Size = new System.Drawing.Size(136, 32);
            this.inhouse_label.TabIndex = 17;
            this.inhouse_label.Text = "Machine ID";
            // 
            // add_Part_Main_Label
            // 
            this.add_Part_Main_Label.AutoSize = true;
            this.add_Part_Main_Label.Location = new System.Drawing.Point(23, 48);
            this.add_Part_Main_Label.Name = "add_Part_Main_Label";
            this.add_Part_Main_Label.Size = new System.Drawing.Size(104, 32);
            this.add_Part_Main_Label.TabIndex = 18;
            this.add_Part_Main_Label.Text = "Add Part";
            // 
            // outsourced_label
            // 
            this.outsourced_label.AutoSize = true;
            this.outsourced_label.Location = new System.Drawing.Point(111, 529);
            this.outsourced_label.Name = "outsourced_label";
            this.outsourced_label.Size = new System.Drawing.Size(187, 32);
            this.outsourced_label.TabIndex = 19;
            this.outsourced_label.Text = "Company Name";
            this.outsourced_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_Part_Min_Field
            // 
            this.add_Part_Min_Field.Location = new System.Drawing.Point(532, 446);
            this.add_Part_Min_Field.Name = "add_Part_Min_Field";
            this.add_Part_Min_Field.Size = new System.Drawing.Size(86, 39);
            this.add_Part_Min_Field.TabIndex = 20;
            // 
            // add_Part_Max_Field
            // 
            this.add_Part_Max_Field.Location = new System.Drawing.Point(313, 444);
            this.add_Part_Max_Field.Name = "add_Part_Max_Field";
            this.add_Part_Max_Field.Size = new System.Drawing.Size(116, 39);
            this.add_Part_Max_Field.TabIndex = 21;
            // 
            // add_Part_Inventory_Field
            // 
            this.add_Part_Inventory_Field.Location = new System.Drawing.Point(313, 288);
            this.add_Part_Inventory_Field.Name = "add_Part_Inventory_Field";
            this.add_Part_Inventory_Field.Size = new System.Drawing.Size(198, 39);
            this.add_Part_Inventory_Field.TabIndex = 22;
            // 
            // add_Part_Price_Field
            // 
            this.add_Part_Price_Field.DecimalPlaces = 2;
            this.add_Part_Price_Field.Location = new System.Drawing.Point(313, 369);
            this.add_Part_Price_Field.Name = "add_Part_Price_Field";
            this.add_Part_Price_Field.Size = new System.Drawing.Size(198, 39);
            this.add_Part_Price_Field.TabIndex = 23;
            // 
            // add_Part_Inhouse_Field
            // 
            this.add_Part_Inhouse_Field.Location = new System.Drawing.Point(312, 527);
            this.add_Part_Inhouse_Field.Name = "add_Part_Inhouse_Field";
            this.add_Part_Inhouse_Field.Size = new System.Drawing.Size(199, 39);
            this.add_Part_Inhouse_Field.TabIndex = 24;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 763);
            this.Controls.Add(this.add_Part_Inhouse_Field);
            this.Controls.Add(this.add_Part_Price_Field);
            this.Controls.Add(this.add_Part_Inventory_Field);
            this.Controls.Add(this.add_Part_Max_Field);
            this.Controls.Add(this.add_Part_Min_Field);
            this.Controls.Add(this.outsourced_label);
            this.Controls.Add(this.add_Part_Main_Label);
            this.Controls.Add(this.inhouse_label);
            this.Controls.Add(this.Min_label);
            this.Controls.Add(this.max_label);
            this.Controls.Add(this.price_cost_label);
            this.Controls.Add(this.inventory_label);
            this.Controls.Add(this.name_label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_Part_Save_Button);
            this.Controls.Add(this.add_Part_Outsourced_Field);
            this.Controls.Add(this.add_Part_Name_Field);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.outsourced_radio);
            this.Controls.Add(this.inhouse_radio);
            this.MinimumSize = new System.Drawing.Size(840, 834);
            this.Name = "AddPart";
            this.Text = "Part";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Part_Min_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Part_Max_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Part_Inventory_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Part_Price_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_Part_Inhouse_Field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label add_Part_Main_Label;
        private System.Windows.Forms.Label inhouse_label;
        private System.Windows.Forms.Label Min_label;
        private System.Windows.Forms.Label max_label;
        private System.Windows.Forms.Label price_cost_label;
        private System.Windows.Forms.Label inventory_label;
        private System.Windows.Forms.Label name_label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button add_Part_Save_Button;
        private System.Windows.Forms.TextBox add_Part_Outsourced_Field;
        private System.Windows.Forms.TextBox add_Part_Name_Field;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton outsourced_radio;
        private System.Windows.Forms.RadioButton inhouse_radio;
        private System.Windows.Forms.Label outsourced_label;
        private System.Windows.Forms.NumericUpDown add_Part_Max_Field;
        private System.Windows.Forms.NumericUpDown add_Part_Min_Field;
        private System.Windows.Forms.NumericUpDown add_Part_Inventory_Field;
        private System.Windows.Forms.NumericUpDown add_Part_Price_Field;
        private System.Windows.Forms.NumericUpDown add_Part_Inhouse_Field;
    }
}