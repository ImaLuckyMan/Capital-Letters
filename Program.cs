using System;

namespace Capital_Letters_in_Given_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberCapitals("Welcome To The Jungle"));
        }

        public static int NumberCapitals(string Capital)
        {
            int count=0; 

            foreach(var s in Capital)
            {
                if (char.IsUpper(s))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
