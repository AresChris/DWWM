using System.ComponentModel;
using System.Security.Cryptography;

namespace exercice_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int scoreBot = 0, scoreJoueur = 0;
            int nbJoueur, nbBot;
            int diff;
            bool continuer = true;
            do
            {
                do
                {
                    Console.WriteLine("Jouez un chiffre (1, 2, 3)");
                    continuer = int.TryParse(Console.ReadLine(), out nbJoueur);
                } while (!continuer || nbJoueur >= 3);

                nbBot = random.Next(0, 3);

                diff = Math.Abs(nbBot - nbJoueur);

                switch (diff)
                {
                    case 2:
                        if (nbJoueur > nbBot)
                        {
                            scoreJoueur++;
                            Console.WriteLine($"Le joueur gagne 1 point : {scoreJoueur}");
                        }
                        else
                        {
                            scoreBot++;
                            Console.WriteLine($"L'ordinateur gagne 1 point : {scoreBot}");
                        }
                        break;
                    case 1:
                        {
                            if (nbJoueur < nbBot)
                            {
                                scoreJoueur++;
                                Console.WriteLine($"Le joueur gagne un point : {scoreJoueur}");
                            }
                            else
                            {
                                scoreBot++;
                                Console.WriteLine($"L'ordinateur gagne un point : {scoreBot}");
                            }
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine($"egalité aucun joueur ne marque un point : joueur : {scoreJoueur}  et bot machine :{scoreBot} ");
                            break;
                        }
                    default:
                        break;
                }
            } while (scoreBot < 10 && scoreJoueur < 10 && nbJoueur >= 0);

            if (nbJoueur < 0)
            {
                Console.WriteLine($"Le joueur à décidé d'arrêter de jouer.\nScore du joueur : {scoreJoueur}\nScore de l'ordinateur : {scoreBot}");
            }
                else if (scoreBot == 10)
            {
                Console.WriteLine($"L'ordinateur à gagné!\nScore du joueur : {scoreJoueur}\nScore de l'ordinateur : {scoreBot}");
            }
            else
            {
                Console.WriteLine($"Vous avez gagné!\nScore du joueur : {scoreJoueur}\nScore de l'ordinateur : {scoreBot}");
            }
        }
    }
}