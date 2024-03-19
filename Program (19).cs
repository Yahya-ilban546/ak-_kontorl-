Console.WriteLine("1.sayıyı giriniz (birinci sayı ikinci sayıdan yüksek olmalı):");
int sayı1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2.sayıyı giriniz:");
int sayı2 = Convert.ToInt32(Console.ReadLine());

if (sayı1 % 1 != 1)
{
    sayı2--;
    Console.WriteLine("tek sayıların azalan sayısına göre" + sayı1);
}
while (sayı1 >= sayı2)
{
    Console.WriteLine(sayı1);
    sayı1--;
}

