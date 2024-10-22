using System;

class Kitap
{
    // properties
    public string Ad { get; set; }
    public string YazarAd { get; set; }
    public string YazarSoyad { get; set; }
    public int SayfaSayisi { get; set; }
    public string YayinEvi { get; set; }
    public DateTime KayitTarihi { get; set; }

    // 1. default constructor (parametre almayan constructor)
    public Kitap()
    {
        // default degerler atanabilir veya bos birakilabilir
        KayitTarihi = DateTime.Now;
    }

    // 2. parametreli constructor (kitap bilgilerini alip nesneyi olusturur)
    public Kitap(string ad, string yazarAd, string yazarSoyad, int sayfaSayisi, string yayinEvi)
    {
        Ad = ad;
        YazarAd = yazarAd;
        YazarSoyad = yazarSoyad;
        SayfaSayisi = sayfaSayisi;
        YayinEvi = yayinEvi;
        KayitTarihi = DateTime.Now; // nesne olusturulunca anlik tarih atanir
    }

    // kitap bilgilerini yazdiran metot
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Kitap Adı: {Ad}");
        Console.WriteLine($"Yazar: {YazarAd} {YazarSoyad}");
        Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
        Console.WriteLine($"Yayınevi: {YayinEvi}");
        Console.WriteLine($"Kayıt Tarihi: {KayitTarihi}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // default constructor ile nesne olusturma (bilgiler daha sonra atanir)
        Kitap kitap1 = new Kitap();
        kitap1.Ad = "Doğunun Limanları";
        kitap1.YazarAd = "Amin";
        kitap1.YazarSoyad = "Maalouf";
        kitap1.SayfaSayisi = 183;
        kitap1.YayinEvi = "Yapıkredi Yayınları";

        kitap1.BilgileriYazdir();
        Console.WriteLine();

        // parametreli constructor ile nesne olusturma
        Kitap kitap2 = new Kitap("Doğunun Limanları", "Amin", "Maalouf", 183, "Yapıkredi Yayınları");
        kitap2.BilgileriYazdir();
    }
}
