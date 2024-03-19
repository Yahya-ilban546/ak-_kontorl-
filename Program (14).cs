Console.Write("Başlangıç sayısını giriniz (x): ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Bitiş sayısını giriniz (y): ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" {x} ile {y} arasındaki sayılar:");
for (int i = x; i <= y; i++)
{
    Console.Write(i + " ");
}

Console.ReadLine();