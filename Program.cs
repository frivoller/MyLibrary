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
        kitap1.Ad = "Normal People";
        kitap1.YazarAd = "Sally";
        kitap1.YazarSoyad = "Rooney";
        kitap1.SayfaSayisi = 304;
        kitap1.YayinEvi = "Crown Publishing Group";

        kitap1.BilgileriYazdir();
        Console.WriteLine();

        // parametreli constructor ile nesne olusturma
        Kitap kitap2 = new Kitap("Ports of Call", "Amin", "Maalouf", 183, "Vintage Publishing");
        kitap2.BilgileriYazdir();
    }
}

 Kitap kitap3 = new Kitap("The Bell Jar", "Sylvia", "Plath", 288, "HarperCollins");
        kitap3.BilgileriYazdir();
    }
}
