using System;

namespace lab3
{
    class Program
    {
        public partial class Airline
        {
            public string destination;
            public int? flightNumber;
            private string planeType;
            public string departureTime;
            public string days;
            private readonly int? id;
            private const string airlineName = "S7 Airlines";
            private static int count = 0;

            static Airline()
            {
                Console.WriteLine("static constructor worked");
            }
            public Airline()    //1st constructor 
            {
                destination = "---";
                flightNumber = null;
                planeType = "---";
                departureTime = "---";
                days = "---";
                id = null;
            }
            public Airline(string dest)     //2nd constructor
            {
                destination = dest;
                flightNumber = null;
                planeType = "---";
                departureTime = "---";
                days = "---";
                id = null;
            }
            public Airline(string dest, int number, string plane, string time, string d) {
                destination = dest;     //3rd constructor
                flightNumber = number;
                planeType = plane;
                departureTime = time;
                days = d;
                id = dest.GetHashCode() + time.GetHashCode();
                count++;
            }

            public static void Info(Airline obj) 
            {
                Console.WriteLine("Info:");
                Console.WriteLine($"Destunation: {obj.destination}\nFlight number: {obj.flightNumber}\nPPlane type: {obj.planeType}");
                Console.WriteLine($"Departure time:{obj.departureTime}\n Days of flights: {obj.days}\n request ID: {obj.id}");

            }
            public override bool Equals()
                {
                    
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

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
/*string destination = ;
int flightNumber = 759211;
string planeType = "Airbus A310";
string departureTime = "13:15";
string days = "Wednesday, Tuesday, Sunday";*/
