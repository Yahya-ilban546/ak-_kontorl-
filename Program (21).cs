Console.WriteLine("1. SAYIYI GİR: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. SAYIYI GİR: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > 0)
{
    Console.WriteLine("1. sayı pozitif");
}

if (number2 > 0)
{
    Console.WriteLine("2. sayı pozitif");
}

else if (number1 >= 0 || number2 >= 0)
{
    Console.WriteLine("Her ikiside pozitif");
}




if (number1 < 0)
{
    Console.WriteLine("1. sayı negatiftir");
}

if (number2 < 0)
{
    Console.WriteLine("2. sayı negatiftir");
}

else if (number1 <= 0 || number2 <= 0)
{ 
    Console.WriteLine("Her ikiside negatiftir");
}
