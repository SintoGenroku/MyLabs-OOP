using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    
        class UserException : Exception
        {
            public UserException(string message)
            : base(message)
            { }
        }

        class FigureException : Exception
        {
            public FigureException(string message)
            : base(message)
            { }
        }


    class User
    {
        private string name
        {
            get { return name; }
            set
            {
                if (value == "Dima" || value == "Dmitry" || value == "Дима")
                    throw new UserException("Пашол вон, пёс");
                else
                    name = value;
            }
        }
        private string surname { get; set; }
        private int age { get; set; }

        public User(string n, string sn, int a)
        {
            name = n;
            surname = sn;
            age = a;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"\nName: {name} \nSurname{surname} \n Age: {age}\n");
        }
    }
}
