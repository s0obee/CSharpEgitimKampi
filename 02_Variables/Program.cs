using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("*****Fiyat Listesi*****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı..: " + applePrice + " Tl");
            //Console.WriteLine("---- Portakal Birim Fiyatı..: " + orangePrice + " Tl");
            //Console.WriteLine("---- Çilek Birim Fiyatı..: " + strawberryPrice + " Tl");
            //Console.WriteLine("---- Patates Birim Fiyatı..: " + potatoPrice + " Tl");
            //Console.WriteLine("---- Domates Birim Fiyatı..: " + tomatoPrice + " Tl");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram , orangeGram , strawGram , potatoGram , tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = .750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawTotalPrice = strawberryPrice * strawGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan ürün : Elma     -> " + "| Birim Fiyatı..: " + applePrice + "| Gramaj..: " + appleGram + "| Toplam Tutar..: "  + appleTotalPrice + " |");
            //Console.WriteLine("Alınan ürün : Portakal -> " + "| Birim Fiyatı..: " + orangePrice + "| Gramaj..: " + orangeGram + "| Toplam Tutar..: "  + orangeTotalPrice + " |");
            //Console.WriteLine("Alınan ürün : Çilek    -> " + "| Birim Fiyatı..: " + strawberryPrice + "| Gramaj..: " + strawGram + "| Toplam Tutar..: "  + strawTotalPrice + " |");
            //Console.WriteLine("Alınan ürün : Patates  -> " + "| Birim Fiyatı..: " + potatoPrice + "| Gramaj..: " + potatoGram + "| Toplam Tutar..: "  + potatoTotalPrice + " |");
            //Console.WriteLine("Alınan ürün : Domates  -> " + "| Birim Fiyatı..: " + tomatoPrice + "| Gramaj..: " + tomatoGram + "| Toplam Tutar..: "  + tomatoTotalPrice + " |");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar..: " + shoppingTotalPrice + " Tl");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Ver Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passangerCountry, passengerAge, passengerId;

            //Console.Write("Yolcu Adı..: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı..: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu İlçe Bilgisi..: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu Şehir Bilgisi..: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Ülke Bilgisi..: ");
            //passangerCountry = Console.ReadLine();

            //Console.Write("Yolcu Yaş Bilgisi..: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu ID Bilgisi..: ");
            //passengerId = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Adı Soyadı..: " + passengerName + " " +  passengerSurname);
            //Console.WriteLine("Yolcu İkametgah Bilgisi..: " + passengerDistrict + "/" + passengerCity + "/" + passangerCountry);
            //Console.WriteLine("Yolcu Yaş Bilgisi..: " + passengerAge);
            //Console.WriteLine("Yolcu ID Bilgisi..: " + passengerId);



            #endregion

            #region Klavyeden Tam Sayı Girişleri Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz..: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz..: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz..: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz..: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Fiyat..: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz..: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz..: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz..: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız..: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz..: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet..: " + gender);

            #endregion

            Console.Read();
        }
    }
}
