using System;

namespace C_Sharp_Number_Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, birlerB, onlarB, yuzlerB, binlerB;
            Console.Write("Bir sayı giriniz: ");
            sayi = int.Parse(Console.ReadLine());

            string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string[] yuzler = { "", "yüz", "ikiyüz", "üçyüz", "dörtyüz", "beşyüz", "altıyüz", "yediyüz", "sekizyüz", "dokuzyüz" };
            string[] binler = { "", "bin", "ikibin", "üçbin", "dörtbin", "beşbin", "altıbin", "yedibin", "sekizbin", "dokuzbin" };

            birlerB = sayi % 10;
            onlarB = (sayi / 10) % 10;
            yuzlerB = (sayi / 100) % 10;
            binlerB = (sayi / 1000) % 10;

            Console.WriteLine(binler[binlerB] + " " + yuzler[yuzlerB] + " " + onlar[onlarB] + " " + birler[birlerB]);

            Console.Read();
        }
    }
}
