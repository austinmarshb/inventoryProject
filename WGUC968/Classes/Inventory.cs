using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGUC968.Classes
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public void addProduct(Product product)
        {
            Products.Add(product);
        }

        public bool removeProduct(int productID)
        {
            var productToRemove = Products.FirstOrDefault(p => p.ProductID == productID);
            return productToRemove != null && Products.Remove(productToRemove);
        }

        public Product lookupProduct(int productID)
        {
            return Products.FirstOrDefault(p => p.ProductID == productID);
        }

        public void updateProduct(int index, Product product)
        {
            Products[index] = product;
        }

        public void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool deletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public Part lookupPart(int partID)
        {
            return AllParts.FirstOrDefault(p => p.PartID == partID);
        }

        public void updatePart(int index, Part part)
        {
            AllParts[index] = part;
        }
    }
}