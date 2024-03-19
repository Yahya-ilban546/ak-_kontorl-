while (true)
{
    Console.WriteLine("Birinci sayıyı girin : ");
    int s1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("İkinci sayıyı girin : ");
    int s2 = Convert.ToInt32(Console.ReadLine());

    if (s1 == 0)
    {
        Console.WriteLine("Program sonlandırıldı.");
        break;
    }

    if (s2 == 0)
    {
        Console.WriteLine("İkinci sayı sıfır olamaz! Lütfen farklı bir değer girin.");
        continue;
    }

    int kalan = s1 / s2;
    Console.WriteLine(kalan);
}
