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
            #region double değişkenler
            //double number = 15.4;
            //Console.WriteLine(number);


            //Console.WriteLine("*****Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 25.45;
            //strawberryPrice = 99.99;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Elma Birim Fiyatı-----" + applePrice);
            //Console.WriteLine("-----Portakal Birim Fiyatı-----" + orangePrice);
            //Console.WriteLine("-----Çilek Birim Fiyatı-----" + strawberryPrice);
            //Console.WriteLine("-----Patates Birim Fiyatı-----" + potatoPrice);
            //Console.WriteLine("-----Domates Birim Fiyatı-----" + tomatoPrice);


            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 1.459;
            //strawGram = 0.825;
            //potatoGram = 4.692;
            //tomatoGram = 2.457;


            //double appleTotalPrice=applePrice*appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice=strawberryPrice*strawGram;
            //double potatoTotalPrice=potatoPrice*potatoGram;
            //double tomatoTotalPrice=tomatoPrice*tomatoGram;


            //Console.WriteLine("Elmanın Toplam Fiyatı: " + appleTotalPrice);
            //Console.WriteLine("Portakal Toplam Fiyatı: " + orangeTotalPrice);
            //Console.WriteLine("Çilek Toplam Fiyatı: " + strawberryTotalPrice);
            //Console.WriteLine("Patates Toplam Fiyatı: " + potatoTotalPrice);
            //Console.WriteLine("Domates Toplam Fiyatı: " + tomatoTotalPrice);

            //double shoppingTotalPrice= appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine(shoppingTotalPrice);
            #endregion

            #region Char Değişkenler

            //char symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("**** Hava Yolları Yolcu Bilgileri *****");
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.WriteLine("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.WriteLine("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();



            //Console.WriteLine();
            //Console.WriteLine("------------");
            //Console.WriteLine("Yolcu:" +passengerIdentityNumber+" "+passengerName+" "+passengerSurname+" "+ passengerDistrict+" / "+passengerCity+" "+passengerAge);



            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 50000;

            //int shoesCount,computerCount,chairCount,tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen sandalye ayakkabı sayısını giriniz: ");
            //chairCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen televizyon ayakkabı sayısını giriniz: ");
            //tvCount =int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairPrice * chairCount + tvPrice * tvCount; 
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gerekn miktar: " +  totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1. Sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result=(exam1 + exam2+exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet giriniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion

            Console.Read();
        }
    }
}
