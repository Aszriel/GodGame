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

            GestVie<EtreVivant> gestionVie = new GestVie<EtreVivant>(listEtreVivant);

            //Affichage de tous les etres vivants présent au début du programme
            GestVie<EtreVivant>.ShowEtrevivant(listEtreVivant);
            
            //Lancement du programme
            gestionVie.Start();


        }
    }
}
