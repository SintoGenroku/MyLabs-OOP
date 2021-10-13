namespace Lab4.DanielXOO
{
    class List
    {
        public int[] Array { get; private set; }
        public int Size { get; private set; }

        public List(int[] arr)
        {
            Array = new int[arr.Length];
            arr.CopyTo(Array, 0);
            Size = Array.Length;
        }
        
        public List(int size)
        {
            Array = new int[size];
            Size = size;
        }
        public int this[int index]
        {
            get
            {
                if( index >= Array.Length)
                {
                    System.Console.WriteLine("Out of array");
                    System.Environment.Exit(1);
                }
                return Array[index];
            }
            set
            {
                if (index >= Array.Length)
                {
                    System.Console.WriteLine("Out of array");
                    System.Environment.Exit(1);
                }
                Array
                    [index] = value;
            }
        }
        public static List operator+ (List obj, int data)
        {
            var tmp = new int[obj.Size + 1];
            for (int i = 0; i < obj.Size; i++)
            {
                tmp[i] = obj[i];

            }
            tmp[tmp.Length - 1] = data;
            return new List(tmp);
        }
        public static List operator --(List obj)
        {
            var tmp = new int[obj.Size - 1];
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = obj[i];
            }
            return new List(tmp);
        }
    }
}
