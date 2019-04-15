using System;

namespace BeseBolunenler
{
    public class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 101; i < 151; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(" {0}", i);
                }
            }
        }
    }
}