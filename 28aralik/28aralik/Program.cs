using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28aralik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notlar = new int[5];
            for (int i = 0; i < notlar.Length; i++)
            {
                notlar[i] = 60 + (i * 10);
            }
            /*Methods.yazdir(notlar);
            Methods.kareler(notlar);
            Console.ReadLine();*/
            double birikmis = 5000;
            string secim;

            do
            {
                Console.WriteLine("ATM uygulamasına hoş geldiniz!");
                Console.WriteLine("Birikmiş parayı görüntülemek için 1'e basınız.");
                Console.WriteLine("Para çıkarmak için 2'ye basınız.");
                Console.WriteLine("Para eklemek için 3'ye basınız.");
                Console.WriteLine("Çıkış yapmak için 4'ye basınız.");

                 secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Methods.bakiyebak(birikmis);
                        break;
                    case "2":
                        Console.WriteLine("Çıkarmak istediğiniz tutarı giriniz : ");
                        double cikan = double.Parse(Console.ReadLine());
                       
                        birikmis =Methods.cikanTutar(birikmis, cikan);
                        break;
                    case "3":
                        Console.WriteLine("Kaç lira yatırmak istiyorsunuz?");
                        double yatacakpara = double.Parse(Console.ReadLine());
                        birikmis = Methods.paraEkle(birikmis, yatacakpara);
                        break;
                    case "4":
                        Console.WriteLine("Başarılı olarak çıkış yaptınız");
                        break;
                }
            } while (secim != "4");
            Console.ReadLine();
        }
    }
}
