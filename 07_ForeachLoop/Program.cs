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
            #region Foreach
            //foreach(değişkenTürü, değişkenAdı, in, dizi);

            //string[] cities = { "niğde", "ankara", "bursa" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 41, 9, 52, 67 ,84};
            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int[] numbers = { 45, 97, 12, 0, 1, 67, 41, 58, 3 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,8,9
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "hello";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Soru
            Console.Write("Sınıfta kaç öğrenci var? ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            string[]studentNames = new string[studentCount];
            double[]studentExamAvg= new double[studentCount];

            for(int i = 0;i<studentCount;i++)
            {
                Console.Write($"{i+1}. öğrencinin adını giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu

                for(int j=0; j<3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav ortalamaları
            for(int i = 0; i<studentCount;i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                //GEÇİP KALMA DURUMU
                if (studentExamAvg[i] <= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci KALDI");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci GEÇTİ");
                }
            }
            #endregion
            Console.Read();
        }
    }
}
