namespace exercice_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, interest = 0, years = 0, simpleInterest = 0, compoundInterest = 0, totalSimple = 0, totalCompound = 0;
            String input = "";
            Console.WriteLine("Saisissez la somme à placer : ");
            input = Console.ReadLine();
            if (double.TryParse(input, out sum))
            {
                Console.WriteLine("Pendant combien d'années ?");
                input = Console.ReadLine();
                if (double.TryParse(input, out years))
                {
                    Console.WriteLine("Quel est le taux d'interêt ?");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out interest))
                    {
                        interest = interest / 100;
                        simpleInterest = sum * interest * years;
                        compoundInterest = sum * (Math.Pow((1 + interest), years)) - sum;
                        totalCompound = compoundInterest + sum;
                        totalSimple = simpleInterest + sum;
                    }
                }
            }
            Console.WriteLine($"\n\n\nInvestissement de {sum} Sur 1 an\nInterêts simples : {totalSimple:F2}\nSur {years} an(s)\nInterêts composés : {totalCompound:F2}");
        }
    }
}
