using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class Luggage
    {
        public void LuggageWeight()
        {
            
            Console.WriteLine("FirstClass - 1\nBusinessClass - 2\nEconomyClass - 3\n");
            Console.Write("Choose the class options given: ");
            int ClassChoice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of Kgs: ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (ClassChoice == 1)
            {
                double value = a - 50;
                Console.WriteLine("Extra Luggage Charges for first class passengers for the weight input are as follows: " + (value * 2) + "$");
            }

            if (ClassChoice == 2)
            {
                double value = a - 40;
                Console.WriteLine("Extra Luggage Charges for Business class passengers for the weight input are as follows: " + (value * 2) + "$");
            }

            if (ClassChoice == 3)
            {
                double value = a - 20;
                Console.WriteLine("Extra Luggage Charges for Economy class passengers for the weight input are as follows: " + (value * 2)+ "$");
            }
        }
    }
}
