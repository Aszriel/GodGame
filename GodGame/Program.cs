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
            Bacterie michelBacterie = new Bacterie("Michel", 0, "none");
            #endregion

            #region Ajouts dans la liste
            //Ajouts dans une liste pour le passer au constructeur de GestVie
            List<EtreVivantReproduction> listEtreVivantReproduction = new List<EtreVivantReproduction>();
            listEtreVivantReproduction.Add(martinCorail);
            listEtreVivantReproduction.Add(titiDauphin);
            listEtreVivantReproduction.Add(cornelliaDauphin);
            listEtreVivantReproduction.Add(pouletteCorail);
            listEtreVivantReproduction.Add(georgesGeochelone);

            List<EtreVivantDivision> listEtreVivantDivision = new List<EtreVivantDivision>();
            listEtreVivantDivision.Add(michelBacterie);
            #endregion

            GestVie gestionVie = new GestVie(listEtreVivantReproduction, listEtreVivantDivision);

            //Affichage de tous les etres vivants présent au début du programme
            GestVie.ShowEtrevivant(listEtreVivantReproduction, listEtreVivantDivision);
            
            //Lancement du programme
            gestionVie.Start();


        }
    }
}
