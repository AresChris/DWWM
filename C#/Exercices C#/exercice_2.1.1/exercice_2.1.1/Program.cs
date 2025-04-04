using System.Threading.Channels;

namespace exercice_2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nombre, kms, miles;

            Console.Write("Inscrivez une valeur à convertir : ");
            kms = double.Parse(Console.ReadLine());

            miles = kms / 1.609;
            Console.WriteLine($"{kms} kms = {miles:F4} miles");
            if(kms < 0.01 && kms > 1000000)
            {
                Console.WriteLine("La valeur est hors limites");
            }
            Console.WriteLine("Fin du programme");
        }
    }
}
