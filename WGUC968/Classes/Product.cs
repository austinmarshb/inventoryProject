using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGUC968.Classes
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public float Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int partID, string name, int stock, float price, int min, int max)
        {
            ProductID = partID;
            Name = name;
            InStock = stock;
            Price = price;
            Min = min;
            Max = max;
        }

        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            var partToRemove = AssociatedParts.FirstOrDefault(p => p.PartID == partID);
            return partToRemove != null && AssociatedParts.Remove(partToRemove);
        }

        public Part lookupAssociatedPart(int partID)
        {
            return AssociatedParts.FirstOrDefault(p => p.PartID == partID);
        }
    }
}