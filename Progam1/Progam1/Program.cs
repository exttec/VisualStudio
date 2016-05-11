using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progam1
{
    class Program
    {

        static List<Pietro> pietra = new List<Pietro>();
        static bool jestImpreza = false;
        static Random rndPietro = new Random();
        static Random rndPietroDocelowe = new Random();
        static Random rndLudzi = new Random();




        static void Main(string[] args)
        {
            try 
            {
                Wypelniacz();
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
                Console.ReadLine();

            }

            Musk();

            Console.ReadLine();

        }





        private static void Musk()
        {
            while (!jestImpreza)
            {
                Mieszaj();
            }
        }

        private static void Mieszaj()
        {
            int rndP = rndPietro.Next(0, 4);
            int rndPD = rndPietroDocelowe.Next(0, 4);
            int rndL = rndLudzi.Next(0, 100);
            



            // nie na to samo pietro
            while (rndP == rndPD)
            {
                rndPD = rndPietroDocelowe.Next(0, 4);

                Console.WriteLine(rndP + " " + rndPD);
                if (rndP != rndPD) break;

            }

            // max il ludzi

            var pieterko = pietra.Find(element => element.kondygnacja == rndP);

            Console.WriteLine(pieterko);
            Console.ReadLine();

            //foreach (var item in pietra)
            //{
            //    item.ilosc
            //}
            //while (rndL == pietra.
            //{

            //}





            foreach (var i in pietra)
            {
                if(i.kondygnacja == rndP)
                {
                    PrzemiescLudzi(rndL,rndP,rndPD);
                }
            }

        }

        private static void PrzemiescLudzi(int ile, int z, int gdzie)
        {
           
        }

        static void Wypelniacz()
        {
            pietra.Add(new Pietro { kondygnacja = 0, ilosc = 13 });
            pietra.Add(new Pietro { kondygnacja = 1, ilosc = 5 });
            pietra.Add(new Pietro { kondygnacja = 2, ilosc = 10 });
            pietra.Add(new Pietro { kondygnacja = 3, ilosc = 8 });
            pietra.Add(new Pietro { kondygnacja = 4, ilosc = 11 });


        }


    }
}
