using BusinessLayer;
using System;

namespace StandSorusu
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("stand sayisini giriniz");
            int k = Convert.ToInt32(Console.ReadLine());

            Fuar f = new Fuar(k);
            f.BilgiAl();
            f.OrtalamaBul();
            f.EnCokZiyaretEdilenStandBul();
            f.EnYaslilariBul();
            f.StandAlanlarınaZiyaretciSayisiBul();
        }
    }
}