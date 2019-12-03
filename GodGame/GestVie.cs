using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    class GestVie
    {
        private List<EtreVivant> m_listEtreVivant;

        /// <summary>
        /// Constructeur prenant en entrée une liste d'être vivant à animer
        /// </summary>
        /// <param name="p_listEtreVivant">La liste d'êtres vivants à animer</param>
        public GestVie(List<EtreVivant> p_listEtreVivant)
        {
            m_listEtreVivant = p_listEtreVivant;
        }

        private void Menu()
        {
         Console.WriteLine("Menu : ");
         Console.WriteLine("Choix numéro 1 : Tuer");
         Console.WriteLine("Choix numéro 2 : Reproduire");
         Console.WriteLine("Choix numéro 3 : Quitter le programme");
        }

        public static void ShowEtrevivant(List<EtreVivant> p_listEtreVivant)
        {
            int nombreMort = 0;
            int nombreEnVie = 0;
            foreach (EtreVivant ev in p_listEtreVivant)
            {           
                if(ev.Etat == true)
                {
                    nombreEnVie++;
                    Console.WriteLine(ev);
                }
                else  
                    nombreMort++;
                
                    
            }
            Console.WriteLine($"Nombre de mort(s) : {nombreMort}");
            Console.WriteLine($"Nombre en vie : {nombreEnVie}");
        }

        public void Start()
        {
            int Choix = 0;
            int ChoixAleatoire;
            int nombreEtreVivant = 1;
            Random aleatoire = new Random();
            Menu();
            do
            {
                
                Choix = int.Parse(Console.ReadLine());
                switch (Choix)
                {
                    case 1: //Tuer
                        for (int i = 0; i < 1; i++) // On ne tue que 1 etre vivant pour l'instant 
                        {
                            //Génération d'un nombre aléatoire entre 1 et le nombre d'etre vivant 
                            nombreEtreVivant = m_listEtreVivant.Count;
                            ChoixAleatoire = aleatoire.Next(1, nombreEtreVivant);
                            EtreVivant.Tuer(m_listEtreVivant[ChoixAleatoire]);
                            Console.WriteLine($"{m_listEtreVivant[ChoixAleatoire].Nom} a ete tue. ");            
                            ShowEtrevivant(m_listEtreVivant);
                        }
                        break;

                    case 2: //Reproduire
                        for (int i = 0; i < 3; i++) // On essaye 3 reproduction
                        {
                            //Génération d'un nombre aléatoire
                            nombreEtreVivant = m_listEtreVivant.Count;
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
