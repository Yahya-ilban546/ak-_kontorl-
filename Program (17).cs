Console.WriteLine("1. sayıyı giriniz:");
int sayı1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. sayıyı giriniz:");
int sayı2 = Convert.ToInt32(Console.ReadLine());

int toplam = 0;
int sayac = 0;

while (sayac< sayı2)
{
    sayac++;
    toplam += sayı1;
}
Console.WriteLine($"sonuç {toplam}");
