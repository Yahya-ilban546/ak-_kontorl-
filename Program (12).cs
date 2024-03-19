Console.WriteLine("notu giriniz: ");
int sayı = Convert.ToInt32(Console.ReadLine());

switch (sayı)
{
    case 10: Console.WriteLine("A+"); break;
    case 9: Console.WriteLine("A"); break;
    case 8: Console.WriteLine("B"); break;
    case 7: Console.WriteLine("B"); break;
    case 6: Console.WriteLine("C"); break;
    case 5: Console.WriteLine("E"); break;
    case 4: Console.WriteLine("F"); break;
    case 3: Console.WriteLine("F"); break;
    case 2: Console.WriteLine("F"); break;
    case 1: Console.WriteLine("F"); break;
    case 0: Console.WriteLine("F"); break;

    default: Console.WriteLine("böyle bir sayı yok"); break;

}