using DAL.WoWW.Entities;
using DAL.WoWW.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWW.Views
{
    public static class TeamView
    {
        static int playerId;
        public static void CreationTeam()
        {
            Team newTeam = new Team();
            Console.WriteLine("Création de team ");
            Console.Write("Nom : ");
            newTeam.Name = Console.ReadLine();

            TeamService team = new TeamService();
            team.Create(newTeam);
            Console.WriteLine("Equipe créée");
        }

        public static void MenuTeam(int PlayerId)
        {
            playerId = PlayerId;
            Console.WriteLine("Faites votre choix");
            Console.WriteLine("1 - Créer une team");
            Console.WriteLine("2 - Afficher la liste");
            int choix = int.Parse(Console.ReadLine());

            switch(choix)
            {
                case 1: CreationTeam(); break;
                case 2: ListeTeam(); break;
                default:
                    {
                        Console.WriteLine("Choix invalide");
                        MenuTeam(playerId);
                        break;
                    }
            }
        }

        public static void ListeTeam()
        {
            TeamService teamService = new TeamService();
            Console.WriteLine("Liste des équipes");
            Console.WriteLine("Id ------ Nom ------- Score");
            foreach (Team team in teamService.GetAll())
            {
                Console.WriteLine(team.Id + " -- -- " +team.Name + " -- "+team.Score);
            }

            Console.WriteLine();
            Console.WriteLine("Afficher la team  (id): ");

            int choix = int.Parse(Console.ReadLine());
            DetailTeam(choix);
        }

        public static void DetailTeam(int idTeam)
        {
            TeamService service = new TeamService();
            Team selectedTeam = service.GetById(idTeam);
            Console.WriteLine("Id : "+ selectedTeam.Id);
            Console.WriteLine("Nom : "+ selectedTeam.Name);
            Console.WriteLine("Score : "+ selectedTeam.Score);

            Console.WriteLine("");
            Console.WriteLine("S'y inscire ? 1 - Oui, 2 - Non");
            int choix = int.Parse(Console.ReadLine());

            if(choix == 1)
            {
                PlayerService _playerService = new PlayerService();
                _playerService.SetTeamToPlayer(playerId, idTeam);
                Console.WriteLine("Merci pour votre inscription");
            }
            if(choix == 2)
            {
                ListeTeam();
            }

        }
    }
}
