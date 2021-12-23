using DAL.WoWW.Entities;
using DAL.WoWW.Repositories;
using System;
using WoWW.Views;

namespace WoWW
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerView playerView = new PlayerView();

            //playerView.InscriptionJoueur();

            Player ConnectedPlayer = playerView.Connexion();

            TeamView.MenuTeam(ConnectedPlayer.Id);

            //TeamService teamService = new TeamService();

            //teamService.Create(TeamView.CreationTeam());


            //foreach (Team team in teamService.GetAll())
            //{
            //    Console.WriteLine(team.Name);
            //}

            //Team t1 = new Team();
            //t1.Name = "Wad21";

            //Team t2 = new Team();
            //t1.Name = "Web10";

            //if (teamDAO.Create(t1)) Console.WriteLine("Team 1 créée");
            //else Console.WriteLine("Un problème est survenu");

            //if (teamDAO.Create(t2)) Console.WriteLine("Team 2 créée");
            //else Console.WriteLine("Un problème est survenu"); 

            //foreach (Team t in teamDAO.GetAll())
            //{
            //    Console.WriteLine("ID : {0} -- Nom : {1}", t.Id, t.Name);
            //}

        }
    }
}
