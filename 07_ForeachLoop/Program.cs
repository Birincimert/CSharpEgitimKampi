using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4) //4 tane parametre alan bir döngüdür.
            //1: Değişken türü
            //2: Değişken adı
            //3: In komutu
            //4: Liste,Koleksiyon veya Dizinin adı

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);  //x diye bir değişken var ve bu x, cities'in içine girip sırasıyla tüm değerleri üzerine alacak
            //}

            //işin kolay yanı for'daki gibi başlangıç ve bitiş değerleri ile uğraşmamamız
            //foreach döngüsü bunu otomatik olarak alıyor.

            //int[] numbers = { 123, 5, 36, 87, 39, 32, 1, 67, 234, 8, 132, 9, 132, 879, 21, 84, 4524, 545 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //eğer sadece çift sayıları listelemek istersek:

            //int[] numbers = { 123, 5, 36, 87, 39, 32, 1, 67, 234, 8, 132, 9, 132, 879, 21, 84, 4524, 545 };
            //foreach (int number in numbers)
            //{
            //    if (number %2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 123, 5, 36, 87, 39, 32, 1, 67, 234, 8, 132, 9, 132, 879, 21, 84, 4524, 545 };
            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}

            //Console.WriteLine(total);

            //Listeler bir koleksiyon öğesidir.
            //List<tür> liste_ismi = new list<tür>();
            //new operatörü de bir örnek alma instance alma olarak geçer
            //dizilere direkt atama da yapabiliriz {}açıp

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-----------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            //Öğrenci notlarını ve ortalamalarını saklayacak diziler ( Sınıfın boyutu kadar isim ve ortalama olacak )
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++) // 0,1,2 indexli olarak 3 sınav girilecek o yüzden  j < 3 
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3 ; 
            }

            //Sınav Ortalamaları
            Console.WriteLine("------------------------------");
            for (int i = 0;i < studentCount;i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >=50) 
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı.");
                }
                
                Console.WriteLine("------------------------------");

            }




            #endregion

            Console.Read();
        }
    }
}
