using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METODY
{
    class Program
    {
        static void Main(string[] args)
        {

            NowyObiekt nowyObiekt = new NowyObiekt();
            nowyObiekt.a = 15;
            nowyObiekt.b = 33;



            try
            {
                MojeDane();
                MojeDane(10);
                Console.WriteLine(Dodawanie(3, 1));


                Console.WriteLine(Dodawanie2(nowyObiekt));
                Console.WriteLine("Jakis tekst");








            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }
            Console.ReadLine();

        }

        private static void MojeDane()
        {

        }




        private static void MojeDane(int toJestInt)
        {
            Console.WriteLine(toJestInt);
        }


        private static int Dodawanie(int a, int b)
        {

            int wynik = a + b;

            return wynik;
        }

        private static int Dodawanie2(NowyObiekt nowyObiekt)
        {

            int wynik = nowyObiekt.a + nowyObiekt.b;

            return wynik;
        }
    }

    class NowyObiekt
    {

        public int a;
        public int b;


    }







}
