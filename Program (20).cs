int x;
Console.WriteLine("1. sayıyı giriniz: ");
x = Convert.ToInt32(Console.ReadLine());

int y;
Console.WriteLine("2. sayıyı giriniz: ");
y = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 0)
{
    x--;
}

while (x >= y)
{
    Console.WriteLine(x);
    x -= 2;
}