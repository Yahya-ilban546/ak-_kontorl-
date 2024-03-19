int sayı = Convert.ToInt32(Console.ReadLine());
int sayac = 2;

bool asal = true;
while (sayac < sayı)
{
    if (sayı % sayac == 0)
    {
        Console.WriteLine("asal değildir");
        asal = false;
        break;
    }sayac++;
    
}
if (asal)
{
    Console.WriteLine("asaldır");
}

