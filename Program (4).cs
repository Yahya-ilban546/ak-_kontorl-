int x;

do
{
    Console.Write("Lütfen bir sayı girin (0'a basarak çıkış yapabilirsiniz): ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out x))
    {
        Console.WriteLine("Geçersiz giriş! Lütfen bir tam sayı girin.");
        continue;
    }

    if (x != 0)
    {
        Console.WriteLine($"10 * {x} = {10 * x}");
    }
    else
    {
        Console.WriteLine("Çıkış yapılıyor...");
        break;
    }

} while (true);