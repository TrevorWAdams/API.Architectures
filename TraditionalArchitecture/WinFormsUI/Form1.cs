using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TraditionalArchitecture.WinFormsUI
{
    public partial class Form1 : Form
    {
        public Inventory Inventory { get; set; }
        public Product tempProduct { get; set; }
        public Form1()
        {
            //Inventory = new Inventory { Products = GetProducts() };
            InitializeComponent();
            tempProduct = new Product();
            tempProduct.AssociatedParts = new BindingList<Part>();
            add_Product_Associated_Parts_View.DataSource = tempProduct.AssociatedParts;

            //Hide arrows          
            add_Product_Inventory_Field.Controls[0].Visible = false;
            add_Product_Max_Field.Controls[0].Visible = false;
            add_Product_Min_Field.Controls[0].Visible = false;
            add_Product_Price_Field.Controls[0].Visible = false;
            //end arrows         

        }
        public void SetViewParts()
        {
            add_Product_Parts_OnProduct_View.DataSource = Inventory.AllParts;
        }
        public BindingList<Product> GetProducts()
        {
            BindingList<Product> list = new BindingList<Product>();
            list.Add(new Product()
            {
                ProductID = 1,
                Name = "canogoo",
                Price = 1,
                InStock = 5,
                Min = 3,
                Max = 4
            });
            list.Add(new Product()
            {
                ProductID = 2,
                Name = "sample",
                Price = 2,
                InStock = 5,
                Min = 3,
                Max = 4
            });
            list.Add(new Product()
            {
                ProductID = 3,
                Name = "timesucker",
                Price = 5,
                InStock = 5,
                Min = 3,
                Max = 4
            });
            list.Add(new Product()
            {
                ProductID = 4,
                Name = "uselessgoo",
                Price = 3,
                InStock = 5,
                Min = 3,
                Max = 4
            });
            return list;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Product_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_Product_Add_Part_Procuct_Button_Click(object sender, EventArgs e)
        {
            if (add_Product_Parts_OnProduct_View.SelectedRows.Count > 0)
            {
                var selectedRow = add_Product_Parts_OnProduct_View.SelectedRows[0].DataBoundItem as Part;
               AssociatedParts(selectedRow);
           
            }
        }
    
        public void AssociatedParts(Part part)
    {
            
                tempProduct.AssociatedParts.Add(part);
           
    }
        public void ModifyProduct(Product product)
    {
        
        add_Product_Name_Field.Text = product.Name;
        add_Product_ID_Field.Text = product.ProductID.ToString();
        add_Product_Inventory_Field.Value = product.InStock;
        add_Product_Price_Field.Value = product.Price;
        add_Product_Max_Field.Value = product.Max;
        add_Product_Min_Field.Value = product.Min;
        tempProduct = product;
        add_Product_Associated_Parts_View.DataSource = tempProduct.AssociatedParts;

    }

        private void add_Product_Save_Button_Click(object sender, EventArgs e)
        {
            
            tempProduct.Name = add_Product_Name_Field.Text;
            tempProduct.Max = Decimal.ToInt32(add_Product_Max_Field.Value);
            tempProduct.Min = Decimal.ToInt32(add_Product_Min_Field.Value);
            tempProduct.InStock = Decimal.ToInt32(add_Product_Inventory_Field.Value);
            tempProduct.InStock = Decimal.ToInt32(add_Product_Inventory_Field.Value);
            tempProduct.Price = add_Product_Price_Field.Value;
            //if (add_Product_ID_Field.Text == "")
            //{
            //    var tempID = Inventory.Products.Count;
            //    ++tempID;
            //    tempProduct.ProductID = tempID;
            //} else {
            //    tempProduct.ProductID = Convert.ToInt32(add_Product_ID_Field.Text);
            //}
            
            Inventory.addProduct(tempProduct);
            Close();

        }

        private void add_Product_Delete_Button_Click(object sender, EventArgs e)
        {
            if (add_Product_Associated_Parts_View.SelectedRows.Count > 0) { 
            var selectedRow = add_Product_Associated_Parts_View.SelectedRows[0].DataBoundItem as Part;
            tempProduct.removeAssociatedPart(selectedRow.PartID);
            }
            MessageBox.Show("Please Select a part to be removed");
        }
    }
}
