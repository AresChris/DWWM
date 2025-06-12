using Microsoft.Win32.SafeHandles;
using System.Collections.Immutable;
using System.Diagnostics;
using Manche421;
using System;
using Jeu421;
using Aleatoire;

namespace Jeu421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manche manche = new Manche();

            manche.Lance();
            Console.WriteLine(manche.ToString());
            manche.Lance();
            Console.WriteLine(manche.ToString());
            manche.Lance();
            Console.WriteLine(manche.ToString());
        }
    }
}

// isWon()
/*Console.WriteLine($"Gagné !\nVous avez {points} points.");
/* Console.WriteLine($"\nVoulez-vous rejouer ?");
  string answer = Console.ReadLine().ToLower();
  if (answer == "oui")
  {
  isWon = false;
  launches = 0;
  for (int i = 0; i < nbOfDices; i++)
  {
  tableau[i] = random.Next(1, 7);
  Console.WriteLine($"Dé n°{i + 1} : {tableau[i]}");
  }
  } */

/* LaunchDices
 * /*
        public void LaunchDices()
        {
            for (int i = 0; i < nbOfDices; i++)
            {
                tableau[i] = random.Next(1, 7);
            }
            Trier();
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine($"Dé n°{i + 1} : {tableau[i]}");
            }
            do
            {
                if (!Won())
                {
                    Console.WriteLine("Quels dé(s) voulez-vous relancer ? Ex 1 2 ou 1");
                    string answer = Console.ReadLine();
                    string[] tableauSplitted = answer.Split(' ');
                    int[] dicesToLaunch = tableauSplitted.Select(int.Parse).ToArray();
                    
                    if (dicesToLaunch.Contains(1) && dicesToLaunch.Contains(2) && launches < nbMaxLaunch)
                    {
                        tableau[0] = random.Next(1, 7);
                        tableau[1] = random.Next(1, 7);
                        launches += 1;
                    }
                    else if (dicesToLaunch.Contains(1) && dicesToLaunch.Contains(3) && launches < nbMaxLaunch)
                    {
                        tableau[0] = random.Next(1, 7);
                        tableau[2] = random.Next(1, 7);
                        launches += 1;
                    }
                    else if (dicesToLaunch.Contains(2) && dicesToLaunch.Contains(3) && launches < nbMaxLaunch)
                    {
                        tableau[1] = random.Next(1, 7);
                        tableau[2] = random.Next(1, 7);
                        launches += 1;
                    }
                    else if (dicesToLaunch.Contains(1) && launches < nbMaxLaunch)
                    {
                        tableau[0] = random.Next(1, 7);
                        launches += 1;
                    }
                    else if (dicesToLaunch.Contains(2) && launches < nbMaxLaunch)
                    {
                        tableau[1] = random.Next(1, 7);
                        launches += 1;
                    }
                    else if (dicesToLaunch.Contains(3) && launches < nbMaxLaunch)
                    {
                        tableau[2] = random.Next(1, 7);
                        launches += 1;
                    }
                    else if (dicesToLaunch.Contains(1) && dicesToLaunch.Contains(2) && dicesToLaunch.Contains(3) && launches < nbMaxLaunch)
                    {
                        tableau[1] = random.Next(1, 7);
                        tableau[2] = random.Next(1, 7);
                        tableau[3] = random.Next(1, 7);
                        launches += 1;
                    }
                    Trier();
                    for (int i = 0; i < tableau.Length; i++)
                    {
                        Console.WriteLine($"Dé n°{i + 1} : {tableau[i]}");
                    }
                    if (tableau.Contains(4) && tableau.Contains(2) && tableau.Contains(1))
                    {
                        points += 30;
                        Won();
                    }
                    if (launches >= nbMaxLaunch && !Won())
                    {
                        points -= 10;
                        Console.WriteLine($"Perdu, vous avez {points} points.");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"\nVoulez-vous rejouer ?");
                        answer = Console.ReadLine().ToLower();
                        if(answer == "oui")
                        {
                            launches = 0;
                            for (int i = 0; i < nbOfDices; i++)
                            {
                                tableau[i] = random.Next(1, 7);
                            }
                        }
                        else
                        {
                            break;
                        }
                        for (int i = 0; i < tableau.Length; i++)
                        {
                            Console.WriteLine($"Dé n°{i + 1} : {tableau[i]}");
                        }
                    }
                    if (points <= 0)
                    {
                        Console.WriteLine($"Perdu, vous avez {points} points.");
                        break;
                    }
                }
            } while (!Won());
        }
        */