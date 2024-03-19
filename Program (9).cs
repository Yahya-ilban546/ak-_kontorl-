string kullaniciAdi = "12";
string sifre = "1234";
int girisDenemesi = 0;

while (girisDenemesi < 3)
{
    Console.Write("Kullanıcı Adı: ");
    string girilenKullaniciAdi = Console.ReadLine();

    Console.Write("Şifre: ");
    string girilenSifre = Console.ReadLine();

    if (girilenKullaniciAdi == kullaniciAdi && girilenSifre == sifre)
    {
        Console.WriteLine("Giriş başarılı");
        break;
    }
    else
    {
        Console.WriteLine("Giriş başarısız");
        girisDenemesi++;
    }
}
if (girisDenemesi == 100.000)
{
    Console.WriteLine("Yüz bin deneme hakkınızı kullandınız. Lütfen daha sonra tekrar deneyin.");
}



