namespace exercice_1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            int reponse;

            Console.WriteLine("Trier 2 ou 3 nombres ?");
            String input = Console.ReadLine();

            if (int.TryParse(input, out reponse))
            {
                if (reponse == 2)
                {
                    Console.WriteLine("Saisir une valeur de a :");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Saisir une valeur de b :");
                    b = double.Parse(Console.ReadLine());

                    if (a < b)
                    {
                        Console.WriteLine($"a: {a} \nb: {b}");
                    }
                    else
                    {
                        Console.WriteLine($"b: {b}\na: {a}");
                    }
                }
                else if (reponse == 3)
                {
                    Console.WriteLine("Saisir une valeur de a :");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Saisir une valeur de b :");
                    b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Saisir une valeur de c :");
                    c = double.Parse(Console.ReadLine());


                    if (a<b && b<c)
                    {
                        Console.WriteLine($"a: {a} \nb: {b}\nac: {c}");
                    }
                    else if(a<c && c<b)
                    {
                        Console.WriteLine($"b: {a}\na: {c}\nb: {b}");
                    }
                    else if(b<a && a<c)
                    {
                        Console.WriteLine($"b: {b}\na: {a}\nc: {c}");
                    }
                    else if (b<c && c<a)
                    {
                        Console.WriteLine($"b: {b}\nc: {c}\na: {a}");
                    }
                    else if (c<b && b<a)
                    {
                        Console.WriteLine($"c: {c} \nb: {b}\na: {a}");
                    }
                    else if (c<a && a<b)
                    {
                        Console.WriteLine($"c: {c} \na: {a}\nb: {b}");
                    }
                    else
                    {
                        Console.WriteLine("il manque un cas, merci de contacter le dev qui à baclé le travail !");
                    }
                }
                else
                {
                    Console.WriteLine("Erreur de saisie, inscrivez un entier.");
                }
            }
        }
    }
}