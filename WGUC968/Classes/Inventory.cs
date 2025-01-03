﻿using System.ComponentModel;

namespace WGUC968.Classes
{
    public static class Inventory
    {
        static private BindingList<Product> products = new BindingList<Product>();

        static public BindingList<Product> Products
        {
            set { products = value; }
            get { return products; }
        }

        static private BindingList<Part> parts = new BindingList<Part>();

        public static BindingList<Part> AllParts
        {
            set { parts = value; }
            get { return parts; }
        }

        static private BindingList<Part> associatedParts = new BindingList<Part>();

        public static BindingList<Part> AssociatedParts
        {
            set { parts = value; }
            get { return parts; }
        }

        public static void AddProduct(Product product)
        {
            Inventory.Products.Add(product);
        }

        public static bool RemoveProduct(int productID)
        {
            Products.RemoveAt(productID);
            return true;
        }

        //public static Product LookupProduct(int productID)
        //{
        //}

        //public static void updateProduct(int index, Product product)
        //{
        //}

        public static void AddPart(Part part)
        {
            Inventory.AllParts.Add(part);
        }

        public static bool DeletePart(Part part)
        {
            AllParts.Remove(part);
            return true;
        }

        //public static Part lookupPart(int partID)
        //{
        //}

        //public static void updatePart(int index, Part part)
        //{
        //}

        public static int PartIDCalculation()
        {

            int idResult = AllParts.Count + 1;
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (idResult == AllParts[i].PartID)
                {
                    idResult = AllParts.Count + 2;
                }
            }
            return idResult;
        }

        public static int ProductIDCalculation()
        {
            int idResult = Products.Count + 1;
            for (int i = 0; i < Products.Count; i++)
            {
                if (idResult == Products[i].ProductID)
                {
                    idResult = Products.Count + 2;
                }
            }
            return idResult;
        }
    }
}