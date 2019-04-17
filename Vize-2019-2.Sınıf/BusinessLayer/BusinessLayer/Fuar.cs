using System;

namespace BusinessLayer
{
    public class Fuar
    {
        private int[][] standlar;//jagged array ,array içinde array
        private int standSayisi;
        private int kadinSayisi;
        private int erkekSayisi;
        private string[] konu = { "yazilim", "donanım", "yapay zeka" };
        private int onluk = 0;
        private int onbeslik = 0;

        public Fuar(int k)
        {
            standSayisi = k;
            standlar = new int[k][];
        }

        public void BilgiAl()
        {
            for (int i = 0; i < standSayisi; i++)
            {
                Console.WriteLine("{0}.standın calisan sayisini giriniz", i + 1);
                int k = int.Parse(Console.ReadLine());
                standlar[i] = new int[2 * k + 3]; // k kadar cinsiyet k kadar yas 2*k kadar yer artı 3 de standın diğer bilgileri

                Console.WriteLine("{0}.standın konusunu giriniz (1/2/3)", i + 1);
                standlar[i][0] = int.Parse(Console.ReadLine());

                Console.WriteLine("{0}.standın alanını giriniz (1/2/3)", i + 1);
                standlar[i][1] = int.Parse(Console.ReadLine());

                Console.WriteLine("{0}.standın ziyaretçi sayısını giriniz", i + 1);
                standlar[i][2] = int.Parse(Console.ReadLine());

                if (standlar[i][1] == 1)
                {
                    onluk += standlar[i][2];
                }

                if (standlar[i][1] == 2)
                {
                    onbeslik += standlar[i][2];
                }

                for (int j = 0; j < 2 * k; j += 2)
                {
                    Console.WriteLine("{0}.stanta çalışan {1}. kişinin yaşını giriniz: ", i + 1, j / 2 + 1);
                    standlar[i][j + 3] = int.Parse(Console.ReadLine());

                    Console.WriteLine("{0}.stanta çalışan {1}. kişinin cinsiyetini giriniz(1-E/2-K): ", i + 1, j / 2 + 1);
                    standlar[i][j + 4] = int.Parse(Console.ReadLine());

                    if (standlar[i][j + 4] == 2)
                    {
                        kadinSayisi++;
                    }
                    else
                    {
                        erkekSayisi++;
                    }
                }
            }
        }

        public void OrtalamaBul()
        {
            double kadinOrt = (double)kadinSayisi / standSayisi;
            double erkekOrt = (double)erkekSayisi / standSayisi;

            Console.WriteLine("Kadın ortalama : {0}", kadinOrt);
            Console.WriteLine("Erkek ortalama : {0}", erkekOrt);
        }

        public void EnCokZiyaretEdilenStandBul()
        {
            int max = 0;
            int maxStandIndex = 0;
            int max2 = 0;
            int maxStandIndex2 = 0;

            for (int i = 0; i < standSayisi; i++)
            {
                if (standlar[i][2] > max)
                {
                    max2 = max;
                    maxStandIndex2 = maxStandIndex;
                    max = standlar[i][2];
                    maxStandIndex = i;
                }
                else if (standlar[i][2] > max2)
                {
                    max2 = standlar[i][2];
                    maxStandIndex2 = i;
                }
            }
            string str = konu[standlar[maxStandIndex][0] - 1];
            Console.WriteLine("En cok ziyaret edilen stand:{0},ziyaretci sayisi:{1} ,bu standın konusu:{2}", maxStandIndex + 1, max, str);
            string str2 = konu[standlar[maxStandIndex2][0] - 1];
            Console.WriteLine("En cok ziyaret edilen 2.stand:{0},ziyaretci sayisi:{1} ,bu standın konusu:{2}", maxStandIndex2 + 1, max2, str2);
        }

        public void EnYaslilariBul()
        {
            int enYasliKadinYas = 0;
            int enYasliKadinStandIndex = 0;
            int enYasliErkekYas = 0;
            int enYasliErkekStandIndex = 0;

            for (int i = 0; i < standSayisi; i++)
            {
                for (int j = 3; j < standlar[i].Length - 1; j++)
                {
                    if (standlar[i][j + 1] == 2 && standlar[i][j] > enYasliKadinYas)
                    {
                        enYasliKadinYas = standlar[i][j];
                        enYasliKadinStandIndex = i;
                    }

                    if (standlar[i][j + 1] == 1 && standlar[i][j] > enYasliErkekYas)
                    {
                        enYasliErkekYas = standlar[i][j];
                        enYasliErkekStandIndex = i;
                    }
                }
            }

            Console.WriteLine("En yasli kadinin bulunduğu stand:{0},erkeğin bulunduğu stand:{1}", enYasliKadinStandIndex + 1, enYasliErkekStandIndex + 1);
        }

        public void StandAlanlarınaZiyaretciSayisiBul()
        {
            Console.WriteLine("10 m2 lik standı ziyaret eden:{0} kişidir", onluk);

            Console.WriteLine("15 m2 lik standı ziyaret eden:{0} kişidir", onbeslik);
        }
    }
}