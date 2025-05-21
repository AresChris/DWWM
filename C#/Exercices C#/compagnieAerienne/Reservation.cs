using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compagnieAerienne
{
    internal class Reservation
    {
        private string nomCompanie;
        private int codeReservation;
        private bool estOuvert;
        private string aeroportDeDepart;
        private string aeroportDArrivee;
        private string nomClient;
        private DateTime dateHeureDeDepart;

        public Reservation() : this("Compagnie Aérienne", 0, true, "Aeroport de départ", "Aeroport d'arrivée", "Client", new DateTime(2025, 5, 21, 12, 0, 0))
        {
        }
        public Reservation(string _nomCompanie, int _codeReservation, bool _estOuvert, string _aeroportDeDepart, string _aeroportDArrivee, string _nomClient, DateTime _dateHeureDeDepart)
        {
            nomCompanie = _nomCompanie;
            codeReservation = _codeReservation;
            estOuvert = _estOuvert;
            aeroportDeDepart = _aeroportDeDepart;
            aeroportDArrivee = _aeroportDArrivee;
            nomClient = _nomClient;
            dateHeureDeDepart = _dateHeureDeDepart;
        }
        public Reservation(Reservation reservationACopier)
        {
            nomCompanie = reservationACopier.nomCompanie;
            codeReservation = reservationACopier.codeReservation;
            estOuvert = reservationACopier.estOuvert;
            aeroportDeDepart = reservationACopier.aeroportDeDepart;
            aeroportDArrivee = reservationACopier.aeroportDArrivee;
            nomClient = reservationACopier.nomClient;
            dateHeureDeDepart = reservationACopier.dateHeureDeDepart;
        }
        public override string ToString()
        {
            return base.ToString() + "\nNom de la compagnie: " + nomCompanie +
                "\nCode de réservation: " + codeReservation +
                "\nEst ouvert: " + estOuvert +
                "\nAéroport de départ: " + aeroportDeDepart +
                "\nAéroport d'arrivée: " + aeroportDArrivee +
                "\nNom du client: " + nomClient +
                "\nDate et heure de départ: " + dateHeureDeDepart.ToString("dd/MM/yyyy HH:mm");
        }
        public bool fermerReservation()
        {
            if (estOuvert)
            {
                estOuvert = false;
                return true;
            }
            return false;
        }
        public bool ouvrirReservation()
        {
            if (!estOuvert)
            {
                estOuvert = true;
                return true;
            }
            return false;
        }
        public bool reserver()
        {
            if (estOuvert)
            {
                estOuvert = false;
                return true;
            }
            return false;
        }
        public bool annulerReservation()
        {
            if (!estOuvert)
            {
                estOuvert = true;
                return true;
            }
            return false;
        }
        public bool confirmerReservation()
        {
            if (!estOuvert)
            {
                estOuvert = false;
                return true;
            }
            return false;
        }
    }
}
