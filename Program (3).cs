Console.WriteLine("x'i giriniz: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y'i giriniz: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("z'i giriniz: ");
int z = Convert.ToInt32(Console.ReadLine());

int enbuyuk = x;

if (y >= enbuyuk) 
{
    enbuyuk = y;
}
 
if (z >= enbuyuk)
{
    enbuyuk = z;
}
Console.WriteLine(enbuyuk);