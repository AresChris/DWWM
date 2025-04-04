namespace exercice_2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool beauTemps = true;
            bool bonEtat = true;
            bool reparation = true;
            bool balade = true;
            
            Console.Write("Que dit le temps ? beau ou mauvais ? ");
            String input = Console.ReadLine().ToLower();

                if(input.Contains("beau"))
                {
                    beauTemps = true;
                    balade = true;
                }
                else if(input.Contains("mauvais"))
                {
                    beauTemps= false;
                    balade = false;
                }
            
            Console.Write("La bicyclette est-elle en bon état ? Oui ou Non : ");
            input = Console.ReadLine();

                if(input.Contains("oui"))
                {
                    bonEtat = true;
                    reparation = false;
                    balade = true;
                }
                else if(input.Contains("non"))
                {
                    bonEtat= false;
                    reparation = true;
                    balade = false;
                }

            if(beauTemps && bonEtat)
            {
                balade = true;
                Console.WriteLine("Je pars faire une ballade à vélo");
            }
            else if(beauTemps && !reparation)
            {
                balade = true;
                Console.WriteLine("Je pars pour une balade à vélo !");
            }
            else if(beauTemps && reparation)
            {
                Console.WriteLine("Je dois amener mon vélo chez le réparateur..." +
                    "\nRéparateur : Les réparations vont prendre 2 bonnes heures." +
                    "\nMoi : Ce n'est pas grave, j'irai ceuillir des joncs, merci !");
            }
            else if(!beauTemps)
            {
                balade = false;
                Console.WriteLine("Je lirai un livre, mais ai-je le 1er tomme de Games of Thrones ? oui ou non");
                String livre = Console.ReadLine();
                    if(livre.Contains("oui"))
                    {
                        Console.WriteLine("Une bonne journée de lecture au coin du feu !");
                    }
                    else if(livre.Contains("non"))
                    {
                    Console.WriteLine("Je dois aller à la bibliothèque pour l'emprunter, à défaut, j'emprunterai un roman policier.");
                    }
            }
        }
    }
}


