using System;

namespace CSharpDersleri.ShortVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            short ilknumara = 10;
            short ikincinumara = -15;

            short maxdeger = 32767;
            short mindeger = -32768;

            Console.WriteLine("İlk Sayı: {0}", ilknumara);
            Console.WriteLine("İlk Sayı: {0}", ikincinumara);

            Console.WriteLine("Max Sayı: {0}", maxdeger);
            Console.WriteLine("Min Sayı: {0}", mindeger);

            Console.ReadLine();
        }
    }
}
