﻿Console.WriteLine("1. sayıyı giriniz:");
double s1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. sayıyı giriniz: ");
double s2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("yapmak istediğiniz işlemi seçiniz (1-toplama,2-çıkarma,3-çarpma,4-bölme) /n ");
int seçim = Convert.ToInt32(Console.ReadLine());

switch (seçim)
{
    case 1:
        Console.WriteLine("birinci ve ikinci sayının toplamı:"s1 + s2);
        break;
    case 2:
        Console.WriteLine("birinci ve ikinci sayının çıkarımı:"s1 - s2);
        break;
    case 3:
        Console.WriteLine("birinci ve ikinci sayının çarpımı:"s1 * s2);
        break;
    case 4:
        Console.WriteLine("birinci ve ikinci sayının bölümü:"s1 / s2);
        break;

}
