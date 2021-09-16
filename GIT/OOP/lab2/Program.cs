using System;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLabPassed = true;
            int intNumber = 15;
            uint uintNumber = 123456789U;
            float floatNumber = 54.3F;
            double doubleNumber = 6.66;
            long longNumber = 999999999999999L;
            ulong ulongNumber = 888888888888888888UL;
            byte byteNumber = 255;
            sbyte sbyteNumber = -128;
            short shortNumber = -32;
            ushort ushortNumber = 65;
            char Symbol = 'q';
            string strOfDream = "Awesome! Your mark is 10!";
            string str = "54";
            Console.WriteLine($" bool: {isLabPassed}\n int: {intNumber}\n byte: {byteNumber}\n double: {doubleNumber}\n long:{longNumber}\n string: {strOfDream}\n char: {Symbol}\n etc.");

            //implicit conversion
            intNumber = Symbol;
            doubleNumber = intNumber;
            floatNumber = byteNumber;
            longNumber = shortNumber;
            uintNumber = ushortNumber;

            //explicit conversion
            intNumber = (int)floatNumber;
            Symbol = (char)doubleNumber;
            byteNumber = (byte)sbyteNumber;
            ushortNumber = (ushort)uintNumber;
            longNumber = (long)shortNumber;

            try
            {
                isLabPassed = Convert.ToBoolean(intNumber);
            }

            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
            }
            try
            {
                intNumber = Convert.ToInt32(str);
            }
            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
            }

            Console.WriteLine($"{isLabPassed}, {intNumber} changed by Convert ");

            //packing
            int i = 99;
            object obj = i;
            //unpacking
            int n = (int)obj;
            
            dynamic dyn = "i'm dynamic str";
            dyn = true;
            Console.WriteLine(dyn);

            int ? mbNull = 8;
            int ? l = null;

        }

    }
}
