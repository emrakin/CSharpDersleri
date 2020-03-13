using System;

namespace CSharpDersleri.DecimalVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sayi1 = 10;
            decimal sayi2 = 10.5m;
            decimal sayi3 = -10;
            decimal sayi4 = -10.5m;

            decimal maxDecimalDegeri = decimal.MaxValue;
            decimal minDecimalDegeri = decimal.MinValue;

            Console.WriteLine("Birinci sayı: {0}", sayi1);
            Console.WriteLine("Ikinci sayı: {0}", sayi2);
            Console.WriteLine("Üçüncü sayı: {0}", sayi3);
            Console.WriteLine("Dördüncü sayı: {0}", sayi4);
            Console.WriteLine("Maksimum deger: {0}", maxDecimalDegeri);
            Console.WriteLine("Minimum deger: {0}", minDecimalDegeri);

            Console.ReadLine();
        }
    }
}
