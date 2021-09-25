using System;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
           #region types
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



            var car = new { Mark = "Porsche", Color = "gray", Price = 100000 };
            Console.WriteLine($"I've just bought {car.Color} {car.Mark} for {car.Price} dollars!!!");
            //car.Color = "red"; error because car has anonymous type
            //(anonymous object properties are available for setting only in the initializer)
            #endregion
            #region strings
            
            string str1 = "abc";
            string str2 = "def";
            int res = str1.CompareTo(str2);
            if (res > 0)
            {
                Console.WriteLine("1st str is bigger than 2nd");
            }
            else if (res < 0)
            {
                Console.WriteLine("1st str is less than 2nd");
            }
            else 
            { 
                Console.WriteLine("It's equals");
            }
            string s1 = new string("string number one");
            string s2 = new string("string number two");
            string s3 = new string("string number three");
            Console.WriteLine(String.Concat(s1, s2));
            string not_s1 = String.Copy(s1);
            Console.WriteLine(not_s1);
            Console.WriteLine(s1.Contains("one"));
            var s = s3.Split(' ');
            foreach (var word in s)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(s3.Insert(7, "blablabla "));
            Console.WriteLine(s3.Remove(13));
            string substr = s2.Substring(4);
            Console.WriteLine(substr);
            Console.WriteLine($"1){s1}\n2){s2}");

            string emptystr = "";
            string nstr = null;
            Console.WriteLine($"{string.IsNullOrEmpty(emptystr)}\n{string.IsNullOrEmpty(nstr)}");

            StringBuilder sb = new StringBuilder(" world!");
            Console.WriteLine(sb);
            sb.Append("<3");
            sb.Insert(0, "Hello");
            Console.WriteLine(sb);
            sb.Remove(6, 6);
            Console.WriteLine(sb);

            #endregion
            #region arrays

            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            foreach (int e in arr)
            {
                Console.Write($"{e} ");
            }
            Console.Write($"\nLenght of array: {arr.Length}\nEnter position: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            arr[pos-1] = number;
            foreach (int e in arr)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
            string[][] nums = new string[3][];
            nums[0] = new string[2] { "a", "b" };
            nums[1] = new string[3] { "c", "d", "e" };
            nums[2] = new string[4] { "f","g","h","i", };
            foreach (string[] row in nums)
            {
                foreach (string letter in row)
                {
                    Console.Write($"{letter} \t");
                }
                Console.WriteLine();
            }
            var vstr = "qwerty";
            var v_arr = new[]{1,2,3 };
            #endregion*/

          /*  #region cortege

            (int, string, char, string, ulong) tuple = (5, "five", 'f', "number", 5555555555);
            Console.WriteLine($"2){tuple.Item2}\n4){tuple.Item4}\n5){tuple.Item5}");
            Console.WriteLine($"All cortege{tuple}");

            var magicBox = ( letter: 'c', str: "it's str baby", number: 23);
            object packed = magicBox;
            (char, string, int) unpacked = (( char, string, int))packed;
            Console.WriteLine($"Unpacked cort {unpacked.Item3} ");

            var (letter, str, number) = unpacked;

            (int, int, int, char) func(int[] arr, string word)
            {
                int min = int.MaxValue;
                int max = int.MinValue;
                int sum = 0;
                foreach (var item in arr)
                {
                    sum += item;
                    if (item > max)
                    {
                        max = item;
                    }
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return (max, min, sum, word[0]);
            }

            var resFunc = func(new int[4] { 1, 2, 3, 4 }, "bye");
            Console.WriteLine($"{resFunc.Item1} {resFunc.Item2} " +
                $"{resFunc.Item3} {resFunc.Item4}");

            void local1()
            {
                int check = checked((int)2147483647);
            }
            void local2()
            {
                int check = unchecked((int)2147483647);
            }

            #endregion
       */ }

    }
}
