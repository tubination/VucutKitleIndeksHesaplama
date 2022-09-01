using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vücut kitle indeksini hesaplayan C# kod bloğunu yazın.

            Console.Write("Tam isminizi giriniz: ");
            string isim = Console.ReadLine();

            Console.WriteLine("Merhaba " + isim);

            Console.Write("Kilonuzu giriniz: ");
            byte kilo = byte.Parse(Console.ReadLine());

            Console.Write("Boyunuzu m cinsinden giriniz: ");
            double boy= double.Parse(Console.ReadLine());

            double sonuc =   kilo/ (boy * boy);

            string sonuc2 = sonuc.ToString("0.##");      //virgülde sonra iki basamak olacak şekilde yazdım.

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine("Hesaplama Tarihi: " + dateTime);

            Console.WriteLine("Vücut kitle indeksiniz: " + sonuc2);

            if (sonuc < 18.5)
            {
                Console.WriteLine("Zayıf");

            }
            else if (sonuc < 25)
            {
                Console.WriteLine("Normal");

            }
            else if (sonuc < 30)
            {
                Console.WriteLine("Fazla Kilolu");

            }
            else if (sonuc < 35)
            {
                Console.WriteLine("Birinci derecede obez");

            }
            else if (sonuc < 45)
            {
                Console.WriteLine("İkinci derecede obez");

            }
            else
            {
                Console.WriteLine("Aşırı Şişman");
            }

































        }
    }
}

