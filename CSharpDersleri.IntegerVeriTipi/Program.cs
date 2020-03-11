using System;

namespace CSharpDersleri.IntegerVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");

            int ilknumara = 10;
            int ikincinumara = -10;
            Console.WriteLine("İlk Sayı: {0} - İkinci Sayı: {1}",ilknumara,ikincinumara);
   

            int maxnumara = 2147483647;
            int minnumara = -2147483648;
            Console.WriteLine("Max Sayı: {0} - Min Sayı: {1}", maxnumara, minnumara);
            Console.ReadLine();
        }
    }
}
