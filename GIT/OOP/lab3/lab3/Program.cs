using System;

namespace lab3
{
    class Program
    {
        class Airline
        {
          public  string destination;
          public  int? flightNumber;
          private  string planeType;
          public  string departureTime;
          public  string days;
          private readonly int id = 0;
          private const string airlineName = "S7 Airlines";

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
            }
            public Airline(string dest)     //2nd constructor
            { 
                destination = dest; 
                flightNumber = null; 
                planeType = "---"; 
                departureTime = "---"; 
                days = "---"; 
            }
            public Airline(string dest, int number, string plane, string time, string d) {
                destination = dest;     //3rd constructor
                flightNumber = number;
                planeType = plane;
                departureTime = time;
                days = d;
                id++;
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
