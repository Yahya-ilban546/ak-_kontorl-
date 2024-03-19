Console.Write("Bir sayı girin: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Kaç kere tekrar etmek istiyorsunuz? ");
int y = Convert.ToInt32(Console.ReadLine());
int tekrar = 0;
while (tekrar < y)
{
    Console.WriteLine(x);
    tekrar++;
}
Console.ReadLine();