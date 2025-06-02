using LePoint;
namespace LePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(3, -5);
            Point point2 = new Point(-1, -2);
            Point point3 = new Point(1, 2);
            Point point4 = new Point(-1, 2);

            

            Console.WriteLine(point1.ToString());
            point1.SymetrieOrigine();
            Console.WriteLine(point1.ToString());
            Console.WriteLine("----------------");

            Console.WriteLine(point2.ToString());
            point2.SymetrieOrigine();
            Console.WriteLine(point2.ToString());
            Console.WriteLine("----------------");

            Console.WriteLine(point3.ToString());
            point3.SymetrieOrigine();
            Console.WriteLine(point3.ToString());
            Console.WriteLine("----------------");

            Console.WriteLine(point4.ToString());
            point4.SymetrieOrigine();
            Console.WriteLine(point4.ToString());
            Console.WriteLine("----------------");

            Console.WriteLine($"{point1.ToString()}");
            point1.Permuter();
            Console.WriteLine($"{point1.ToString()}");

            
        }
    }
}
