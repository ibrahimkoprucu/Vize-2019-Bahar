using System;

namespace KDegiskeni
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int k = -25;

            do
            {
                if (k == -10)
                {
                    break;
                }

                k++;
            } while (k < 10);

            Console.WriteLine("Çalışma Tamamlanmiştir");
        }
    }
}