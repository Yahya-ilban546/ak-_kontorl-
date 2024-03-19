int toplam = 0;

while (true)
{
    Console.WriteLine("Bir sayı giriniz çıkmak için 0'a basınız");
    int soru = Convert.ToInt32(Console.ReadLine());

    if (soru == 0)
    {
        Console.WriteLine("program kapatılıyor");
        break;
    }
    else
    {
        toplam += soru;
        Console.WriteLine(toplam);
    }
    
}