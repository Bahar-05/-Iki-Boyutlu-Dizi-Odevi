using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İkiBoyutluDiziÖdevi.App
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.Write("Adınızı Giriniz:");
            string ad= Console.ReadLine();

            Console.WriteLine("Soyadınızı Giriniz:");
            string soyad=Console.ReadLine();

            Console.Write("Vize notunu giriniz: ");
            float vize = Convert.ToSingle(Console.ReadLine());

            Console.Write("Final notunu giriniz: ");
            float final = Convert.ToSingle(Console.ReadLine());

           float ortalama = (float)(vize * 0.4) + (float)(final * 0.6);
            Console.WriteLine("\n Not Ortalamanız = " + ortalama);

            if (ortalama > 88)
            {
                Console.WriteLine("AA ile dersi geçtiniz.");
            }
            else if (ortalama > 78)
            {
                Console.WriteLine("BA ile dersi geçtiniz.");
            }
            else if (ortalama >68)
            {
                Console.WriteLine("BB ile dersi geçtiniz.");
            }
            else if (ortalama > 59)
            {
                Console.WriteLine("CB ile dersi geçtiniz.");
            }
            else if (ortalama > 49)
            {
                Console.WriteLine("CC ile dersi geçtiniz.");
            }

            else if (ortalama>39)
            {
                Console.WriteLine("Kaldınız. Harf Notunuz : DC");
            }
            else if (ortalama>30)
            {
                Console.WriteLine("Kaldınız. Harf Notunuz : DD");
            }
            else if (ortalama>24)
            {
                Console.WriteLine("Kaldınız. Harf Notunuz: FD");
            }
            else if (ortalama<24)
            {
                Console.WriteLine("Kaldınız. Harf Notunuz: FF");
            }

           
            Console.ReadLine();






        }
    }
}
