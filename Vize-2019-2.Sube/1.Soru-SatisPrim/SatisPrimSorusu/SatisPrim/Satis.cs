using System;

namespace SatisPrimSorusu
{
    public class Satis
    {
        private const int gunSayisi = 3;//Normalde 30 test etmek için küçük değer atanmıştır.
        private int elemanSayisi = 0;
        private int[,] primler; //iki boyutlu bir dizi referansı(yani dizi tutacak bir değişken aşağıda kurucu method içerisinde karşısına tutacağı dizi tanımlandı)

        public Satis(int k)
        {
            elemanSayisi = k;
            primler = new int[k, 3]; //buradaki k kurucu methodla main kısmında aldığımız eleman sayisi,3 de kategori sayisi 3 tane old. soruda verilmiş
        }

        public void Prim()
        {
            int x;

            for (int i = 0; i < gunSayisi; i++)
            {
                for (int j = 0; j < elemanSayisi; j++)
                {
                    Console.Write("{0}. elemanın {1}. günün satışını giriniz ", j + 1, i + 1);
                    x = Convert.ToInt16(Console.ReadLine());

                    if (x <= 2000 && x >= 1000)
                    {
                        primler[j, 0]++;
                    }
                    else if (x < 3000 && x > 2000)
                    {
                        primler[j, 1]++;
                    }
                    else if (x > 3000)
                    {
                        primler[j, 2]++;
                    }
                    else
                    {
                        Console.WriteLine("prim hakkı kazanamadınız");
                    }
                }
            }
        }

        public void Yazdir()
        {
            int primToplam;
            for (int i = 0; i < elemanSayisi; i++)
            {
                for (int s = 0; s < 3; s++)
                {
                    Console.WriteLine("{0}. elemanSayisi {1} kategoriden {2} satış yapmıştır.", i + 1, s + 1, primler[i, s]);
                }
                primToplam = primler[i, 0] * 200 + primler[i, 1] * 400 + primler[i, 2] * 600;

                Console.WriteLine("{0}. elemanın prim toplamı {1} dir", i + 1, primToplam);
            }
        }
    }
}