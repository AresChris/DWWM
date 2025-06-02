using LaFraction;
namespace LaFraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(12, 7);
            Fraction f2 = new Fraction(9, 1);
            Fraction f3 = new Fraction();
           
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            Console.WriteLine(f3.ToString());

            Console.WriteLine("--------------------------"); // ++
            Fraction f4 = new Fraction(4, 7);
            Console.Write($"Oppose {f4.ToString()} = ");
            f4.Oppose();
            Console.WriteLine($"{f4.ToString()}"); // -4/7

            Console.WriteLine("--------------------------");
            Fraction f5 = new Fraction(4, 7);
            Console.WriteLine($"Inverser {f5.ToString()} = ");
            f5.Inverser();
            Console.WriteLine($"{f5.ToString()}"); // 7/4 
            f5.Inverser();
            Console.WriteLine($"{f5.ToString()}"); // 4/7
            
            Console.WriteLine("--------------------------");
            Fraction f6 = new Fraction(11, 7);
            Fraction f7 = new Fraction(5, 4);
            Console.Write($"{f6.ToString()} > {f7.ToString()} = ");
            bool estSuperieur = f6.EstSuperieurA(f7);
            Console.WriteLine(estSuperieur); // true

            
            Console.WriteLine("--------------------------");
            Fraction f8 = new Fraction(11, 7);
            Fraction f9 = new Fraction(22, 14);
            Console.Write($"{f8.ToString()} == {f9.ToString()} = ");
            bool estEgal = f8.EgalA(f9);
            Console.WriteLine(estEgal); // true 

            Console.WriteLine("--------------------------");
            Fraction f10 = new Fraction(3, 5);
            Fraction f11 = new Fraction(4, 7);
            Console.Write($"{f10.ToString()} * {f11.ToString()} = ");
            Fraction f = f10.Multiplie(f11);
            Console.WriteLine(f.ToString()); // 12/35

            Console.WriteLine("--------------------------");
            Fraction f12 = new Fraction(1, 2);
            Fraction f13 = new Fraction(3, 5);
            Console.Write($"{f12.ToString()} + {f13.ToString()} = ");
            Fraction ff = f12.Plus(f13);
            Console.WriteLine(ff.ToString()); // 10/11

            Console.WriteLine("--------------------------");
            Fraction f14 = new Fraction(4, 5);
            Fraction f15 = new Fraction(1, 5);
            Console.Write($"{f14.ToString()} - {f15.ToString()} = ");
            Fraction fff = f14.Moins(f15);
            Console.WriteLine(fff.ToString()); // 3/5 

            Console.WriteLine("--------------------------");
            Fraction f16 = new Fraction(4, 3);
            Fraction f17 = new Fraction(2, 5);
            Console.Write($"{f16.ToString()} / {f17.ToString()} = ");
            Fraction ffff = f16.Divise(f17);
            Console.WriteLine(ffff.ToString()); // 4/3
        }
    }
}
