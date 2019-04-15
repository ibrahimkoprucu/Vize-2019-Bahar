using System;

namespace LastikFabrikasi
{
    public class Uretim
    {
        private const int haftaSayisi = 2;//const sabit değişken tanımlar.

        private const int gunSayisi = 2;

        public int[,] uretimMiktari = new int[haftaSayisi, gunSayisi]; //2.boyutlu bir dizi yukarıdaki tanımlamayı yapmadan direkt 4,5 verebilirsin

        public void BilgiAl()
        {
            for (int i = 0; i < haftaSayisi; i++)
            {
                Console.WriteLine("----------{0}.hafta bilgileri alınacak---------", i + 1);

                for (int j = 0; j < gunSayisi; j++)
                {
                    Console.Write("{0} gun satiş tutarını giriniz:", j + 1);
                    uretimMiktari[i, j] = Convert.ToInt32(Console.ReadLine());//int olarak aldım decimal veya double olabilirdi
                }
            }
        }

        public void UretimYapılmayanGunBul() //a. şıkkı
        {
            Console.WriteLine("Uretim yapılmayan günler:");
            int counter = 0;
            for (int i = 0; i < haftaSayisi; i++)
            {
                for (int j = 0; j < gunSayisi; j++)
                {
                    if (uretimMiktari[i, j] == 0)
                    {
                        Console.WriteLine("{0}.hafta {1}.gün", i + 1, j + 1);
                        counter++;
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Üretim Yapilmayan gün yoktur");
            }
        }

        public void EnAzUretimYapilanGunBul()
        {
            int minMiktar = uretimMiktari[0, 0];
            int minHaftaNo = 1;//if e girmemesi durumunda 0 yazmasın
            int minGunNo = 1;

            for (int i = 0; i < haftaSayisi; i++)
            {
                for (int j = 0; j < gunSayisi; j++)
                {
                    if (uretimMiktari[i, j] < minMiktar)
                    {
                        minMiktar = uretimMiktari[i, j];
                        minHaftaNo = i + 1;
                        minGunNo = j + 1;
                    }
                }
            }

            Console.WriteLine("En az üretim {0}.hafta {1}.gün yapılmiştir üretim miktari={2}", minHaftaNo, minGunNo, minMiktar);
        }

        public void EnFazlaUretimYapilanHaftaBul()
        {
            int maxMiktar = 0;
            int maxHaftaNo = 0;

            for (int i = 0; i < haftaSayisi; i++)
            {
                int haftaToplami = 0;

                for (int j = 0; j < gunSayisi; j++)
                {
                    haftaToplami = haftaToplami + uretimMiktari[i, j];
                }

                if (haftaToplami > maxMiktar)
                {
                    maxMiktar = haftaToplami;
                    maxHaftaNo = i + 1;
                }
            }
            Console.WriteLine("En fazla üretim {0}.hafta yapılmıştır üretim miktari={1}", maxHaftaNo, maxMiktar);
        }
    }
}