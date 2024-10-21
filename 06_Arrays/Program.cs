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
            //DeğişkenTürü[]DiziAdı = new DeğişkenTürü[ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "Mavi";
            //colors[1] = "Beyaz";
            //colors[2] = "Siyah";
            //Console.WriteLine(colors[2]);

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 28;
            //numbers[8] = 41;
            //numbers[9] =691;
            //Console.WriteLine(numbers[6]);

            //string[] cities = { "Niğde", "Adana", "Mersin", "Konya" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanalarını Listeleme
            //string[] colors = { "Pembe", "Yeşil", "Turuncu", "Sarı", "Kahverengi" };
            //for (int i = 0; i< colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 5, 9, 14, 28, 49, 95, 129, 578, 529, 691, 907, 1000 };
            //for(int i = 0; i<numbers.Length;i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //int[] myArray = { 5, 9, 14, 28, 49, 95, 129, 578, 529, 691, 907, 1000 };
            //int maxNumber = myArray[0];
            //for(int i = 1; i <myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //       maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //Sort sıralar//reverse diziyi tersten sıralar
            //int[] number = { 0, 9, 3, 41, 691, 4 };
            //Array.Sort(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}
            #endregion

            #region Dizi Metotlar
            //string[] customers = { "dilara", "rabia", "mustafa" };
            //int index = Array.IndexOf(customers, "dilara");
            //Console.WriteLine(index);

            //int[] numbers = { 5, 9, 14, 28, 49, 95, 129, 578, 529, 691, 907, 1000 };
            //Console.WriteLine("En büyük: " + numbers.Max()+ " En küçük: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Veri Alma

            //string[] cities = new string[5];
            //    for(int i = 0; i < cities.Length; i++)
            //    {
            //        Console.WriteLine($"Lütfen {i+1}. şehri giriniz: ");
            //        cities[i] = Console.ReadLine();
            //    }
            //Console.WriteLine("");
            //Console.WriteLine("--------------------");
            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] number = { 24, 54, 94, 13, 51, 38, 41 };
            Console.WriteLine("Çift Sayılar");
            for(int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    Console.WriteLine(number[i]);
                }
            }
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 1)
                {
                    Console.WriteLine(number[i]);
                }
            }
            #endregion
            Console.Read();
        }
    }
}
