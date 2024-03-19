Console.WriteLine("1 sayı giriniz: ");
double num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{
    Console.WriteLine("Negative");
}
else
{
    Console.WriteLine("Positive");
}