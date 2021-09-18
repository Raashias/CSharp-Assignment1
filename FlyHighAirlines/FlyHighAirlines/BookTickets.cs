using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class BookTickets
    {
        private string FlightName;

        public void setFlights(String FlightName)
        {
            this.FlightName = FlightName;
        }

        public String getFlights()
        {
            return FlightName;
           
        }

    }

    class BookETickets : BookTickets

    {

        private String From, To, Date;
        private int pricey;
        public String FromPlace() 
        {
            From = Console.ReadLine();
            return From;
        }
        public String ToPlace()
        {
            To = Console.ReadLine();
            return To;
        }

        public String DepartureDate()
        {
            Date = Console.ReadLine();
            return Date;
        }

        public int Price()
        {
            pricey = 4015;
            return pricey;
        }
        
    }

}

