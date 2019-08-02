using System;

namespace sharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop from 1 to 5 including 5
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            
            for (int i = 1; i<=100; i++)
            {
                if (i%3 ==0 && i%5 == 0)
                {
                    Console.WriteLine("What Are The Chances");
                }
                
                else if (i%3 ==0 || i%5 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }






        }
    }
}
