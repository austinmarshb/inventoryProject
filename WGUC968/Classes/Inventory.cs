using System.ComponentModel;

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

        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int productID)
        {
            Products.RemoveAt(productID);
            return true;
        }

        public static Product lookupProduct(int id)
        {
            Product product = null;
            for (int i = 0; i < Products.Count; i++)
            {
                if (id == Products[i].ProductID)
                {
                    _ = products[i];
                }
            }
            return product;
        }

        public static void updateProduct(int id, Product product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (id == Products[i].ProductID)
                {
                    removeProduct(id);
                }
                addProduct(product);
            }
        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool deletePart(Part part)
        {
            AllParts.Remove(part);
            return true;
        }

        public static Part lookupPart(int id)
        {
            Part part = null;
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (id == AllParts[i].PartID)
                {
                    _ = AllParts[i];
                }
            }
            return part;

        }

        public static void updatePart(int id, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (id == AllParts[i].PartID)
                {
                    deletePart(AllParts[i]);
                }
                addPart(part);
            }
        }

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