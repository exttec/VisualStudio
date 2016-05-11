using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy
{
    class Program
    {
        static void Main(string[] args)
        {

            Pietra naszePietra = new Pietra();
            Pietra naszePietra2 = new Pietra();




            naszePietra.ilLudzi = 10;
            naszePietra2.ilLudzi = 15;

            Pietra.ilMieszkancow = 10;
            Console.WriteLine(naszePietra2.ilLudzi);
            Console.WriteLine(naszePietra.ilLudzi);

            Console.ReadLine();


            KlatkiWBloku.ilPieter = 5;
            KlatkiWBloku.ilMieszkanNaPietro = 3;

            Aplikacja odczyt = new Aplikacja();
            odczyt.OdczytDanych();

        }
    }

    class Aplikacja
    {
        public void OdczytDanych()
        {
            Console.WriteLine(KlatkiWBloku.ilPieter);
            Console.WriteLine(KlatkiWBloku.ilMieszkanNaPietro);
            Console.ReadLine();


        }

    }

    class Pietra
    {
        public int ilLudzi;
        public static int ilMieszkancow;

    }

    static class KlatkiWBloku
    {

        public static int ilPieter;
        public static int ilMieszkanNaPietro;


    }
}
