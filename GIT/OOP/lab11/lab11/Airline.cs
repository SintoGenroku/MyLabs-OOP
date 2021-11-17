using System;
using System.Collections.Generic;
using System.Text;

namespace lab11
{
    class Airline
    {
        private string destination;
        private int flightNumber;
        private string planeType;
        private double departureTime;
        private string day;
        private readonly int id;
        private const string airlineName = "S7 Airlines";
        private static int count = 0;

        public double Time
        {
            get
            {
                return departureTime;
            }
        }

        public string Dest
        {
            get
            {
                return destination;
            }
        }
        public string Day
        {
            get
            {
                return day;
            }
        }
        public int FlightNumber
        {
            get
            {
                return flightNumber;
            }
        }
        
        public Airline(string dest, int number, string plane, double time, string d)
        {
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

        public static void Change(ref Airline obj)
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
}
