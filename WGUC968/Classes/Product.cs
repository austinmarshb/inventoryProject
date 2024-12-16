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
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

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