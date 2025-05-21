using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicules
{
    internal class Vehicules
    {
        private string nom;
        private string couleur;
        private string seDeplace;
        public Vehicules(string nom, string couleur, string seDeplace) 
        {
            this.nom = nom;
            this.couleur = couleur;
            this.seDeplace = seDeplace;
        }
        class Terrestre
        {
            class Voiture()
            {

            }
            class Moto()
            {

            }
            class Metro()
            {

            }
            class Train()
            {

            }
            class Cheval()
            {

            }
        }
        class Maritime
        {
            class Voilier()
            {

            }
            class Ferry()
            {

            }
            class  SousMarin()
            {
                
            }
        }
        class Aerien
        {
            class Avion()
            {

            }
            class Helicoptere()
            {

            }
            class Deltaplane()
            {

            }
        }
    }
   

}
