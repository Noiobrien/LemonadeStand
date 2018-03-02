using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemondadeStand
{
    class Store
    {
        //variables
        public double Profit;
        public int Customers;
        public double BuyLemon;
        public double LemonCost;
        public string Recipe;
        Random random = new Random();

        //constructor



        public void getrecipe()
        {
            Console.WriteLine("Choose [1]Lemon, [2]Sugar, [3]Ice,");
            string recipe = Console.ReadLine();
            switch (recipe)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
            }
        }
        public void getLemonCost()
        {

        }

        public void getCustomers()
        {

        }

        //method
        //list of lemons
        //loop for lemons
        //cost of lemons = .10
        //try,catch,throw
    }
}
