using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillSplitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string b = "";

            int c = 0;

            Restaurant r = new Restaurant(a,b,c);
            r.GenerateReceipt();
            r.Name = "asd";
            r.TaxRate = 1;

            Console.WriteLine(r.TaxRate);
        }
    }
}
