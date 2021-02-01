using System.ComponentModel;
using System.Linq;

namespace OnionArchitecture.WinFormsUI
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public void addProduct(Product product) {
            var id = Products.OrderBy(x => x.ProductID).Last().ProductID;
            product.ProductID = ++id;
            Products.Add(product);
        }
        public bool removeProduct(int id) {
            var productToDelete = Products.SingleOrDefault(x => x.ProductID == id);
            if (productToDelete != null)
            {
                Products.Remove(productToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Product lookupProduct(int id) {
            return Products.Single(x => x.ProductID == id);
        }
        public void updateProduct(int id, Product product) {
            Products.Remove(Products.FirstOrDefault(x => x.ProductID == id));
            Products.Add(product);
        }
        public void addPart(Part part) {
            var id = AllParts.Any()? AllParts.OrderBy(x => x.PartID).Last().PartID : 0;
            part.PartID = ++id;
            AllParts.Add(part);
        }
        public bool deletePart(Part part) {
            if (part != null)
            {
                AllParts.Remove(part);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Part lookUpPart(int id) {
            return AllParts.Single(x => x.PartID == id);
        }
        public void updatePart(int id, Part part) {
            deletePart(lookUpPart(id));
            AllParts.Add(part);
        }

    }
}
