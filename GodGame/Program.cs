using System;
using System.Collections.Generic;

namespace GodGame
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Création des etres vivants
            //Création des êtres vivants initiaux
            Corail martinCorail = new Corail("Martin", 0, "male");
            Dauphin titiDauphin = new Dauphin("Titi", 0, "male");
            Dauphin cornelliaDauphin = new Dauphin("Cornellia", 0, "femelle");
            Corail pouletteCorail = new Corail("Poulette", 0, "femelle");
            Geochelone georgesGeochelone = new Geochelone("Georges", 0, "male");
            #endregion

            #region Ajouts dans la liste
            //Ajouts dans une liste pour le passer au constructeur de GestVie
            List<EtreVivant> listEtreVivant = new List<EtreVivant>();
            listEtreVivant.Add(martinCorail);
            listEtreVivant.Add(titiDauphin);
            listEtreVivant.Add(cornelliaDauphin);
            listEtreVivant.Add(pouletteCorail);
            listEtreVivant.Add(georgesGeochelone);
            #endregion

            //Affichage de tous les etres vivants présent au début du programme
            foreach (EtreVivant etreVivant in listEtreVivant)
            {
                Console.WriteLine(etreVivant);
            }

            //Création d'un menu pour l'utilisateur
            //Choix 1 Tuer
            //Choix 2 Reproduire 
            //Choix 3 Quitter le programme
            int Choix = 9;
            int ChoixAleatoire;
            int nombreEtreVivant = 1;
            Random aleatoire = new Random();
            do
            {
                Console.WriteLine("Menu : ");
                Console.WriteLine("Choix numéro 1 : Tuer");
                Console.WriteLine("Choix numéro 2 : Reproduire");
                Console.WriteLine("Choix numéro 3 : Quitter le programme");
                Choix = int.Parse(Console.ReadLine());
                switch (Choix)
                {
                    case 1: //Tuer
                        for (int i = 0; i < 1; i++) // On ne tue que 1 etre vivant pour l'instant 
                        {
                            //Génération d'un nombre aléatoire entre 1 et le nombre d'etre vivant 
                            nombreEtreVivant = listEtreVivant.Count;
                            ChoixAleatoire = aleatoire.Next(1, nombreEtreVivant);
                            Console.WriteLine(listEtreVivant[ChoixAleatoire]);
                            //appeler gestion vie pour tuer l'etre vivant 

                        }
                        break;
                    case 2: //Reproduire
                        for (int i = 0; i < 3; i++) // On essaye 3 reproduction
                        {
                            //Génération d'un nombre aléatoire
                            nombreEtreVivant = listEtreVivant.Count;
                            ChoixAleatoire = aleatoire.Next(1, nombreEtreVivant);
                        }

                        break;
                    case 3:
                        Console.WriteLine("Fin Programme, Merci");
                        break;
                    default:
                        Console.WriteLine("Mauvaise Saisie veulliez réitérer");
                        Console.WriteLine();
                        break;
                }

            } while (Choix != 3);
        }
    }
}
