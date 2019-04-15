using System;

namespace RakamlaraAyirma
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int sayi = 0;
            do
            {
                Console.WriteLine("Lütfen 3 basmaklı bir sayi giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
            } while (sayi < 100 || sayi > 999);//sayi 100 den küçükse bir daha sorsun ,999 dan büyükse de bir daha sorsun 3 basamaklı girmezse 3 basamaklı girene kadar sorsun

            Console.WriteLine("Birinci Yol:");
            RakamCarpimiBul(sayi); //sayiyi bir mehtoda arguman olarak geçtik method işi yapacak
            Console.WriteLine("İkinci Yol:");
            RakamCarpimiBul2(sayi);//Sorunun çözümü ikinci yol
        }

        private static void RakamCarpimiBul(int x)//x yerine sayi gelecek yukarıda method çağırıldığında
        {
            //1.yol
            int birler, onlar, yuzler;
            yuzler = x / 100; //iki virgul kaydır virgulden sonraki kısım tutulmaz sayi int türünde old.
            x = x - (yuzler * 100); //yüzler çıkarılınca sayida iki basamaklı kısım kalacak sağda
            onlar = x / 10;
            birler = x - (onlar * 10);//onlar çıkarılında en sağdaki rakam kalacak
            int rakamlarCarpimi = birler * onlar * yuzler;
            Console.WriteLine("Sayinin rakamlari carpimi={0}", rakamlarCarpimi);
        }

        private static void RakamCarpimiBul2(int sayi)//parametre ismi herhangi bir şey olabilir
        {     //2.yol
            int carpim = 1;//çarpma yapılacağında çarpmanın etkisiz elemanını veriyoruz 1 ile çarpım sonucu etkilemez

            while (sayi != 0)
            {
                int rakam = sayi % 10;//10 a bölümünden kalan birler basamağını verir en sağdaki rakam
                carpim = carpim * rakam;//herbir rakamı buldıkça çarpımla çarpıyoruz
                sayi = sayi / 10; //bir virgül kaydır virgülden sonraki kısmı atar sayi int old.
                                  //sayi 0 olasıya kadar döngüye devam
            }
            Console.WriteLine("Sayinin rakamlari carpimi={0}", carpim);
        }
    }
}