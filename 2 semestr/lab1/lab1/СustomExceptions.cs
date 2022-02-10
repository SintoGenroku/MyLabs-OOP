using System;

namespace lab1
{
    internal class СustomExceptions : Exception
    {
        public СustomExceptions(string message)
            : base(message) { }

    }
}
