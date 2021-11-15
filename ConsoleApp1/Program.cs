using System;

namespace Caf
{
    internal class Program
    {
        static bool askProgramm = true;
        static int choice = 0;

        static Utente utente = new Utente();
        static void Main(string[] args)
        {
            while (askProgramm)
            {

                maschera();

                if (choice != 5)
                {
                    Console.WriteLine("Inserisci il tuo nome.");
                    utente.Nominativo = Console.ReadLine();
                }

                switch (choice)
                {
                    case 1:
                        pensione();
                        break;
                    case 2:
                        redditoDiCittadinanza();
                        break;
                    case 3:
                        naspi();
                        break;
                    case 4:
                        Console.WriteLine("Tassazione.");
                        break;
                    case 5:
                        Console.WriteLine("Fine programma.");
                        askProgramm = false;
                        break;
                    default:
                        Console.WriteLine("Scelta errata!");
                        break;
                }

                if (askProgramm)
                {
                    maschera2();
                }
            }
        }
        public static void maschera()
        {
            Console.WriteLine("Scelta del programma:\n 1. Pensioni \n 2. Reddito di cittadinanza \n 3. Naspi \n 4. Tassazione \n 5. Fine programma");
            do
            {
                choice = int.Parse(Console.ReadLine());

                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Attenzione! scegli tra 1 e 5!");
                }
            } while (choice < 1 || choice > 5);
        }
        public static void maschera2()
        {
            Console.WriteLine("Vuoi effettuare altre operazione? S/N");

            string otherChoice = Console.ReadLine().ToUpper();

            while (otherChoice != "N" && otherChoice != "S")
            {
                Console.WriteLine("Attenzione! Rsipondi S o N S/N");
                otherChoice = Console.ReadLine().ToUpper();
            }

            if (otherChoice == "S")
            {
                askProgramm = true;
            }
            else
            {
                askProgramm = false;
                Console.WriteLine("Fine programma");
            }
        }
        public static void pensione()
        {
            Pensione pensione = new Pensione();
            Console.WriteLine("Inserisci la tua eta.");
            utente.Eta = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci gli anni di attività.");
            pensione.AnniAttivita = int.Parse(Console.ReadLine());
            if (pensione.calcAll(pensione.AnniAttivita, utente.Eta))
            {
                Console.WriteLine("Hai diritto alla pensione");
            }
            else
            {
                Console.WriteLine($"Non hai diritto alla pensione. Anni mancanti {pensione.anniMancanti(pensione.AnniAttivita, utente.Eta)}");
            }
        }

        public static void redditoDiCittadinanza()
        {
            Console.WriteLine("Inserisci la tua eta.");
            utente.Eta = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il tuo Isee.");
            double isee = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il tuo Patrimonio immobiliare.");
            double pI = double.Parse(Console.ReadLine());
            RedditoDiCittadinanza rC = new RedditoDiCittadinanza(isee, pI);
            if (rC.checkAll(utente.Eta))
            {
                Console.WriteLine("Hai diritto al reddito di cittadinanza.");
            }
            else
            {
                Console.WriteLine("Non hai diritto al reddito di cittadinanza.");
            }
        }

        public static void naspi()
        {
            Console.WriteLine("Inserisci l'importo netto dell'ultima busta paga.");
            double netto = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci i mesi di occupazione.");
            int mesiO = int.Parse(Console.ReadLine());
            Naspi naspi = new Naspi(netto, mesiO);
            if (naspi.checkAnniOccupazione())
            {
                double naspiPayment = naspi.calcAll();
                Console.WriteLine($"Hai diritto ad una Naspi di {naspiPayment}.");
            }
            else
            {
                Console.WriteLine("Non hai diritto alla Naspi.");
            }
        }
    }
}
