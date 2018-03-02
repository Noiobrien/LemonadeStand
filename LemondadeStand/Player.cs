using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemondadeStand
{
    
    class Player
    {
        //variables
        public string name;
        public Player Player1;
        public string weather;
        public int days;
        public double price;
        public int sugarAmount;
        public int iceAmount;
        public int lemonAmount;
        

        //constructor
        
        public void getname()
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
        }
        public void getrecipe()
        {
            Console.WriteLine("Choose [1]Lemon, [2]Sugar, [3]Ice,");
            string recipe = Console.ReadLine();
            switch(recipe)
            {
                case "1":
                    ;
                    break;
            }

            
            //case "1":
            //Choose lemons;
            //break;
            //case 
        }

     
        public void getPrice()

        {
            Console.WriteLine("Enter Your Lemondade Price");
            //double price = Console.ReadLine();
            
        }
        
        
        

     

        //method


    }
}
