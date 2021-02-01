using System.ComponentModel;
using System.Linq;

namespace TraditionalArchitecture.WinFormsUI
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock {get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part part) {
            AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int id) { 
        var partToDelete = AssociatedParts.SingleOrDefault(x => x.PartID == id);
            if (partToDelete != null)
            {
                AssociatedParts.Remove(partToDelete);
                return true;
            }
            else {
                return false;
            }
        }
        public Part lookUpAssociatedPart(int id) {
            return AssociatedParts.Single(x => x.PartID == id);
        }
    }
}
