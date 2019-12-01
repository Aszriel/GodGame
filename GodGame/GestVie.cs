using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    class GestVie<T>
    {
        private List<T> m_listEtreVivant;

        /// <summary>
        /// Constructeur prenant en entrée une liste d'être vivant à animer
        /// </summary>
        /// <param name="p_listEtreVivant">La liste d'êtres vivants à animer</param>
        public GestVie(List<T> p_listEtreVivant)
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

        public void ShowEtrevivant()
        {
            foreach (T ev in m_listEtreVivant)
            {
                Console.WriteLine(ev);
            }
        }

        public void Start()
        {
            //Création d'un menu pour l'utilisateur
            //Choix 1 Tuer
            //Choix 2 Reproduire 
            //Choix 3 Quitter le programme
            int Choix = 0;
            int ChoixAleatoire;
            int nombreEtreVivant = 1;
            Random aleatoire = new Random();
            do
            {
                Menu();
                Choix = int.Parse(Console.ReadLine());
                switch (Choix)
                {
                    case 1: //Tuer
                        for (int i = 0; i < 1; i++) // On ne tue que 1 etre vivant pour l'instant 
                        {
                            //Génération d'un nombre aléatoire entre 1 et le nombre d'etre vivant 
                            nombreEtreVivant = m_listEtreVivant.Count;
                            ChoixAleatoire = aleatoire.Next(1, nombreEtreVivant);
                            Console.WriteLine(m_listEtreVivant[ChoixAleatoire]);
                            //appeler gestion vie pour tuer l'etre vivant 

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
