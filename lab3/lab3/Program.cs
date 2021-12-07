using System;

namespace lab3
{
    public partial class Program
    {
        class Airline
        {
            private string destination;
            private int? flightNumber;
            private string planeType;
            private string departureTime;
            private string day;
            private readonly int? id;
            private const string airlineName = "S7 Airlines";
            private static int count = 0;

            static Airline()
            {
                Console.WriteLine("static constructor worked");
            }

            public string Name
            {
                get
                {
                    return airlineName;
                }
            }
            public string ID
            {
                set
                {
                    ID = value;
                }
            }
            public Airline()    //1st constructor 
            {
                destination = "---";
                flightNumber = null;
                planeType = "---";
                departureTime = "---";
                day = "---";
                id = null;
            }
            public Airline(string dest)     //2nd constructor
            {
                destination = dest;
                flightNumber = null;
                planeType = "---";
                departureTime = "---";
                day = "---";
                id = null;
            }
            public Airline(string dest, int number, string plane, string time, string d) {
                destination = dest;     //3rd constructor
                flightNumber = number;
                planeType = plane;
                departureTime = time;
                day = d;
                id = dest.GetHashCode() + time.GetHashCode();
                count++;
            }

            public static void Info(Airline obj) 
            {
                Console.WriteLine("\nInfo:");
                Console.WriteLine($"\tDestunation: {obj.destination}\n\tFlight number: {obj.flightNumber}\n\tPlane type: {obj.planeType}");
                Console.WriteLine($"\tDeparture time:{obj.departureTime}\n\tDays of flights: {obj.day}\n\tRequest ID: {obj.id}\n");

            }

            public static void Change( ref Airline obj)
            { 
                obj.destination = "Muhosransk";     
            }

            static void Sum(int x, int y, out int a)
            {
                a = x + y;
            }
            public override bool Equals(Object obj)
            { 
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            public static void DayCheck(object[] arr, string buff)
            {
                foreach (Airline e in arr) 
                {
                    if (e.day == buff)
                        Console.WriteLine($"We have flight to {e.destination} on {buff}");
                }
            }

            public static void PlaceCheck(object[] arr, string buff)
            {
                foreach (Airline e in arr)
                {
                    if (e.destination == buff)
                        Console.WriteLine($"Flight to {e.destination} scheduled for {e.day}");
                }
            }
        }
        static void Main(string[] args)
        {   
            Airline dream = new Airline("Prague", 759211,"Airbus A310", "13:15", "Wednesday");
            Airline bane = new Airline("Novocheboksarsk", 228322, "The Lastochka", "8:00", "Tuesday");
            Airline Germany = new Airline("Dortmund", 683190, "Airbus A280", "19:40", "Wednesday");
            Airline Poland = new Airline("Krakov", 759211, "Airbus A310", "23:50", "Sunday");
            var vacation = new { destination = "Turkey", flightNumber = 915638, planeType = "Boeing 712", departureTime = "16:10", day = "Monday"};
            object[] arr = { dream, bane, Germany, Poland };
            string buff;
            
           Console.WriteLine("Enter the day of the week");
            buff = Console.ReadLine();
            Airline.DayCheck(arr, buff);
            Console.WriteLine("*******\n\nEnter place where you want to go");
            buff = Console.ReadLine();
            Airline.PlaceCheck(arr, buff);

            Airline.Info(dream);
            Console.WriteLine("*******\n\nIt was dream\nNow I'll show you pain");
            Airline.Info(bane);
            Program.Services();
            Airline.Change(ref dream);
            Console.WriteLine("*******\n\nThe dream has become a curse");
            Airline.Info(dream);
            Console.WriteLine(dream.Equals(bane));
        }
    }
}

