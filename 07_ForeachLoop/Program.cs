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

            ////Foreach(1;2;3;4)

            ////1:Değişken Türü
            ////2:Değişken Adı
            ////3:In
            ////4:Liste, Koleksiyon, Dizi

            ////Dizilerle Foreach
            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string city in cities) 
            //{
            //    Console.WriteLine(city);    
            //}

            //int[] numbers = {45,78,985,635,74,11,22,33,41,205,6578,10394};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers) 
            //{
            //    //Çift Sayıları Yazdırır
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            ////Listelerle Foreach
            //List<int> numbers = new List<int>()
            //{
            //    1,2, 3, 4, 5, 8
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki ğrenci Sayısını Kullanıcıdan Alma 
            Console.WriteLine("------------------------------"); 
            Console.Write("Sınıfınızda Kaç Öğrenci Var ..: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci İsimlerini ve Notlarını Saklayacak Diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin İsmini Giriniz ..: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her Bir Öğrenci İçin 3 Sınav Notu Girişi Yapalım
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write($"{studentNames[i]} Adlı Öğrencinin {j + 1}. Sınav Notunu Giriniz ..: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //Notları Topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav Ortalamalrı
            for(int i = 0;i < studentCount;i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine();

                Console.WriteLine($"{studentNames[i]} Adlı Öğrencinin Ortlaması ..: {studentExamAvg[i]}");
                
                //Öğrencilerin Ortalaması ve Geçip Kalma Durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersten Geçti ..: ");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersten Kaldı ..: ");
                }

                Console.WriteLine();
                Console.WriteLine("------------------------------");
            }
            



            #endregion
            Console.ReadLine();
        }
    }
}
