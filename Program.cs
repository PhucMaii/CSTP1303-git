using System;
using System.Drawing;

namespace week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program was called with");
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Program program = new Program();
            program.PrintNumber();
            int inches = program.FeetToInches(3);
            Console.WriteLine($"3 feet is: {inches} inches.");


            string message = "this is our first program in C#";
            var message2 = "new message";
            var a = 5;
            var arr = new int[] { 1, 2, 3 };
            bool isThisGood = true;

            var p1 = new Point();
            p1.X = 10;
            p1.Y = 12;

        }

        public void PrintNumber()
        {
            Console.WriteLine("this is a test");
            for(int i = 0; i < 10; i++)
                {
                    Console.Write(" ");
                    Console.Write(i);
                }
                Console.WriteLine("End of Loop");
        }

        public int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
        


}