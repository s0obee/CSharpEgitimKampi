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

            ////()
            ////Void Metot -> Geriye Değer Döndürmeyen Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
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

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}

            //WriteMethod("Yunus Çakıcı");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine($"Müşteri ..: {name} {surName}");  
            //}

            //CustomerCard("Yunus", "Çakıcı");
            //CustomerCard("Ali","Durmuş");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int num1,int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;    
            //    Console.WriteLine(result);
            //}

            //Sum(4,5,6);


            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Yıldız";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke ..: "+ countryName + "\nBaşkent ..: " + capital + "\nBayrak Rengi ..: " + flagColor;
            //    return cardInfo;
            //}

            //string cN, c, fC; //cN = countryName , c = capital , fC = flagColor

            //Console.Write("Ülke Adını Giriniz ..: ");
            //cN = Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz ..: ");
            //c = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz ..: ");
            //fC = Console.ReadLine();

            //Console.WriteLine(CountryCard(cN, c, fC));
            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int num1, int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));


            #endregion

            #region Örnek Uygulama 

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50) 
                {
                    return student + " ..: Öğrenci Geçti -- Ortalama ..: " + result;
                }
                else
                {
                    return student + " ..: Öğrenci Başarısız Oldu -- Ortalama ..: " + result;


                }
            }

            Console.WriteLine(ExamResult("Ali",25,41,85));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));
            Console.WriteLine(ExamResult("Zeki", 36, 38, 33));

            #endregion

            Console.Read();
        }
    }
}
