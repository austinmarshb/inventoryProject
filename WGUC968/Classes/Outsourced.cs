using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGUC968.Classes
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
            : base(partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

        //for testing, remove later
        public override void DisplayInfo()
        {
            Console.WriteLine($"Outsourced Part ID: {PartID}, Name: {Name}, Company: {CompanyName}");
        }
    }
}