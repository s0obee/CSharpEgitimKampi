﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if

            //Console.Write("Lütfen şifreyi giriniz..: ");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd") {
            //    Console.WriteLine("Şifre Doğru ..: ");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış ..: ");
            //}


            //string capital;
            //string country;
            //Console.Write("Başkenti Giriniz ..:");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeye Giriniz ..:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı ..: ");
            //}
            //else
            //{
            //    Console.Write("Hatalı Veri Girişi ..: ");
            //}

            //int number;
            //Console.WriteLine("Sayıyı Giriniz ..: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5) {
            //    Console.WriteLine("Sayı Doğru ..: ");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı ..: ");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata ..:";
            //Console.Write("Sınav 1 ..: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2 ..: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3 ..: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 +  exam2 + exam3) / 3;

            //if (average > 0 & average<=50) {
            //    result = "Sonuç Vasat ..:";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta ..:";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi ..:";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi ..:";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız ..:");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon") {
            //    Console.Write("Şehir Mevcut ..: ");
            //}
            //else
            //{
            //    Console.Write("Şehir Mevcut Değil ..: ");
            //}


            //Console.WriteLine("Lütfen Kullanıcı Adını Giriniz ..: ");
            //string username = Console.ReadLine();
            //if (username != "admin") {
            //    Console.WriteLine("Bu Kullanıcı Adı Kabul Edilemez ..: ");
            //}else { Console.WriteLine("Hoşgeldiniz ..: "); }

            //Console.ReadLine();

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result= number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. Sayıyı Giriniz ..: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Giriniz ..: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.Sayının 2. Sayıya Bölümünden Kalan ..: " + result);

            //Console.Write("Lütfen Sayıyı Giriniz ..: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0) {
            //    Console.Write("Sayi Çifttir ..: ");
            //}
            //else
            //{
            //    Console.Write("Sayi Tektir ..: ");
            //}
            #endregion

            #region Char Değişkenler işle Karar Yapıları

            //char team;
            //Console.Write("Lütfen Taraftari Olduğunuz Takımın Sembolünü Giriniz ..: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G') { 
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("**** C Sharp Eğitim Kampi Restorant ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();

            //String menuItem;
            //Console.WriteLine("Detayını Görmek İstediğiniz Menü Seçimi ..: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1") {
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk ");
            //    Console.WriteLine("2- Kızartma Tabağı ");
            //    Console.WriteLine("3- Fasulye Pilav ");
            //    Console.WriteLine("4- Fırında Somon ");
            //    Console.WriteLine("5- Patlıcan Musakka ");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası ");
            //    Console.WriteLine("2- Ezogelin Çorbası ");
            //    Console.WriteLine("3- Kelle Paça Çorbası ");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza ");
            //    Console.WriteLine("2- Margaritha Pizza ");
            //    Console.WriteLine("3- Tavuklu Pizza ");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola ");
            //    Console.WriteLine("2- Ayran ");
            //    Console.WriteLine("3- SU ");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe ");
            //    Console.WriteLine("2- Kazandibi ");
            //    Console.WriteLine("3- Sütlaç ");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write(" Lütfen Ay Girişi Yapınız ..: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi ..: "); break;

            //}


            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("1.Sayıyı Giriniz ..: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz ..: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz ..: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam ..: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark..: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım ..: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm ..: " + result);
                    break;
            }

            #endregion

            Console.ReadLine();


        }
    }
}
