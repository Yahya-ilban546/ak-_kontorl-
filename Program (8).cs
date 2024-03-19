int sayı = 1;
while (sayı <= 500)
{
    if (sayı % 3 == 0 || sayı % 5 == 0)
    {
        Console.WriteLine(sayı);
    }
    sayı++;
}