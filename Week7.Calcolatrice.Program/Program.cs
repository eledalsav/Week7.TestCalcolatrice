using System;
using Week7.Calcolatrice;

namespace Week7.Calcolatrice.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuare = true;
            do
            {
                Console.WriteLine("Benvenuto!");
                int choice;
                double x1, x2;
                bool check1, check2;
                do
                {
                    Console.WriteLine("Premi 1 per la somma\nPremi 2 per la moltiplicazione\nPremi 3 per la sottrazione\nPremi 4 per la divisione\nPremi 5 per confrontare due numeri");
                } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 5);
                do
                {
                    Console.WriteLine("Immetti i due numeri:\nx1=");
                    check1 = double.TryParse(Console.ReadLine(), out x1);
                    Console.WriteLine("x2=");
                    check2 = double.TryParse(Console.ReadLine(), out x2);
                } while (!check1 || !check2);

                Operazioni operazione = new Operazioni();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Il risultato di {x1} + {x2} è {operazione.RisolviSomma(x1, x2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Il risultato di {x1} * {x2} è {operazione.RisolviMoltiplicazione(x1, x2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Il risultato di {x1} - {x2} è {operazione.RisolviSottrazione(x1, x2)}");
                        break;
                    case 4:
                        if (x2 == 0)
                        {
                            Console.WriteLine("Divisione impossibile!");
                        }
                        else
                        {
                            Console.WriteLine($"Il risultato di {x1} / {x2} è {operazione.RisolviDivisione(x1, x2)}");
                        }
                        break;
                    case 5:
                        if (operazione.VerificaSeAMaggioreDiB(x1, x2))
                        {
                            Console.WriteLine($"{x1} è maggiore o uguale di {x2}");
                        }
                        else
                        {
                            Console.WriteLine($"{x1} è minore di {x2}");
                        }
                        break;
                }
                Console.WriteLine("Premi e per uscire, qualsiasi altro carattere per continuare");
                string exit = Console.ReadLine();
                if (exit == "e")
                {
                    continuare = false;
                }
            } while (continuare == true);
        }
    }
}
