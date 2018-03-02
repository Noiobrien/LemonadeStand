using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemondadeStand
{
    public class Weather
    {
        //variables
        public string weather;
        public int daysOpen;
        public int temperature;



        //constructor

        

        public void getWeather()
        {
            //string weather = 
            Random random = new Random();
            List<string> weather = new List<string>();
            weather.Add("sunny");
            weather.Add("hot");
            weather.Add("rainy");
            weather.Add("cloudy");
            int choice = random.Next(0, 4);
            this.weather = weather[choice];
        }

            
        public void getDays()
        {
            Console.WriteLine("Enter How Many Days Are You Open?");
            Console.ReadLine();

            string userinput = Console.ReadLine();
            Console.WriteLine("Enter How Many Days Are You Open" + userinput);
            Console.ReadLine();




            

            //int day = Console.ReadLine();
            }
            //public void getTemperature()
            //{
            //Random random = new Random();

            //}









            //this.temperature }
            //method
            //switchcase

        }
}



