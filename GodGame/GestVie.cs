using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    class GestVie
    {
        private List<EtreVivantReproduction> m_listEtreVivantReproduction;
        private List<EtreVivantDivision> m_listEtreVivantDivision;
        private Geochelone m_george; // Sert uniquement à faire un get_type pour avoir son type lors de la reproduction(voir plus bas)

        /// <summary>
        /// Constructeur prenant en entrée deux listes d'êtres vivants à animer
        /// </summary>
        /// <param name="p_listEtreVivantReproduction">La liste d'êtres vivants ,qui se reproduisent, à animer</param>
        /// <param name="p_listEtreVivantDivision">La liste d'êtres vivants, qui se divisent, à animer</param>
        public GestVie(List<EtreVivantReproduction> p_listEtreVivantReproduction, List<EtreVivantDivision> p_listEtreVivantDivision)
        {
            m_listEtreVivantReproduction = p_listEtreVivantReproduction;
            m_listEtreVivantDivision = p_listEtreVivantDivision;
            m_george = new Geochelone("george", 0, "masculin");
        }

        private void Menu()
        {
         Console.WriteLine("Menu : ");
         Console.WriteLine("Choix numéro 1 : Tuer");
         Console.WriteLine("Choix numéro 2 : Reproduire");
         Console.WriteLine("Choix numéro 3 : Quitter le programme");
        }


        /// <summary>
        /// Permet d'afficher l'ensemble des êtres vivants
        /// </summary>
        /// <param name="p_listEtreVivantReproduction">La liste des etres vivants par reproduction</param>
        /// <param name="p_listEtreVivantDivision">La liste des êtres vivants par division</param>
        public static void ShowEtrevivant(List<EtreVivantReproduction> p_listEtreVivantReproduction, List<EtreVivantDivision> p_listEtreVivantDivision)
        {
            int nombreMort = 0;
            int nombreEnVie = 0;
            foreach (EtreVivant ev in p_listEtreVivantReproduction)
            {           
                if(ev.Etat == true) // Si l'être vivant est mort
                {
                    nombreEnVie++;
                    Console.WriteLine(ev);
                }
                else  
                    nombreMort++;        
            }

            foreach (EtreVivant ev in p_listEtreVivantDivision)
            {
                if (ev.Etat == true)
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

        /// <summary>
        /// Fonction principale permettant de lancer le jeu
        /// </summary>
        public void Start()
        {
            int Choix = 0;
            int ChoixAleatoire;
            int nombreEtreVivant = 0;
            int nombreTuerReproduire = 0;
            int nombreTuerDivision = 0;
            int nombreTuer = 0;
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
                            nombreEtreVivant = m_listEtreVivantReproduction.Count + m_listEtreVivantDivision.Count;
                            nombreTuer= nombreTuerDivision+ nombreTuerReproduire; 
                            //On génére un nouveau nombre aléatoire si etat = false et seulement si tous les etre ne sont pas déjà mort
                            if (nombreTuer!=nombreEtreVivant)
                            {
                                int listRandom = aleatoire.Next(0, 2);
                                if(listRandom==0 && nombreTuerReproduire != m_listEtreVivantReproduction.Count)
                                {
                                    nombreTuerReproduire++;
                                    do
                                    {
                                        ChoixAleatoire = aleatoire.Next(0, m_listEtreVivantReproduction.Count);
                                    }
                                    while (m_listEtreVivantReproduction[ChoixAleatoire].Etat == false); // On boucle tant que l'être vivant choisit est déjà mort
                                    EtreVivant.Tuer(m_listEtreVivantReproduction[ChoixAleatoire]);
                                    Console.WriteLine($"{m_listEtreVivantReproduction[ChoixAleatoire].Nom} a ete tue. ");
                                    ShowEtrevivant(m_listEtreVivantReproduction, m_listEtreVivantDivision);
                                }
                                else if(listRandom == 1 && nombreTuerDivision != m_listEtreVivantDivision.Count)
                                {
                                    nombreTuerDivision++;
                                    do
                                    {
                                        ChoixAleatoire = aleatoire.Next(0, m_listEtreVivantDivision.Count);
                                    }
                                    while (m_listEtreVivantDivision[ChoixAleatoire].Etat == false);
                                    EtreVivant.Tuer(m_listEtreVivantDivision[ChoixAleatoire]);
                                    Console.WriteLine($"{m_listEtreVivantDivision[ChoixAleatoire].Nom} a ete tue. ");
                                    ShowEtrevivant(m_listEtreVivantReproduction, m_listEtreVivantDivision);
                                }else if(nombreTuerDivision >= m_listEtreVivantDivision.Count)
                                    Console.WriteLine("Impossible de tuer un etre vivant qui se divise, il ne reste plus personne!");

                            }
                            else if(nombreTuer >= nombreEtreVivant)
                            Console.WriteLine("Impossible de tuer un etre vivant, il ne reste plus personne!");
                        }
                        break;

                    case 2: //Reproduire
                        int nombreEtreVivantReproduction = m_listEtreVivantReproduction.Count;
                        int nombreEtreVivantDivision = m_listEtreVivantDivision.Count;
                        for(int i = 0; i < 3; i++) // On essaye 3 reproduction
                        {
                            //Génération d'un nombre aléatoire
                            int choixAleatoireReproduction1 = aleatoire.Next(1, nombreEtreVivantReproduction);
                            int choixAleatoireReproduction2 = aleatoire.Next(1, nombreEtreVivantReproduction);
                            int choixAleatoireDivision = aleatoire.Next(1, nombreEtreVivantDivision);
                            if (m_listEtreVivantReproduction[choixAleatoireReproduction1].GetType() == m_george.GetType() ||
                                m_listEtreVivantReproduction[choixAleatoireReproduction2].GetType() == m_george.GetType())
                                Console.WriteLine("George ne peut pas se reproduire");
                            
                                
                           else if(m_listEtreVivantReproduction[choixAleatoireReproduction1].GetType() == m_listEtreVivantReproduction[choixAleatoireReproduction2].GetType())
                            {
                               EtreVivantReproduction evr = m_listEtreVivantReproduction[choixAleatoireReproduction1].Reproduction(m_listEtreVivantReproduction[choixAleatoireReproduction2]);
                                Console.WriteLine(evr);
                               m_listEtreVivantReproduction.Add(evr);
                            }
                           else
                            {
                                Console.WriteLine($"La reproduction entre {m_listEtreVivantReproduction[choixAleatoireReproduction1].Nom} , et, {m_listEtreVivantReproduction[choixAleatoireReproduction2].Nom}, a échoué");
                            }

                            EtreVivantDivision evd = m_listEtreVivantDivision[choixAleatoireDivision].Division();
                            m_listEtreVivantDivision.Add(evd);
                            Console.WriteLine("");
                        }
                        ShowEtrevivant(m_listEtreVivantReproduction, m_listEtreVivantDivision);
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
