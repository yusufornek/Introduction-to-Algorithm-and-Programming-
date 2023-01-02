/*
Console.WriteLine("Tabanı giriniz : ");
double t = double.Parse(Console.ReadLine());
Console.WriteLine("Yüksekliği giriniz ");
double y = double.Parse(Console.ReadLine());
alanHesaplaPar(y, t);


void alanHesapla()
{
    Console.WriteLine("Tabanı giriniz : ");
    double taban = double.Parse(Console.ReadLine());
    Console.WriteLine("Yüksekliği giriniz ");
    double yukseklik = double.Parse(Console.ReadLine());

    double alan = (taban * yukseklik) / 2;
    Console.WriteLine(alan);
}

void alanHesaplaPar(double y, double t)
{
    double alan = (t * y) / 2.0;
    Console.WriteLine(alan);
}


int intkontrol()
{
    int kontrol;
    do
    {
        Console.WriteLine("Lütfen bir tam sayı girin: ");


        string sayi = Console.ReadLine();

,
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

int kontrolcu = intkontrol();
Console.WriteLine(kontrolcu);


using System.Security.Cryptography.X509Certificates;

double dikdortgenAlan(int k, int u)
{
    double alan = (k * u) * 1.0;
    Console.WriteLine(alan);
    return alan;
}

Console.WriteLine("Kısa kenarı giriniz : ");
int kisaKenar = int.Parse(Console.ReadLine());
Console.WriteLine("Uzun kenarı giriniz : ");
int uzunKenar = int.Parse(Console.ReadLine());

double dAlan = dikdortgenAlan(kisaKenar,uzunKenar);


double faktoriyel(double a)
{
    double faktor = 1;
    for (int i = 1; i <= a; i++)
    {
        faktor *= i;
    }
    Console.WriteLine(faktor);
    return faktor;
}
Console.WriteLine("Faktöriyeli hesaplanacak sayıyı giriniz : ");
double sayi = double.Parse(Console.ReadLine());
double faktorhesaplama = faktoriyel(sayi);
*/


bool kontrol (int a)
{
   if (a < 0)
    {
        return false;
    }
    else
    {
        return true;            
    }
}
Console.WriteLine("Sayı giriniz ");
int sayi = int.Parse(Console.ReadLine());
Console.WriteLine(kontrol(sayi));




