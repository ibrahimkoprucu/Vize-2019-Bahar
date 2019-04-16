using System;

namespace FuarStandlar
{
    public class Etkinlik
    {
        private int[,] standlar;

        private int standSayisi;
        private int toplamCalisanSayisi = 0;
        private int[,] calisanlar;
        private string[] cinsiyet = { "erkek", "kadin" };
        private string[] konu = { "yazılım", "donanım", "yapay zeka" };

        public Etkinlik(int k)
        {
            standlar = new int[k, 4];//stand alanı,konu,kisiSayisi,ziyaretci Sayisi

            standSayisi = k;
        }

        public void BilgiAl()
        {
            for (int i = 0; i < standSayisi; i++)
            {
                Console.WriteLine("{0}. standın alan bilgisini giriniz(1-2-3)", i + 1);//10 m2,15 m2,üstü
                standlar[i, 0] = int.Parse(Console.ReadLine());

                Console.WriteLine("{0}. standın konu bilgisini giriniz(1-2-3)", i + 1);
                standlar[i, 1] = int.Parse(Console.ReadLine());

                Console.WriteLine("{0}. standın calisan sayisi bilgisini giriniz", i + 1);
                int kisiSayisi = int.Parse(Console.ReadLine());
                standlar[i, 2] = kisiSayisi;
                toplamCalisanSayisi += kisiSayisi;

                Console.WriteLine("{0}. standın ziyaretci sayisi bilgisini giriniz", i + 1);
                standlar[i, 3] = int.Parse(Console.ReadLine());
            }
            calisanlar = new int[toplamCalisanSayisi, 3];

            for (int i = 0; i < standSayisi; i++)
            {
                for (int j = 0; j < standlar[i, 2]; j++)//her standın kişi sayisi standlarin 2.sütununda idi
                {
                    calisanlar[j, 0] = i;

                    Console.WriteLine("{0}. standın {1}.kisinin yasini giriniz", i + 1, j + 1);
                    calisanlar[j, 1] = int.Parse(Console.ReadLine());

                    Console.WriteLine("{0}. standın {1}.kisinin cinsiyetini giriniz(1-erkek,2-kadın)", i + 1, j + 1);
                    calisanlar[j, 2] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void OrtalamaHesapla()//3.Soru
        {
            double kadinOrtalama = ToplamKadinSayisiBul() / standSayisi;
            double ErkekOrtalama = ToplamErkekSayisiBul() / standSayisi;

            Console.WriteLine("Kadın ortalama={0}", kadinOrtalama);
            Console.WriteLine("Erkek ortalama={0}", ErkekOrtalama);
        }

        private int ToplamKadinSayisiBul()//yardımcı method private Ortamabul methodunda kullandık
        {
            int sayac = 0;

            for (int i = 0; i < toplamCalisanSayisi; i++)
            {
                if (calisanlar[i, 2] == 2)
                {
                    sayac++;
                }
            }

            return sayac;
        }

        private int ToplamErkekSayisiBul()//aynı şekilde yardımcı method
        {
            return toplamCalisanSayisi - ToplamKadinSayisiBul();
        }

        public void MetreKareZiyaretciBul()//2.Soru
        {
            int onluk = 0;
            int onbeslik = 0;

            for (int i = 0; i < standSayisi; i++)
            {
                if (standlar[i, 0] == 1)
                {
                    onluk += standlar[i, 3];
                }
                if (standlar[i, 0] == 2)
                {
                    onbeslik += standlar[i, 3];
                }
            }

            Console.WriteLine("10 m2 lik standı ziyaret eden toplam kişi sayisi={0}", onluk);
            Console.WriteLine("15 m2 lik standı ziyaret eden toplam kişi sayisi={0}", onbeslik);
        }

        public void EnyasliCalisanBul()//4.Soru
        {
            int enYasliKadin = 0;
            int enYasliErkek = 0;
            int enYasliKadinStandNo = 0;
            int enYasliErkekStandNo = 0;

            for (int i = 0; i < toplamCalisanSayisi; i++)
            {
                if (calisanlar[i, 1] == 1) //kadınsa
                {
                    if (calisanlar[i, 1] > enYasliKadin)//en yasli buldurma
                    {
                        enYasliKadin = calisanlar[i, 1];
                        enYasliKadinStandNo = calisanlar[i, 0];
                    }
                }
                else if (calisanlar[i, 1] == 2) //erkek olanlar
                {
                    if (calisanlar[i, 1] > enYasliErkek)
                    {
                        enYasliErkek = calisanlar[i, 1];
                        enYasliErkekStandNo = calisanlar[i, 0];
                    }
                }
            }

            Console.WriteLine("En yasli kadin {0}.standda çalışmaktadır ve yasi:{1}", enYasliKadinStandNo, enYasliKadin);
            Console.WriteLine("En yasli erkek {0}.standda çalışmaktadır ve yasi:{1}", enYasliErkekStandNo, enYasliErkek);
        }

        public void EnFazlaZiyaretEdilen2StandıBul()//1.Soru
        {
            int max1 = 0;
            int maxStandNo1 = 0;
            int max2 = 0;
            int maxStandNo2 = 0;

            for (int i = 0; i < standSayisi; i++)
            {
                if (standlar[i, 3] > max1)
                {
                    max2 = max1;
                    maxStandNo2 = maxStandNo1;
                    max1 = standlar[i, 3];
                    maxStandNo1 = i;
                }
                else if (standlar[i, 3] > max2)
                {
                    max2 = standlar[i, 3];
                    maxStandNo2 = i;
                }
            }

            Console.WriteLine("---En fazla ziyaret edilen standın bilgileri:---");

            Console.WriteLine("Standın Konusu {0}", konu[standlar[maxStandNo1, 1] - 1]);

            for (int i = 0; i < toplamCalisanSayisi; i++)
            {
                if (calisanlar[i, 0] == maxStandNo1)
                {
                    Console.WriteLine("{0}.calisanin yasi:{1} cinsiyeti:{2}", i + 1, calisanlar[i, 1], cinsiyet[calisanlar[i, 2] - 1]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("---En fazla ziyaret edilen ikinci standın bilgileri:---");

            Console.WriteLine("Standın Konusu {0}", konu[standlar[maxStandNo2, 1] - 1]);

            for (int i = 0; i < toplamCalisanSayisi; i++)
            {
                if (calisanlar[i, 0] == maxStandNo2)
                {
                    Console.WriteLine("{0}.calisanin yasi:{1} cinsiyeti:{2}", i + 1, calisanlar[i, 1], cinsiyet[calisanlar[i, 2] - 1]);
                }
            }
        }
    }
}