using System.ComponentModel.Design;

namespace exercice_1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombreN = 0;
            Console.WriteLine("Saisir un nombre :");
            String input = Console.ReadLine();
            Boolean prime = true;
            Boolean integer = false;

            if (int.TryParse(input, out nombreN))
            {
                integer = true;
                if (nombreN < 1 && integer == false)
                {
                    Console.WriteLine("Les nombres premiers sont positifs, inscrivez un entier.");
                    prime = false;
                }
                else if(nombreN <1 && integer == true) {
                    {
                        Console.WriteLine("Les nombres premiers sont positifs");
                        prime = false;
                    }
                    if (nombreN >= 1 && integer == true)
                    {
                        prime = true;
                    }
                    else if (nombreN >= 1 && integer == false)
                     {
                        prime = false;
                        Console.WriteLine("Les nombres premiers sont positifs.");
                     }
                }
            }
            else
            {
                Console.WriteLine("Saisissez un entier");
            }
                if (prime)
                {
                    if (nombreN % 2 == 0)
                    {
                        Console.WriteLine("Ce nombre n'est pas premier");
                    }
                    else
                    {
                        Console.WriteLine("Ce nombre est premier");
                    }
                }
        }
     }
}


