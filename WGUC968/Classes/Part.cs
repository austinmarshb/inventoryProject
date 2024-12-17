using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGUC968.Classes
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        protected Part(int partID, string name, decimal price, float stock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
        }

        public Part NewPart { get; private set; }

        //for testing, remove later
        public abstract void DisplayInfo();
    }
}