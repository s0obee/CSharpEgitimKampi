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
            #region Yazdırma Komutları

            //Console.Write("Merhaba Dünya..: ");
            //Console.WriteLine("Selam..:");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı

            //string name;
            //name = "Yunus";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("****Rezervasyon Kartı****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri..: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim..: " + customerPhone);
            //Console.WriteLine("Email Adresi..: " + customerEmail);
            //Console.WriteLine("Adres..: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();
            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri..: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim..: " + customerPhone);
            //Console.WriteLine("Email Adresi..: " + customerEmail);
            //Console.WriteLine("Adres..: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------");

            #endregion

            #region Int Değişkenler

            //int 
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("****Restoran Menü Fiyatı****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı..: " +  hamburgerPrice + " Tl");
            Console.WriteLine("-----Kola Fiyatı..: " + cokePrice + " Tl");
            Console.WriteLine("-----Su Fiyatı..: " +  waterPrice + " Tl");
            Console.WriteLine("-----Kızartma Fiyatı..: " +  friesPrice + " Tl");
            Console.WriteLine("-----Pizza Fiyatı..: " +  pizzaPrice + " Tl");
            Console.WriteLine("-----Limonata Fiyatı..: " +  lemonadePrice + " Tl");
            Console.WriteLine();
            Console.WriteLine("****Restoran Menü Fiyatı****");
            Console.WriteLine();


            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;
            int totalPrice;

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
            totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Hamburger Tutarı..: " + totalHamburgerPrice + " Tl");
            Console.WriteLine("Kola Tutarı..: " + totalCokePrice + " Tl");
            Console.WriteLine("Su Tutarı..: " + totalWaterPrice + " Tl");
            Console.WriteLine("Kızartma Tutarı..: " + totalFriesPrice + " Tl");
            Console.WriteLine("Pizza Tutarı..: " + totalPizzaPrice + " Tl");
            Console.WriteLine("Limonata Tutarı..: " + totalLemonadePrice + " Tl");
            Console.WriteLine();
            Console.WriteLine("Toplam Tutar..: " + totalPrice + " Tl");



            #endregion


            Console.Read();
        }
    }
}