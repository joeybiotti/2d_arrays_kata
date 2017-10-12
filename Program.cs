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
            
            Console.WriteLine(text[1,2]);
            
            Console.ReadLine();
        }
    }
}
