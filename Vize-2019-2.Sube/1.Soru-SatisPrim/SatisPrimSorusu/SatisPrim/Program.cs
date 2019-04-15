using System;

namespace SatisPrimSorusu
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("elemam sayısını giriniz ");
            int x = Convert.ToInt16(Console.ReadLine());
            Satis s = new Satis(x);
            s.Prim();
            s.Yazdir();
        }
    }
}