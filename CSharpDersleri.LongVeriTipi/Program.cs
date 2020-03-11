using System;

namespace CSharpDersleri.LongVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            long ilknumara = 92233720368547;
            long ikincinumara = -92233720368547;

            long maxdeger = 9223372036854775807;
            long mindeger = -9223372036854775808;

            Console.WriteLine("İlk Sayı: {0}",ilknumara);
            Console.WriteLine("İlk Sayı: {0}",ikincinumara);

            Console.WriteLine("Max Sayı: {0}",maxdeger);
            Console.WriteLine("Min Sayı: {0}",mindeger);

            Console.ReadLine();
        }
    }
}
