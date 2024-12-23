using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //For(x;y;z;) şeklinde 3 parametre alır. x başlangıcı, y bitişi, z de artış-azalışı tutar

            //int i;

            //for (i=1;i<=15;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i =3; i<=50; i+=3)
            //{
            //    Console.WriteLine(i);       // 3,6,9,12...
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1;i <= finishValue;i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;

            //for (int i = 0; i < =10; i++)
            //{
            //    totalValue += i; 
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //    }
            //}

            //Console.WriteLine(totalValue);

            //int count = 0;

            //for (int i=0; i<=60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-----");
            //Console.WriteLine(count);

            #endregion

            #region Bakteri Sorusu

            //1-2-4-8-16...

            //Her saat ikiye bölünen 1 bakteri, 24 saatin sonunda kaç tane olur. 

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)   //saat değişkeni için 
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".saat sonunda: " + bacterium);
            //} 

            #endregion

            #region While Döngüsü

            //While(Şart)
            //{ işlemler }

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //} 

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum +=i ;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen üç basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            Console.Write("Sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = (number / 100);  //456 / 100 = 4.56 => 4  

            Console.WriteLine(hundreds + "-" + tens + "-" + ones);
            sum = ones + tens + hundreds;
            Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
