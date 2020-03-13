using System;

namespace CSharpDersleri.DoubleVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            double deger1 = 243.14;
            double deger2 = -1432;
            double maxDoubleDegeri = double.MaxValue;
            double minDoubleDegeri = double.MinValue;

            Console.WriteLine("Birinci degisken: {0}",deger1);
            Console.WriteLine("Ikinci degisken: {0}",deger2);
            Console.WriteLine("Maksimum deger: {0}",maxDoubleDegeri);
            Console.WriteLine("Minimum deger: {0}",minDoubleDegeri);

            Console.ReadLine();
        }
    }
}
