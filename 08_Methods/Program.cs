using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //Şu ana kadar hep hazır metotlar kullandık Console.WriteLine veya Parse birer örneği.
            //Şimdi kendi metotlarımızı oluşturacağız.
            //Bir yapıyı metot yapan şey sonunda () olmasıdır.
            //Main de bir metottur üzerine gelindiği zaman sol tarafında mor küp ikonu vardır.
            //Bu C# da geliştiriciye o ifadenin bir metot olduğunu gösterir.
            //Metotlar geriye değer döndüren ve döndürmeyen olarak ikiye ayrılır. 
            //Geriye değer döndürenler Return metotlar, döndürmeyenler ise void metotlardır.

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Salih Doğadağ");
            //}

            /*CustomerList();*/  //yanındaki kilit sembolü onun private bir metot olduğunu gösterir.

            //özellikle geriye değer döndürmeyen metotlar belli işlemleri tekrardan kurtarmak için kullanılır.

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " +  name + " " +  surName);
            //}

            //CustomerCard("mehmet","yıldız");
            //CustomerCard("ayşe","yıldız");


            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Mert Yılmaz";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());  // şu an ekrana yazdırır.

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı/Beyaz"));

            #endregion

            #region Geriye Değer Döndüren İnt Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(239, 212));
            //Console.WriteLine(Sum(99, 23));
            //Console.WriteLine(Sum(45, 20));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti." + " | Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci başarısız oldu." + " | Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 41, 82));
            Console.WriteLine(ExamResult("Talat", 55, 61, 24));

            #endregion

            Console.Read();
        }
    }
}
