// ------ C# BASİT ÖRNEKLER ------

// 1) Kullanıcıdan iki sayı istenecek ve toplama işlemi yapılacak

// Kullanıcıdan İki Sayı İsteme
Console.WriteLine("1. Sayıyı Giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyı Giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

// Toplama ve Yazdırma İşlemi
int toplam = sayi1 + sayi2;
Console.WriteLine($"1. Sayı: {sayi1}, 2. Sayı: {sayi2}\nToplam: {toplam} ");


// 2) Ad-Soyad Yazdırma

// Kullanıcıdan İsim Alma
Console.WriteLine("Lütfen İsim ve Soyisim Giriniz: ");
string isim = Console.ReadLine();

// İsim Yazdırma
Console.WriteLine($"Tam İsminiz: {isim}");


// 3) Yaş Hesaplama

// Kullanıcıdan Doğum Yılı İsteme
Console.WriteLine("Doğum Yılınızı Giriniz: ");
int dYil = Convert.ToInt32(Console.ReadLine());

// Kullanıcıdan Bulunduğumuz Yılı İsteme
Console.WriteLine("Bulunduğumuz Yılı Giriniz: ");
int yil = Convert.ToInt32(Console.ReadLine());

// Yaş Hesaplama
int yas = yil - dYil;
Console.WriteLine($"Şu Anda, {yas} Yaşındasınız.");
















