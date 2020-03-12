using System;

namespace CSharpDersleri.BoolVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = 8;

            // sayi değişkenine atadığımız değerin 12 den büyük mü olduğunu kontrol edelim
            bool sonuc = sayi > 12;
            bool sonuc2 = sayi < 12;

            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
            Console.ReadLine();
        }
    }
}
