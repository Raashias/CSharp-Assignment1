using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To FlyHighAirlines");
            Console.WriteLine("1.Indigo\n2.AirIndia\n3.JetAirways");
            Console.Write("Selects Flights among the given list: ");
            String abs = Console.ReadLine();
            BookETickets tickets = new BookETickets();
            tickets.setFlights(abs);
            String ret = tickets.getFlights();
            Console.Write("Enter the From location: ");
            String res =  tickets.FromPlace();
            Console.Write("Enter the To location: ");
            String res1 = tickets.ToPlace();
            Console.Write("Enter date of Departure: ");
            String res2= tickets.DepartureDate();
            int res3 = tickets.Price();
            Console.WriteLine();
            Console.WriteLine("You have chosen " + ret + " Airlines");
            Console.WriteLine("Flight Check-in Location is " + res);
            Console.WriteLine("Flight Check-out Location is " + res1);
            Console.WriteLine("Date of Departure is: " + res2 );
            Console.WriteLine("Price Details for the chosen journey is: " + res3 + " Rs");
            Console.WriteLine();
            Luggage obj = new Luggage();
            obj.LuggageWeight();
            Console.WriteLine();
            ViewMaintenance obt = new ViewMaintenance();
            obt.Maint();



            Console.ReadLine();
        }
        
    }
}
