using System;
using System.Windows.Forms;

namespace OnionArchitecture.WinFormsUI
{
    public partial class AddPart : Form
    {
        public Inventory Inventory { get; set; }
        public AddPart()
        {
            InitializeComponent();
            //Hide arrows
            add_Part_Max_Field.Controls[0].Visible = false;
            add_Part_Min_Field.Controls[0].Visible = false;
            add_Part_Price_Field.Controls[0].Visible = false;
            add_Part_Inventory_Field.Controls[0].Visible = false;
            add_Part_Inhouse_Field.Controls[0].Visible = false;
            //end/hide arrows

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inhouse_radio_CheckedChanged(object sender, EventArgs e)
        {
            inhouse_label.Show();
            outsourced_label.Hide();
            add_Part_Inhouse_Field.Show();
            add_Part_Outsourced_Field.Hide();
           
        }

        private void outsourced_radio_CheckedChanged(object sender, EventArgs e)
        {
            inhouse_label.Hide();
            add_Part_Inhouse_Field.Hide();
            outsourced_label.Show();
            add_Part_Outsourced_Field.Show();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (inhouse_radio.Checked) { 
            Inventory.addPart(new InHouse { 
                Name = add_Part_Name_Field.Text, Min = (int)add_Part_Min_Field.Value, Max = (int)add_Part_Max_Field.Value, 
                InStock = (int)add_Part_Inventory_Field.Value, Price = add_Part_Price_Field.Value, MachineID = (int)add_Part_Inhouse_Field.Value});
            }
            else { 
            Inventory.addPart(new Outsourced { Name = add_Part_Name_Field.Text, Min = (int)add_Part_Min_Field.Value, 
                Max = (int)add_Part_Max_Field.Value, InStock = (int)add_Part_Inventory_Field.Value, Price = add_Part_Price_Field.Value, 
                CompanyName = add_Part_Outsourced_Field.Text });
            }
            Close();
        }
    }
}
