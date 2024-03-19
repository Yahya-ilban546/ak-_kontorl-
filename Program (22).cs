int a;
Console.WriteLine("A sayısını giriniz: ");
a = Convert.ToInt32(Console.ReadLine());

int b;
Console.WriteLine("B sayısını giriniz: ");
b = Convert.ToInt32(Console.ReadLine());


if (a >= 0 || b >= 0)
{
    Console.WriteLine("\n2");
}

else if (a >= 0)
{
    Console.WriteLine("\n1");
}

else if (b >= 0)
{
    Console.WriteLine("\n1");
}


Console.Read();