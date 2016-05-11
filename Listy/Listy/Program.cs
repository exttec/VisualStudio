using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy
{
    class Program
    {
        static Dane[] mojaTablica = new Dane[2];

        static void Main(string[] args)
        {
            // WYŁAPYWANIE BŁĘDÓW
            //try
            //{
            //    MojeDane();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message.ToString());
            //}

            //Console.ReadLine();


            List<int> listIntow = new List<int>();
            List<Dane> mojeDane = new List<Dane>();

            mojeDane.Add(new Dane { MojeID = 1, Imie = "Adam", Nazwisko = "Wasik" });
            mojeDane.Add(new Dane { MojeID = 1, Imie = "Stefan", Nazwisko = "Wasik" });

            var dane = new Dane { MojeID = 2, Imie = "Jan", Nazwisko = "Wąsik" };
            mojeDane.Add(dane);

           

      


            mojaTablica = mojeDane.ToArray();

            foreach (var i in mojeDane)
            {
                Console.WriteLine(i.Imie + " " + i.Nazwisko + " " + i.MojeID);
            }
            Console.ReadLine();


            foreach (var i in mojaTablica)
            {
                Console.WriteLine(i.Imie + " " + i.Nazwisko + " " + i.MojeID);
            }
            Console.ReadLine();

        }

        private static void MojeDane()
        {
            throw new NotImplementedException();
        }
    }
    public class Dane
    {
        public int MojeID;
        public string Imie;
        public string Nazwisko;
    }

}
