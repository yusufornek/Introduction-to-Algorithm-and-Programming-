using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19aralik
{
    public class MyMethods
    {
        internal int tamSayi()
        {
            int kontrol;
            do
            {
                Console.WriteLine("Lütfen bir tam sayı girin: ");


                string sayi = Console.ReadLine();


                if (int.TryParse(sayi, out kontrol))
                {

                    break;
                }
                else
                {

                    Console.WriteLine("Girdiğiniz değer bir tam sayı değildir. Lütfen tekrar deneyin.");
                }
            } while (true);

            Console.WriteLine("Girdiğiniz tam sayı: " + kontrol);
            return kontrol;
        }
    }
} 
