﻿using DAL.WoWW.Entities;
using DAL.WoWW.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWW.Views
{
    internal class PlayerView
    {
        PlayerService _service { get; set; }

        public PlayerView()
        {
            _service = new PlayerService();
        }

        public Player Connexion()
        {
            Console.WriteLine("Entrez votre email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Entrez votre mot de passe : ");
            string password = Console.ReadLine();

            Player currentPlayer = _service.Login(email, password);

            if(currentPlayer is null)
            {
                Console.WriteLine("Utilisateur inexistant, veuillez rééssayer");
                Connexion();
            }

            Console.WriteLine("Bienvenue "+ currentPlayer.Name);
            return currentPlayer;
        }

        public void InscriptionJoueur()
        {
            Player newPlayer = new Player();
            Console.WriteLine("Votre nom : ");
            newPlayer.Name = Console.ReadLine();
            Console.WriteLine("Votre email : ");
            newPlayer.Email = Console.ReadLine();
            Console.WriteLine("Votre password : ");
            newPlayer.Password = Console.ReadLine();

            if (_service.CreatePlayer(newPlayer))
            {
                Console.WriteLine("Enregistrement Ok");
            }
            else { Console.WriteLine("Contactez l'admin"); }


        }
    }
}
