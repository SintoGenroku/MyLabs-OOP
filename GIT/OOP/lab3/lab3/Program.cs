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

            public Airline() { destination = "---"; flightNumber = null; planeType = "---"; departureTime = "---"; days = "---"; }//1st constructor
            public Airline(string dest) { destination = dest; flightNumber = null; planeType = "---"; departureTime = "---"; days = "---"; }//2nd constructor
            public Airline(string dest, int number, string plane, string time, string d) {
                destination = dest;
                flightNumber = number;
                planeType = plane;
                departureTime = time;
                days = d; 
            }//3rd constructor


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
