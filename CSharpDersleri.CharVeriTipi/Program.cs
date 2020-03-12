using System;

namespace CSharpDersleri.CharVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Char veri tiplerine doğrudan karakter atayabilirsiniz.
            char deger1 = 'A';

            // Char veri tipine hexadecimal karakter karşılında değer atabilirsiniz.
            char deger2 ='\x0058';

            //Char veri tipine ASCII sayısal karşılığından Char tipine dönüşüm yapabilirsiniz.
            char deger3 = (char)55;

            //Char veri tipine Unicode karakter ataması yapabilirsiniz.
            char deger4 = '\u0058';

            Console.WriteLine(deger1);
            Console.WriteLine(deger2);
            Console.WriteLine(deger3);
            Console.WriteLine(deger4);

            Console.ReadLine();
        }
    }
}
