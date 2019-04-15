using System;

namespace _10AdeCalisanYaslari
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] dizi = new int[10];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("{0}. calisanın yasini giriniz", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxYas = 0;
            int maxYasNo = 0;
            int maxYas2 = 0;
            int maxYasNo2 = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > maxYas)
                {
                    maxYas2 = maxYas; //en büyükteki değeri önce ikinci en büyüğe alıyoruz
                    maxYasNo2 = maxYasNo;
                    maxYas = dizi[i];
                    maxYasNo = i + 1;
                }
                else if (dizi[i] > maxYas2)
                {
                    maxYas2 = dizi[i];
                    maxYasNo2 = i + 1;
                }
            }

            Console.WriteLine("Yası en büyük olan kisi {0}. kisidir ve yasi={1}", maxYasNo, maxYas);
            Console.WriteLine("Yası en büyük olan ikinci kisi {0}. kisidir ve yasi={1}", maxYasNo2, maxYas2);
        }
    }
}