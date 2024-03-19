Console.WriteLine("1.sayıyı giriniz: ");
int s1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2.sayıyı giriniz: ");
int s2 = Convert.ToInt32(Console.ReadLine());

while (s1 <= s2)
{
    Console.WriteLine(s1);
    s1 += 1;
}