using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //2,4,6,8
            //mavi,kırmızı,beyaz,yeşil
            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]
            //string[] colors = new string[4];  //4 elemandan oluşacak bir string renkler dizisi

            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Beyaz";
            //colors[3] = "Yeşil";

            //Console.WriteLine(colors[2]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]); //bir int dizisinde listede tanımlanmayan boşluklar bize 0 olarak yazdırılır

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Yeşil", "Beyaz", "Kırmızı", "Mavi", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);   
            //}

            //int[] numbers = { 4, 85, 74, 79, 90, 123, 54, 644, 6782, 1267, 156 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "mehmet", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 513, 123, 5, 3, 956, 32, 76, 233, 80, 23 };
            //Array.Sort(numbers);           //diziyi küçükten büyüğe sıralar
            //for (int i  = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 513, 123, 5, 3, 956, 32, 76, 233, 80, 23 };
            //Array.Reverse(numbers);      //diziyi komple tersten sıralar
            //for (int i  = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali", "bartu", "çınar", "kaya", "ahmet", "mustafa" };
            //int index = Array.IndexOf(customers, "mustafa");  //mustafanın hangi index'e sahip olduğu
            //Console.WriteLine(index);

            //int[] numbers = { 51, 23, 46, 79, 90, 25, 57, 47, 87, 18 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min()); 

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehrini Giriniz: ");  //dolar işareti parantez gibi şeyler olmadan parametresel ifadeler kullanmamızı sağlar (çift tırnak bütünlüğünü bozmadan)
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------");

            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50, };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Console.WriteLine("Çift Sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("Tek Sayılar");

            for (int i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion

            Console.Read();
        }
    }
}
