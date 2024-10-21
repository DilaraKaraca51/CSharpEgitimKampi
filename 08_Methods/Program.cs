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
            #region Void Methodlar

            //Geriye değer döndürmeyen methodlar
            //Customer--> listele,sil,güncelle,kaydet

            //void CustomerList()
            //{
            //    Console.WriteLine("Dilara");
            //    Console.WriteLine("Ayşe");
            //    Console.WriteLine("Fatma");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+ y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Methodlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Dilara Karaca");

            //void CustomerCard(string Name, string Surname)
            //{
            //    Console.WriteLine("Müşteri: " + Name +" "+ Surname);
            //}
            //CustomerCard("Dilara", "Karaca");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Methodlar
            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Method
            //string StudentCard()
            //{
            //    string name = "Dilara";
            //    string surname = "Karaca";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametreli Method
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "- Başkent: " + capital + "- Bayrak Rengi" + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak Rengi giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Method
            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(41, 30));
            #endregion

            #region Örnek Uygulama
            //string examResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2+exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student +"öğrenci geçti" + "ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student +  "kaldı" + "ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(examResult("DİLARA", 41, 30, 26));
            #endregion
            Console.Read();
        }
    }
}
