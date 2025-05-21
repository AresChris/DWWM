namespace compagnieAerienne
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Reservation reservation1 = new Reservation("Air France", 127480, true, "Paris", "Bangkok", "Alfred", new DateTime(2025, 5, 21, 12, 0, 0));

            Console.WriteLine(reservation1.ToString());
            Console.WriteLine("------------------------");
            reservation1.reserver();
            Console.WriteLine(reservation1.ToString());
        }
    }
}
