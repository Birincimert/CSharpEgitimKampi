using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            /*

            Console.Write(" Merhaba Dünya ");  //eğer yazdığımız ifadenin solunda mor renkli bir küp varsa bu onun metod olduğu anlamına gelir.
            Console.WriteLine("Selam");      //bu ifade bir yazı yazdıktan sonra imleci alt satıra indirir.

            //yemek menüsü yapalım
            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();  //bir satır boşluk olması için
            Console.WriteLine("1- Çorbalar");
            Console.WriteLine("2- Ana Yemekler");
            Console.WriteLine("3- Soğuk Başlangıçlar");       //CTRL+D yaparak bir satırı aşağıya Duplicate edebiliriz.
            Console.WriteLine("4- Salatalar");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine("6- İçecekler");
            Console.WriteLine("***** Yemek Kategorileri *****");

             */

            #endregion

            #region String Değişkenler

            /*

            //değişken_türü değişken_adı;

            //string
            //string name;
            //name = "Mert";
            //Console.WriteLine(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, distinct, city;  //bir satırda aynı türde birden fazla değişken tanımlanabilir.

            customerName = "Mert";
            customerSurname = "Birinci";
            customerPhone = "+90 500 400 30 20";
            customerEmail = "mert@email.com";
            distinct = "Nilüfer";
            city = "Bursa";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + distinct + "/" + city);
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine();

            customerName = "Jayce";
            customerSurname = "Talis";
            customerPhone = "+61 610 610 61 61";
            customerEmail = "jtalis@hexmail.ht";
            distinct = "Uptown";
            city = "Piltover";

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + distinct + "/" + city);
            Console.WriteLine("-------------------------------------------------");

            */

            #endregion

            #region Integer Değişkenler

            //int: tam sayı türündeki değişkenler   
            //int number = 25;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + "TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + "TL");
            Console.WriteLine("-----Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            Console.Read(); //ekranın hemen gitmemesi için ekledik, biz enter'a basana kadar konsol duracak.
        }
    }
}

// Ders 1
// Bölüm 1: Yazdırma komutları
// Bölüm 2: Değişkenler