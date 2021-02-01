using System;
using System.Windows.Forms;

namespace TraditionalArchitecture.WinFormsUI
{
    public partial class ModifyPart : Form
    {
        public Inventory Inventory { get; set; }

        private bool validated;

        public bool GetValidated()
        {
            return validated;
        }

        public void SetValidated(bool value)
        {
            validated = value;
        }

        public ModifyPart(Part part)
        {
            InitializeComponent();
            //Hide arrows
            modify_Part_Min_Field.Controls[0].Visible = false;
            modify_Part_Max_Field.Controls[0].Visible = false;
            modify_Part_Price_Field.Controls[0].Visible = false;
            modify_Part_Inventory_Field.Controls[0].Visible = false;
            modify_Part_MachineID_Field.Controls[0].Visible = false;
            //end hide arrows
            if (part is InHouse)
            {
               modify_Part_Inhouse_Radio.Checked = true;
            } else if (part is Outsourced) {
                modify_Part_Outsourced_Radio.Checked = true;
            }
            modify_Part_Name_Field.Text = part.Name;
            modify_Part_ID_Field.Text = part.PartID.ToString();
            if (part.InStock < part.Min || part.InStock > part.Max) {
                Inventory_Validation_label.Show();
                validated = false;

            }
            if (part.InStock >= part.Min && part.InStock <= part.Max)
            {
                Inventory_Validation_label.Hide();
                validated = true;
            }
            modify_Part_Inventory_Field.Value = part.InStock;
            modify_Part_Price_Field.Value = part.Price;
            modify_Part_Max_Field.Value = part.Max;
            modify_Part_Min_Field.Value = part.Min;

            if (modify_Part_Outsourced_Radio.Checked)
            {
                var temp = part as Outsourced;
                modify_Part_Companyname_Field.Text = temp.CompanyName;
            }
            else if (modify_Part_Inhouse_Radio.Checked)
            {

                var temp2 = part as InHouse;
                modify_Part_MachineID_Field.Value = temp2.MachineID;
            }

        }

        private void modify_Part_Save_Button_Click(object sender, EventArgs e)
        {
            if (modify_Part_Outsourced_Radio.Checked)
            {
                var part = new Outsourced
                {
                    Name = modify_Part_Name_Field.Text,
                    PartID = Convert.ToInt32(modify_Part_ID_Field.Text),
                    Max = Decimal.ToInt32(modify_Part_Max_Field.Value),
                    Min = Decimal.ToInt32(modify_Part_Min_Field.Value),
                    InStock = Decimal.ToInt32(modify_Part_Inventory_Field.Value),
                    Price = modify_Part_Price_Field.Value
                };
            }
            else
            {
                var part = new InHouse
                {
                    Name = modify_Part_Name_Field.Text,
                    PartID = Convert.ToInt32(modify_Part_ID_Field.Text),
                    Max = Decimal.ToInt32(modify_Part_Max_Field.Value),
                    Min = Decimal.ToInt32(modify_Part_Min_Field.Value),
                    InStock = Decimal.ToInt32(modify_Part_Inventory_Field.Value),
                    Price = modify_Part_Price_Field.Value
                };

                if (validated == true)
                {
                    Inventory.updatePart(part.PartID, part);
                    this.Close();
                }

            }
        }

            private void modify_Part_Cancel_Button_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void modify_Part_Outsourced_Radio_CheckedChanged(object sender, EventArgs e)
            {
                modify_Part_MachineID_Field.Hide();
                modify_Part_MachineID_Label.Hide();
                modify_Part_Companyname_Field.Show();
                modify_Part_CompanyName_Label.Show();
            }

            private void modify_Part_Inhouse_Radio_CheckedChanged(object sender, EventArgs e)
            {
                modify_Part_MachineID_Field.Show();
                modify_Part_MachineID_Label.Show();
                modify_Part_Companyname_Field.Hide();
                modify_Part_CompanyName_Label.Hide();

            }

        private void Inventory_Validation_label_Click(object sender, EventArgs e)
        {
           

        }

        private void modify_Part_Inventory_Field_ValueChanged(object sender, EventArgs e)
        {
            var senderarg = sender;
            var min = modify_Part_Min_Field.Value;
            var max = modify_Part_Max_Field.Value;
            //if (part.InStock < part.Min || part.InStock > part.Max)
            //{
            //    Inventory_Validation_label.Show();
            //    validated = false;

            //}
            //if (part.InStock >= part.Min && part.InStock <= part.Max)
            //{
            //    Inventory_Validation_label.Hide();
            //    validated = true;
            //}
        }
    }
    } 
