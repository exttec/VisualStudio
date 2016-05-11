using System;


namespace MojaAplikacja
{
    class Program
    {
        static void Main(string[] args)

        {
            // ZMIENNE
            string zmienna = "Dupa biskupa\n";
            bool prawdaFalsz = false;
            int naszaCalkowita = 10;
            float zmiennoPrzecinkowa = 11.2F;

            var a = 10.2112f;
            var b = "test";
            var c = 10;

            a++;

            int[] pietra = new int[5];

            pietra[0] = 30;
            pietra[4] = 1;

            pietra[0] = 1;
            pietra[4] = 1;
            pietra[2] = 29;

            //foreach (var i in pietra)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();

            int i = 0; // indexer
            while (i<pietra.Length) 
            {
                Console.WriteLine(pietra[i]);   // konkretna wartosc z tablicy
                i++;                            // inkrementujemy zeby wyszedł z petli
            }
            Console.WriteLine("test2");

            Console.ReadLine();







            //----------------------------------------------------------

            //// PETRLA FOR

            //for(int licznik = 0;licznik <10; licznik++){
            //    Console.Write("Numer:" + licznik+"\n");
            // }
            //----------------------------------------------------------
            //var index = 1;
            //while(index<11)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}


            // SWITCH ---------------------------------------------------
            //var ilPieter = 2;

            //switch (ilPieter)
            //{
            //    case 0:
            //        // instrukcja
            //        break;
            //    case 1:
            //        //instrukcja
            //        break;
            //    case 2:
            //        //instrukcja
            //        break;
            //    case 3:
            //        //instrukcja
            //        break;
            //    case 5:
            //        //instrukcja
            //        break;
            //    default:
            //        //instrukcja
            //        break; 
            //}






            //niejawna konwersja zmiennej
            //zmienna += prawdaFalsz;


            // STALE
            //const int stalaInt = 1;
            //var z = "";
            //Console.WriteLine("Podaj liczbe:\n");
            //z = Console.ReadLine();

            //int za = Int32.Parse(z); // zamiana string to int
            //if (za > 10)
            //{


            //    Console.WriteLine(z);
            //}
            //else
            //{
            //    Console.WriteLine("Za mala");
            //}

            //Console.Clear();

            //var liczba = 0;
            //var liczbaBledow = 0;
            //Console.WriteLine("Podaj liczbe większą od 10:\n");
            //while(liczba < 11)
            //{
            //    liczba = int.Parse(Console.ReadLine()); // parsuje całkowite, jesli zmienno przecinkowa albo string to error
            //    liczbaBledow++;
            //    Console.Clear();
            //    if (liczbaBledow < 3) { 
            //        Console.WriteLine("Podaj liczbe większą od 10:\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("JESTEŚ DEBILEM!\nPodaj liczbe WIĘKSZĄ od 10:\n");

            //    }

            //}

            //Console.WriteLine("Udalo sie");




            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.WriteLine(zmienna);
            //Console.ReadKey();


            //zmienna = "Dupa biskupa2\n";
            //Console.WriteLine(zmienna);
            //Console.ReadKey();

        }





    }
}
