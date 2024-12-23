using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            /*
            
            Console.Write("Lütfen şifreyi giriniz: ");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }

            */

            /*
            
            string capital, country;
            Console.Write("Başkenti giriniz: ");
            capital = Console.ReadLine();
            Console.Write("Ülkeyi giriniz: ");
            country = Console.ReadLine();

            if(capital == "ankara" & country == "türkiye")      //burada Ankara ve Türkiye olarak girsek yanlış sayardı
            {                                                   //çünkü verileri birebir aynı formatta istiyor.
                Console.WriteLine("veriler doğrulandı");
            }
            else
            {
                Console.WriteLine("hatalı veri");
            }
   
            */

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5) 
            //{
            //    Console.WriteLine("Sayi dogru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi yanlis.");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("Birinci sınavınızı giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci sınavınızı giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Üçüncü sınavınızı giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavlarınıın ortalaması: " + average);

            //if (average < 50)
            //{
            //    result = "Ders notunuz F";
            //}

            //if (50 < average & average < 70)
            //{
            //    result = "Ders notunuz C";            //KODLARI DÜZENLEMEK İÇİN = CTRL + K + D
            //}

            //if (70 <= average & average <= 84)
            //{
            //    result = "Ders notunuz B";
            //}

            //if (average > 84)
            //{
            //    result = "Ders notunuz A";
            //}

            //Console.WriteLine(result);      

            //CS0165 hatası: string değerin başta bir değer ataması olmadığı için hata verdi.
            //yukarıdaki tanımladığımız yere bir ilk değer koymamız gerekir.
            //çünkü eğer hiçbir if bloğuna girmezse o mesajı döndürecek, oraya Hata! yazalım.


            //string city;
            //Console.Write("Lütfen bir şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "Trabzon" | city == "Mersin" | city == "Bursa") 
            //{
            //    Console.WriteLine("Şehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil.");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin") 
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz."); 
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;     //Mod operatörü bir sayının başka sayıyla bölümünden kalanı bulmayı sağlar.
            //Console.WriteLine(result); 

            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalan değer: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0) 
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //if (number % 2 == 1)
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş.");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'T' | team == 't')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}

            //if(team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Bursaspor");
            //}

            #endregion

            #region Örnek Proje Uygulaması 

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("-------------------------------");

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Ana Yemekler -------------");
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("------------- Ana Yemekler -------------");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Çorbalar -------------");
            //    Console.WriteLine("1- Kelle Paça Çorbası");
            //    Console.WriteLine("2- Mercimek Çorbası");
            //    Console.WriteLine("3- Ezogelin Çorbası");
            //    Console.WriteLine("------------- Çorbalar -------------");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Pizzalar -------------");
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margarita");
            //    Console.WriteLine("3- Sucuklu Pizza");
            //    Console.WriteLine("------------- Pizzalar -------------");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- İçecekler -------------");
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("------------- İçecekler -------------");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Tatlılar -------------");
            //    Console.WriteLine("1- Trileçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("------------- Tatlılar -------------");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)                               //bir sürü if bloğu olmadan işlem yapabilmek için kullanılır.
            //{                                                  //parantez içerisindeki ifade bizim ona göre işlem yapılacak değişkenimizdir.
            //    case 1: Console.Write("Ocak"); break;          // 1 gelirse ekrana ocak yaz ve bu işlemi bitirmesi için de break konur. 
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;

            //    default: Console.Write("Hatalı Veri Girişi."); break;   //herhangi başka bir şey girilirse bize o yazıyı yazacak.
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("Birinci sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Çıkarım: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;

                case '/': 
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
            }


            #endregion

            Console.Read();
        }
    }
}
