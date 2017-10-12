using System;

namespace arrays_2d
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] text =
            {
                {"one", "two", "three"},
                {"fish", "cats", "dogs"}
            };

            for(int row = 0; row < 2; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    Console.Write("{0}\t", text[row, col]);
                }
            }
            
            Console.WriteLine(text[1,2]);
            
            Console.ReadLine();
        }
    }
}
