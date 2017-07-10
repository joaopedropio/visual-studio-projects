using System;

namespace CSharpEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            int rapaz = 4;
            int papa = 4;
            Console.WriteLine(rapaz.Equals(papa));
            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food chocolate = new Food("banana");
            Console.WriteLine(chocolate.ToString());
            string apple = "apple";
            string apple2 = string.Copy(apple);
            Console.WriteLine(banana == chocolate);

            Console.WriteLine(banana.Equals((object)banana2));
            //Console.WriteLine(banana.Equals(banana2));
            Console.ReadLine();
        }
    }
} 