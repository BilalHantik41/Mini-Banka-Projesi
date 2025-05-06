using System;
using System.Collections.Generic;

namespace Banka_Islemleri
{
    class Program
    {
       public static void Main(string[] args)
        {   PerformAction();
            HesapAcma();
            Krediİslemleri();
            AracKredisi();
            ArsaKredisi();
            ihtiyacKredisi();

        }
        static void PerformAction()
        {   var Banka_Islemleri = new Dictionary<int, string>
            {
                { 1, "Hesap Açma" },
                { 2, "Kredi İşlemleri" },
                { 3, "Kredi Karti İşlemleri" },
                { 4, "Ticari İşlemler" }


            };
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz..:");
                foreach (var kvp in Banka_Islemleri)
                {
                Console.WriteLine($"{kvp.Key}. {kvp.Value}");
                }
             Console.Write("Seçiminiz (1-4): ");
            string giris = Console.ReadLine();


            if (!int.TryParse(giris, out int secim) || !Banka_Islemleri.ContainsKey(secim))
            {
                 Console.WriteLine("⚠️ Geçersiz seçim. Program sonlaniyor.");
                return;
            }
            switch (secim)
            {
                case 1:
                    Console.WriteLine("→ Hesap açma işlemleri başlatiliyor...");
                    HesapAcma();
                    break;
                case 2:
                    Console.WriteLine("→ Kredi işlemleri için aktariliyorsunuz...");
                    Krediİslemleri();
                    break;
                case 3:
                    Console.WriteLine("→ Kredi Karti İşlemleri için aktariliyorsunuz...");
                    // buraya Arsa kredisi ile ilgili kodu ekleyin
                    break;
                case 4:
                    Console.WriteLine("→ Ticari İşlemler için Aktariliyorsunuz...");
                    // buraya KMH kredisi ile ilgili kodu ekleyin
                    break;
                default:
                    // Teknik olarak gelinmez, çünkü yukarıda kontrol ettik
                    Console.WriteLine("Bilinmeyen işlem seçildi.");
                    break;
            }
        

        }
        static void HesapAcma()
        {
            Console.Clear();
            Console.WriteLine("***Hesap Açma İşlemleri***");

            Console.WriteLine("Adinizi Giriniz: ");
            string ad = Console.ReadLine();

            Console.WriteLine("Soyadinizi Giriniz: ");
            string soyad = Console.ReadLine();

            Console.WriteLine("Adresinizi Giriniz: ");
            string adres = Console.ReadLine();

            Console.WriteLine("Telefon Numaranizi Giriniz: ");
            string telefon = Console.ReadLine();

            Console.WriteLine("Aylik Gelirinizi Giriniz: ");
            string gelir = Console.ReadLine();

        Console.WriteLine();
            Console.WriteLine("---- Girdiğiniz Bilgiler ----");
            Console.WriteLine($"Ad Soyad  : {ad} {soyad}");
            Console.WriteLine($"Adres     : {adres}");
            Console.WriteLine($"Telefon   : {telefon}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("\nHesabiniz başariyla oluşturuldu! .Devam etmek için bir tuşa basin..");
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        static void Krediİslemleri()
        {   
            Console.Clear();
            Console.Write("Hesabınız var mı? (E/H): ");
            string cevap = Console.ReadLine().Trim().ToUpper();

            if (cevap == "H")    // Hayır → önce hesap açma
            {
                Console.WriteLine("Öncelikle hesap açma işlemlerine yönlendiriliyorsunuz...");
                Console.ReadKey();

                HesapAcma();     // Daha önce tanımladığınız hesap açma metodu
                return;          // Hesap açma sonrası ana menüye dönmek isterseniz burayı return ile bırakın
             }
            else if (cevap != "E") // Evet dışındaki cevaplar hatalı
            {
                Console.WriteLine("Geçersiz seçim, ana menüye dönülüyor...");
                Console.ReadKey();
                return;
            }



            Console.WriteLine("***Kredi İşlemleri***");

            Console.WriteLine("Kullanmak İstediğiniz Kredi Türünü Seçiniz: ");

            var krediIslemleri = new Dictionary<int, string>
            {
                { 1, "Araç Kredisi" },
                { 2, "Arsa Kredisi" },
                { 3, "İhtiyaç Kredisi" },
                { 4, "Ticari Krediler" }
            };

            foreach (var kvp in krediIslemleri)
                Console.WriteLine($"{kvp.Key}. {kvp.Value}");

                Console.Write("\nSeçiminiz (1-4): ");
                string pick = Console.ReadLine();

            if (!int.TryParse(pick, out int choice) || !krediIslemleri.ContainsKey(choice))
            {
                Console.WriteLine(" Geçersiz seçim. Ana menüye dönülüyor...");
                Console.ReadKey();
                return;
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("→ Araç Kredisi...");
                    AracKredisi();
                    break;
                case 2:
                    Console.WriteLine("→ Arsa Kredisi...");
                    ArsaKredisi();
                    break;
                case 3:
                    Console.WriteLine("→ İhtiyaç Kredisi...");
                    ihtiyacKredisi();
                    break;
                case 4:
                    Console.WriteLine("→ Ticari Krediler...");
                    
                    break;
                default:
                    
                    Console.WriteLine("Bilinmeyen işlem seçildi.");
                    break;
            }
             Console.WriteLine("\nDevam etmek için bir tuşa basin...");
            Console.ReadKey();

        }
        static void AracKredisi()
        {
            Console.Clear();
            Console.WriteLine("***Araç Kredisi İşlemleri***");

            Console.WriteLine("Araç Modeli: ");
            string model = Console.ReadLine();

            Console.WriteLine("Aracin Yaşi: ");
            string aracYaşi = Console.ReadLine();

            Console.WriteLine("Aracin Ekspertiz Değeri: ");
            string ekspertiz = Console.ReadLine();

            Console.WriteLine("Kredi için istenilen Tutar: ");
            string tutar = Console.ReadLine();

            Console.WriteLine("Kaç Ay Vade İstiyorsunuz: ");
            string vade = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("---- Girdiğiniz Bilgiler ----");
            Console.WriteLine($"Araç Modeli  : {model}");
            Console.WriteLine($"Aracin Yaşi     : {aracYaşi}");
            Console.WriteLine($"Aracin Ekspertiz Değeri   : {ekspertiz}");
            Console.WriteLine($"Kredi için istenilen tutar   : {tutar}");
            Console.WriteLine($"Kaç Ay Vade İstiyorsunuz   : {vade}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("\nKredi Başvurunuz Değerlendirmeye Alindi. Size en yakin sürede bilgi verilecek..");
            Console.WriteLine("\n");
            Console.ReadKey();
            
            return;    
        }

        static void ArsaKredisi()
        {
            Console.Clear();
            Console.WriteLine("***Arsa Kredisi İşlemleri***");

            Console.WriteLine("Arsa'nin Cinsi: ");
            string cins = Console.ReadLine();

            Console.WriteLine("Arsa'nin M2'si: ");
            string arsaM2 = Console.ReadLine();

            Console.WriteLine("Arsa'nin Konumu: ");
            string arsaAdress = Console.ReadLine();

            Console.WriteLine("Kredi için istenilen Tutar: ");
            string arsaTutar = Console.ReadLine();

            Console.WriteLine("Kaç Ay Vade İstiyorsunuz: ");
            string arsaVade = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("---- Girdiğiniz Bilgiler ----");
            Console.WriteLine($"Arsa'nin Cinsini Giriniz  : {cins} ");
            Console.WriteLine($"Arsanin kaç M2 olduğunu giriniz     : {arsaM2}");
            Console.WriteLine($"Arsanin adresini giriniz   : {arsaAdress}");
            Console.WriteLine($"Kredi için istenilen tutar   : {arsaTutar}");
            Console.WriteLine($"Kaç Ay Vade İstiyorsunuz   : {arsaVade}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("\nKredi Başvurunuz Değerlendirmeye Alindi. Size en yakin sürede bilgi verilecek..");
            Console.WriteLine("\n");
            Console.ReadKey();
              return;     

        }

        static void ihtiyacKredisi()
        
        {
            Console.Clear();
            Console.WriteLine("***İhtiyaç Kredisi İşlemleri***");

            Console.WriteLine("İhtiyaç Kredisi Kullanim Sebebini Belirtiniz : ");
            string sebep = Console.ReadLine();

            Console.WriteLine("İhtiyaç Kredisi için Teminatiniz var mi :  ");
            string teminat = Console.ReadLine();

            Console.WriteLine("Kredi için istenilen Tutar: ");
            string ihtiyacTutar = Console.ReadLine();

            Console.WriteLine("Kaç Ay Vade İstiyorsunuz: ");
            string ihtiyacVade = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("---- Girdiğiniz Bilgiler ----");
            Console.WriteLine($"İhtiyaç Kredisinin Kullanim Sebebini Belirtiniz  : {sebep} ");
            Console.WriteLine($"İhtiyaç Kredisi için Teminatiniz var mi : {teminat}");
            Console.WriteLine($"Kredi için istenilen tutar   : {ihtiyacTutar}");
            Console.WriteLine($"Kaç Ay Vade İstiyorsunuz   : {ihtiyacVade}");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("\nKredi Başvurunuz Değerlendirmeye Alindi. Size en yakin sürede bilgi verilecek..");
            Console.WriteLine("\n");
            Console.ReadKey();
              return;     
        }    

             
    } 
}