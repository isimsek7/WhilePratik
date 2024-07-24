using System;

int sayac = 0;
while (sayac < 10)
{
    sayac++;
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
int sayi = 0;
Console.WriteLine("1'ile 20 arasindaki sayilar asagida siralanmistir.");
while (sayi<20)
{
    sayi++;
    Console.WriteLine(sayi);
}
int ciftSayi = 0;
Console.WriteLine("1 ile 20 arasindaki cift sayilar asagida siralanmistir.");
while (ciftSayi<20)
{
    ciftSayi++;
    if (ciftSayi % 2 == 0)
    {
        Console.WriteLine(ciftSayi);
    }
}
int toplam = 0;
int aralik = 49;
while(aralik<150)
{
    aralik++;
    toplam = toplam + aralik;
}
Console.WriteLine("50 ile 150 arasindaki sayilarin toplami {0}'a esittir",toplam);
int tekSayilar = 0;
int ciftSayilar = 0;
int sayac2 = 0;
while (sayac2 < 120)
{
    sayac2++;
    if (sayac2 % 2 == 0)
        ciftSayilar = ciftSayilar + sayac2;
    else
        tekSayilar = tekSayilar + sayac2;
}
Console.WriteLine("1 ile 120 arasindaki cift sayilarin toplami {0}'a esittir.",ciftSayilar);
Console.WriteLine("1 ile 120 arasindaki cift sayilarin toplami {0}'a esittir.",tekSayilar);