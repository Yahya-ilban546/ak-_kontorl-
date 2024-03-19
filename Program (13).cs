Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
int sayac = 0;
while (sayi > 0)
{
    sayi /= 10;
    sayac++;
}
Console.WriteLine("Girdiğiniz sayı " + sayac + " basamaklıdır.");

Console.ReadLine();