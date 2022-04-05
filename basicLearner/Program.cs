using System;

namespace basicLearner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string firstName;
            string age;

            Console.Write("Enter name");
            firstName = Console.ReadLine();
            Console.Write("Enter Age");
            age = Console.ReadLine();

            Console.WriteLine(firstName);
            Console.WriteLine(age);
        }
    }
}
