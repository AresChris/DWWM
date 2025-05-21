using LaFraction;
namespace LaFraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(12, 7);
            Fraction fraction2 = new Fraction(9, 1);
            Fraction fraction3 = new Fraction(0, 1);
            Fraction fraction4 = new Fraction(3, 4);
            Fraction fraction5 = new Fraction(1, 2);
            Console.WriteLine($"fraction1 : {fraction1.ToString()}");

            Console.WriteLine($"fraction2 : {fraction2.ToString()}");

            Console.WriteLine($"fraction3 : {fraction3.ToString()}");

            Console.WriteLine($"fraction4 : {fraction4.ToString()}");

            Console.WriteLine($"L'opposé de fraction4 est : {fraction4.Oppose(fraction4.numerateur)} / {fraction4.denominateur}");

            Console.WriteLine($"fraction5 : {fraction5.ToString()}");
            fraction5.inverser();
            Console.WriteLine($"Les nouvelles valeurs de fraction5 sont : {fraction5.numerateur}/{fraction5.denominateur}");

            fraction1.EstSuperieurA(fraction2);
            Console.WriteLine($"{fraction1.EstSuperieurA(fraction2)}");

            fraction1.Plus(fraction2);
            Console.WriteLine(fraction1.Plus(fraction2));

            fraction1.Moins(fraction2);
            Console.WriteLine(fraction1.Moins(fraction2));

            fraction2.Multiplie(fraction4);
            Console.WriteLine(fraction2.Multiplie(fraction4));

            fraction3.Divise(fraction4);
            Console.WriteLine(fraction3.Divise(fraction4));

            
        }
    }
}
