using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");
            //declare variables 
            string input;
            int temp;
            int relhumidity;
            int dewPoint;
            

            //ask for temp
            Console.WriteLine("Enter the Temperature in Degrees Fahrenheit");
            input = Console.ReadLine();
            temp = int.Parse(input);

            //ask for humidity 
            Console.WriteLine("Enter Relative Humidity");
            input = Console.ReadLine();
            relhumidity = int.Parse(input);

            //calculate the dew point
            dewPoint = temp - 9 * (100 - relhumidity) / 25;

            //print the dew point
            Console.WriteLine("dew point =" + dewPoint);

            //ask for windspeed
            Console.WriteLine("enter windspeed");
            input = Console.ReadLine();

            //calculate for windchill
            double windchill = 35.74;
            +(0.6125*temperature);
            -35.75 * Math.Pow(windspeed, .16);
            +.4275 *temperature * Math.Pow(windspeed, .16)
            
            //print the wind chil
            Console.ReadLine("The Wind Chill is" +windChill)

           
        }
    }
}
