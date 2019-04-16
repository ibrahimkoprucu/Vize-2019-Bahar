using System;

namespace FuarStandlar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Stand Sayisini giriniz");
            int k = int.Parse(Console.ReadLine());

            Etkinlik e = new Etkinlik(k);
            e.BilgiAl();
            e.OrtalamaHesapla();
            e.MetreKareZiyaretciBul();
            e.EnyasliCalisanBul();
            e.EnFazlaZiyaretEdilen2StandıBul();
        }
    }
}