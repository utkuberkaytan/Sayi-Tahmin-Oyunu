using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aklımdaki sayıyı tahmin edebilir misin?");
            bekle(1000);
            Console.WriteLine("Hadi başlayalım");
            Console.Write("Başlamak için 'başla' yaz >> ");
            string start = Console.ReadLine();
            if(start == "başla"){
                Random rand = new Random();
                Console.WriteLine("Pekala, Şimdi sayının maksimum ve minimum aralığını belirt(değerler tam sayı olmalı):");
                Console.Write("Minimum: ");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Maksimum: ");
                int max = Convert.ToInt32(Console.ReadLine());
                if(min >= max){
                    Console.WriteLine("Hatalı Giriş!");
                }
                else{
                    int sayi = rand.Next(min, max);
                    Console.WriteLine("Güzel, hadi başlayalım. Tahminini gir:");
                    while(true){
                    int tahmin = Convert.ToInt32(Console.ReadLine());
                    if (tahmin > sayi){
                        Console.WriteLine("Daha KÜÇÜK bir sayı giriniz.");
                    } 
                    else if (tahmin < sayi){
                        Console.WriteLine("Daha BÜYÜK bir sayı giriniz.");
                    } 
                    else{
                        string basarilisayi = sayi.ToString();
                        Console.WriteLine("TEBRİKLER!");
                        bekle(1500);
                        Console.WriteLine("Tuttuğum sayı " + basarilisayi + " idi.");
                        break;
                        }
                    }
                }
                
                Console.WriteLine("Oyun bitti. Çıkmak için enter'a bas");
                Console.ReadLine();
            }
            else{
                Console.WriteLine("Çıkmak için enter'a bas");
                Console.ReadLine();
            }

        }
        static void bekle(int sure){
            System.Threading.Thread.Sleep(sure);
        }
    }
}
