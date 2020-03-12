using System;

namespace CSharpDersleri.ByteVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            byte birinci = 5;
            byte ikinci = 8;

            byte maxdeger = 255;
            byte mindeger = 0;


            Console.WriteLine("İlk Sayı: {0}", birinci);
            Console.WriteLine("İlk Sayı: {0}", ikinci);

            Console.WriteLine("Max Sayı: {0}", maxdeger);
            Console.WriteLine("Min Sayı: {0}", mindeger);

            Console.ReadLine();
        }
    }
}
