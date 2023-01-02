/*
Console.WriteLine("Lütfen 1. sayıyı giriniz : ");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 2. sayıyı giriniz : ");
int sayi2 = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen 3. sayıyı giriniz : ");
int sayi3 = int.Parse(Console.ReadLine());

if (sayi1 > sayi2 && sayi1 > sayi3)
    Console.WriteLine("En büyük sayı={0}", sayi1);
else if (sayi2 > sayi1 && sayi2 > sayi3)
    Console.WriteLine("En büyük sayı={0}", sayi2);
else if (sayi3 > sayi1 && sayi3 > sayi2)
    Console.WriteLine("En büyük sayı={0}", sayi3);


--------------------------------------------------------------

Console.WriteLine("Sıcaklık derecesini giriniz : ");
float sicaklik = float.Parse(Console.ReadLine());

if (sicaklik <= 0)
{
    Console.WriteLine("Katı");
}
else if (sicaklik > 0)
{
    if (sicaklik >= 100) 
    {
        Console.WriteLine("Gaz");
    }
    else
    {
        Console.WriteLine("Sıvı");
    }
}

Console.WriteLine("Maaşı giriniz : ");
float maas = float.Parse(Console.ReadLine());
Console.WriteLine("Çocuk sayısını giriniz : ");
float cocuk = float.Parse(Console.ReadLine());



if (cocuk == 1)
{
    Console.WriteLine("Toplam maaş : " + (maas + maas * 0.05));
}
else if (cocuk == 2)
{
    Console.WriteLine("Toplam maaş : " + (maas + maas * 0.10));
}
else if (cocuk >= 3)
{
    Console.WriteLine("Toplam maaş : " + (maas + maas * 0.15));
}
else
{
    Console.WriteLine(maas);
}


Console.WriteLine("Kaç saat çalıştınız? : ");
double saat = double.Parse(Console.ReadLine());

if (saat < 40)
{
    Console.WriteLine("Maaşınız : " +  saat*50);
}
else
{
    Console.WriteLine("Maaşınız : " +  (40*50 + ((saat - 40) * 75)));
}




Console.WriteLine("Kilonuzu giriniz : ");
float kg = float.Parse(Console.ReadLine());

Console.WriteLine("Boyunuzu giriniz : ");
float m = float.Parse(Console.ReadLine());

float kitle = kg / (m * m);

if (kitle < 18.5)
{
    Console.WriteLine("ZAYIFSINIZ"+ kitle );
}
else if (kitle < 24.9)
{
    Console.WriteLine("NORMALSİNİZ");
}
else if (kitle < 29.9)
{
    Console.WriteLine("FAZLA KİLOLUSUNUZ");
}
else if (kitle < 34.9)
{
    Console.WriteLine("1.DERECE OBEZSİNİZ");
}
else if (kitle < 39.9)
{
    Console.WriteLine("2.DERECE OBEZSİNİZ");
}
else
{
    Console.WriteLine("3.DERECE OBEZSİNİZ");
}



*/

