using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ocak2023
{
    internal class Methods
    {
        public static void deneme()
        {
            Console.WriteLine("Günü giriniz : ");
            int gun = int.Parse(Console.ReadLine());
            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default: 
                    Console.WriteLine("Geçersiz gün değeri");
                    break;
            }
            Console.ReadLine();
        }
    }
}
