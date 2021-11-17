using System;
using System.Collections.Generic;
using System.Linq;

namespace lab11
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Месяца
            int i = 1;
            string[] months = 
            {
                "January",
                "February",
                "March",
                "April", 
                "May", 
                "June", 
                "July", 
                "August", 
                "September", 
                "October", 
                "November",
                "December" 
            };
            var sortedmonth = months.OrderBy(x => x).Select(x=>$"{i++} {x}");
            var monthlen = months.Where(x => x.Length == 8);
            var withN = months.Where(x => x.Contains("n") | x.Contains("N"));
            var longname = months.Where(x=> x.Length>4);

            Console.WriteLine("Sorted months");            
            foreach (var item in sortedmonth)
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine("\nMonths with lenth 8");           
            foreach (var item in monthlen)
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine("\nMonths with letter N");          
            foreach (var item in withN)
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine("\nMonths with name 4 and longer");
            foreach (var item in longname)
            {
                Console.WriteLine($"\t{item}");
            }
            Console.WriteLine();
            #endregion

            #region Рейсы
            Airline dream = new Airline("Prague", 759211, "Airbus A310", 13.15, "Wednesday");
            Airline bane = new Airline("Novocheboksarsk", 228322, "The Lastochka", 8.05, "Thursday");
            Airline Russia = new Airline("Saransk", 264812, "The Lastochka", 4.05, "Friday");
            Airline Germany = new Airline("Dortmund", 683190, "Airbus A280", 19.45, "Wednesday");
            Airline Poland = new Airline("Krakov", 759211, "Airbus A310", 23.55, "Sunday");
            Airline Vacation = new Airline("Budapest", 497234, "Airbus A310", 16.35, "Friday");
            Airline Vacation2 = new Airline("Budapest", 499530, "Airbus A280", 6.35, "Wednesday");
            Airline Vacation3 = new Airline("Budapest", 437231, "Airbus A310", 9.55, "Thursday");
            Airline Vacation4 = new Airline("Budapest", 499530, "Airbus A280", 6.35, "Friday");

            List<Airline> flights = new List<Airline>() { dream, bane, Germany, Poland, Vacation, Vacation2, Vacation3, Vacation4 };

            var toBudapest = flights.Where(x =>x.Dest == "Budapest");
            var inWednesday = flights.Where(x=>x.Day == "Wednesday");
            var earliest = flights.Where(x=>x.Day == "Thursday").OrderBy(x=>x.Time).Take(1);
            var latest = flights.Where(x => x.Day == "Wedensday" | x.Day == "Friday").OrderBy(x => x.Time).Take(1);
            var sorted = flights.OrderBy(x => x.Time);

            Console.WriteLine("Flights in Budapest for a week:");
            foreach (var item in toBudapest)
            {
                Airline.Info(item);
            }

            Console.WriteLine("All flights in Wednesday:");
            foreach (var item in inWednesday)
            {
                Airline.Info(item);
            }

            Console.WriteLine("Earliest flight in Thursday:");
            foreach(var item in earliest)
                {
                    Airline.Info(item);
                }
            
            Console.WriteLine("Latest flight in Friday or Wedesday:");
            foreach (var item in latest)
            {
                Airline.Info(item);
            }
           
            Console.WriteLine("Sorted flights:");
            foreach (var item in sorted)
            {
                Airline.Info(item);
            }
            #endregion

        }
    }
}
