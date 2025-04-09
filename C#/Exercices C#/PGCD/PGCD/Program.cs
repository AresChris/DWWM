namespace PGCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, reste;
            Console.Write("Inscrivez la valeur de a : ");
            a = int.Parse(Console.ReadLine());

            Console.Write("indiquez la valeur de b : ");
            b = int.Parse(Console.ReadLine());

            int pgcd = Calcul_PGCD(a, b);
            Console.WriteLine($"Le PGCD de {a} et {b} est {pgcd}");
        }
        static int Calcul_PGCD(int a, int b)
        {
            while (b != 0)
            {
                int reste = a % b;
                a = b;
                b = reste;
            }
            return a;
        }
    }
}
