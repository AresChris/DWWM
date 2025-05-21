using LePoint;
namespace LePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1.0f, 2.0f);
            Point point2 = new Point(3.0f, 4.0f);

            Console.WriteLine($"Point1 : {point1.ToString()} \npoint2 :  {point2.ToString()}");
            point1.Permuter(point2);
            Console.WriteLine($"Point1 : {point1.ToString()} \npoint2 :  {point2.ToString()}");
            point1.Deplacer(5.0f, 6.0f);
            Console.WriteLine($"Point1 : {point1.ToString()}");
            point1.SymetrieOrigine();
            Console.WriteLine($"Point1 : {point1.ToString()}");
            point1.SymetrieAbscisse();
            Console.WriteLine($"Point1 : {point1.ToString()}");
            point1.SymetrieOrdonnee();
            Console.WriteLine($"Point2 : {point1.ToString()}");
        }
    }
}
