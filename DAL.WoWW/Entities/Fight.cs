using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.WoWW.Entities
{
    public class Fight
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public int TournamentId { get; set; }
        public int WinnerId { get; set; }
        public int LooserId { get; set; }


        //Pour récupérer le détail d'un combat
        /*
         1. Remplir cet objet avec les info de la table Fight
         2. Récupérer les info du winner et du looser dans la table Player
         2'. Récupérer les info du tournoi de la table Tournament
         3. Jouer avec les 3 objets pour créer ton affichage
         */
    }
}
