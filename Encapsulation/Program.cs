using System;

namespace Encapsulation
{
    class NewClass
    {
        private string StudentName;
        private int StudentAge;

        public string Name
        {
            get { return StudentName; }
            set { StudentName = value; }
        }

        public int Age
        {
            get { return StudentAge; }
            set { StudentAge = value; }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            NewClass obj1 = new NewClass();

            obj1.Name = "Sai";
            obj1.Age = 27;

            Console.WriteLine("Name : " + obj1.Name);
            Console.WriteLine("Age : " + obj1.Age);
        }
    }
}