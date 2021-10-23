using System;

namespace ManavProgramı
{
    class Program
    {
        static void Main(string[] args)
        {
            double meyve, kilo, fiyat = 0;
            while (true)
            {
                Console.WriteLine("Elma(1) 5 TL");
                Console.WriteLine("Armut(2) 10 TL");
                Console.WriteLine("Çilek(3) 15 TL");
                Console.WriteLine("Üzüm(4) 7.5 TL");
                Console.WriteLine("Muz(5) 20 TL");

                Console.WriteLine("Lütfen meyve seçiniz.");
                meyve = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kaç kilo alacaksınız?");
                kilo = Convert.ToDouble(Console.ReadLine());
                switch (meyve)
                {
                    case 1:
                        fiyat = kilo * 5; Console.WriteLine("Toplam fiyat " + fiyat.ToString());
                        break;
                    case 2:
                        fiyat = kilo * 10; Console.WriteLine("Toplam fiyat " + fiyat.ToString());
                        break;
                    case 3:
                        fiyat = kilo * 15; Console.WriteLine("Toplam fiyat " + fiyat.ToString());
                        break;
                    case 4:
                        fiyat = kilo * 7.5; Console.WriteLine("Toplam fiyat " + fiyat.ToString());
                        break;
                    case 5:
                        fiyat = kilo * 20; Console.WriteLine("Toplam fiyat " + fiyat.ToString());
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim yaptınız.");
                        break;

                }

                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
