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
        private BindingList<Part> PartList = new BindingList<Part>();

        public BindingList<Part> AssociatedParts
        {
            get { return PartList; }
            set { PartList = value; }
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public Product(int productID, string name, int stock, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name.ToLower();
            InStock = stock;
            Price = price;
            Min = min;
            Max = max;
        }

        public Product()
        {
            AssociatedParts = new BindingList<Part>();
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int id)
        {
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == id)
                {
                    AssociatedParts.Remove(AssociatedParts[i]);
                    return true;
                }
            }
            return false;
        }

        public Part lookupAssociatedPart(int id)
        {
            Part result = null;
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == id)
                {
                    _ = AssociatedParts[i];

                }
            }
            return result;
        }
    }
}