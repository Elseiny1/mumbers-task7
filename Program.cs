using System;

namespace numbers
{
    public class program
    {
        public static void Main()
        {
            Console.Write("Enter number: ");
            int number=int.Parse(Console.ReadLine()); 
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}