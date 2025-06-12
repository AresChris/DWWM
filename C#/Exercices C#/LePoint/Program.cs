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
            Point point4 = new Point(0, 0);


            point3.SymetrieAbscisse(point4);
            Console.WriteLine($"Point 3 : {point3.ToString()}\nPoint 4 : {point4.ToString()}");

            point3.SymetrieOrdonnee(point4);
            Console.WriteLine($"Point 3 : {point3.ToString()}\nPoint 4 : {point4.ToString()}");

            point3.SymetrieOrigine(point4);
            Console.WriteLine($"Point 3 : {point3.ToString()}\nPoint 4 : {point4.ToString()}");
        }
    }
}
