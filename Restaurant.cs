using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillSplitApp
{
    class Restaurant
    {
        //set the instance variables as private
        //dont want anyone getting direct access to these
        private string name;
        private string address;
        private int taxRate;

        //constructor
        // to initialize but not directly use instance variables 
        // so use below three parameters
        public Restaurant(string name, string address, int taxRate)
        {
            this.name = name;
            //same as 
            //Name = name;

            this.address = address;
            this.taxRate = taxRate;
        }

        //properties
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int TaxRate { get => taxRate; set => taxRate = value; }

        //method 
        public void GenerateReceipt()
        {
            Console.WriteLine("Taco Ralenque\n1200 Main Street");
            Console.WriteLine("-------------------------------------------");

            double price = 0;
            double subTotal = 0;
            double total = 0;

            Console.WriteLine("Enter price of food item [-1 to quit]: ");

            while (price != -1)
            {
                price = Convert.ToDouble(Console.ReadLine());

                if (price != -1)
                {
                    subTotal += price;
                }
            }

            Console.WriteLine("How many people in your party?: ");
            int partyNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Subtotal: $ " + subTotal);
            Console.WriteLine("Tax rate(15%): $" + subTotal * 0.15);
            total = subTotal + (subTotal * 0.15);

            Console.WriteLine("Total: $" + total);


        }
    }
}
