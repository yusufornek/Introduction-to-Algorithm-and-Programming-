using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28aralik
{
    internal class Methods
    {
        public static void yazdir(int[] dizimiz)
        {
            foreach (int i in dizimiz)
            {
                Console.WriteLine(i);
            }
        }
        public static void kareler(int[] arrays)
        {
            foreach (int i in arrays)
            {
                Console.WriteLine("Karesi : " + (i*i));
            }
        }

        public static void bakiyebak(double birikmis)
        {
            Console.WriteLine("Birikmiş paranız : " + birikmis);
        }
        public static double cikanTutar(double birikmis, double cikan)
        {
            double kalan_tutar = 0;
            if(birikmis < cikan)
            {
                Console.WriteLine("Yetersiz bakiye");
                kalan_tutar = birikmis;
            }
            else
            {
                kalan_tutar = birikmis - cikan;
                Console.WriteLine(kalan_tutar);
            }
            return kalan_tutar;
        }
        public static double paraEkle(double birikmis, double yatacakpara)
        {
            double yenibakiye = birikmis + yatacakpara;
            Console.WriteLine("Eski bakiyeniz : " + birikmis);
            Console.WriteLine("Yeni bakiyeniz : " + yenibakiye);
            return yenibakiye;
        }

    }
}
