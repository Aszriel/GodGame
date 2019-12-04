using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    class GestVie
    {
        private List<EtreVivantReproduction> m_listEtreVivantReproduction;
        private List<EtreVivantDivision> m_listEtreVivantDivision;

        /// <summary>
        /// Constructeur prenant en entrée une liste d'être vivant à animer
        /// </summary>
        /// <param name="p_listEtreVivantReproduction">La liste d'êtres vivants à animer</param>
        public GestVie(List<EtreVivantReproduction> p_listEtreVivantReproduction, List<EtreVivantDivision> p_listEtreVivantDivision)
        {
            m_listEtreVivantReproduction = p_listEtreVivantReproduction;
            m_listEtreVivantDivision = p_listEtreVivantDivision;
        }

        private void Menu()
        {
         Console.WriteLine("Menu : ");
         Console.WriteLine("Choix numéro 1 : Tuer");
         Console.WriteLine("Choix numéro 2 : Reproduire");
         Console.WriteLine("Choix numéro 3 : Quitter le programme");
        }


        public static void ShowEtrevivant(List<EtreVivantReproduction> p_listEtreVivantReproduction, List<EtreVivantDivision> p_listEtreVivantDivision)
        {
            int nombreMort = 0;
            int nombreEnVie = 0;
            foreach (EtreVivant ev in p_listEtreVivantReproduction)
            {           
                if(ev.Etat == true)
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

        public void Start()
        {
            int Choix = 0;
            int ChoixAleatoire;
            int nombreEtreVivant = 0;
            Random aleatoire = new Random();
            Menu();
            do
            {
                Choix = int.Parse(Console.ReadLine());
                switch (Choix)
                {

                    case 1: //Tuer
                        int nombreTuerReproduire = 0; //compte le nombre d'etre vivant qui se reproduit mort 
                        int nombreTuerDivision = 0; //compte le nombre d'etre vivant qui se divise mort
                        int nombreTuer = 0; //compte le nombre de mort total
                        for (int i = 0; i < 1; i++) // On ne tue que 1 etre vivant pour l'instant 
                        {
                            //Génération d'un nombre aléatoire entre 1 et le nombre d'etre vivant 
                            nombreEtreVivant = m_listEtreVivantReproduction.Count + m_listEtreVivantDivision.Count;
                            nombreTuer= nombreTuerDivision+ nombreTuerReproduire; 
                            //On génére un nouveau nombre aléatoire si etat = false et seulement si tous les etre ne sont pas déjà mort
                            if (nombreTuer!=nombreEtreVivant)
                            {
                                int listRandom = aleatoire.Next(0, 2); //on crée un nombre aléatoire entre 0 et 1
                                if(listRandom==0 && nombreTuerReproduire != m_listEtreVivantReproduction.Count) // si 0 on tue un etre vivant qui se reproduit et uniquement si il reste des etre vivant a tuer
                                {
                                    nombreTuerReproduire++; 
                                    do
                                    {
                                        ChoixAleatoire = aleatoire.Next(0, m_listEtreVivantReproduction.Count);
                                    } while (m_listEtreVivantReproduction[ChoixAleatoire].Etat == false);
                                    EtreVivant.Tuer(m_listEtreVivantReproduction[ChoixAleatoire]);
                                    Console.WriteLine($"{m_listEtreVivantReproduction[ChoixAleatoire].Nom} a ete tue. ");
                                    ShowEtrevivant(m_listEtreVivantReproduction, m_listEtreVivantDivision);
                                }
                                else if(listRandom == 1 && nombreTuerDivision != m_listEtreVivantDivision.Count) // si 1 on tue un etre vivant qui se divise et uniquement si il reste des etre vivant a tuer
                                {
                                    nombreTuerDivision++;
                                    do
                                    {
                                        ChoixAleatoire = aleatoire.Next(0, m_listEtreVivantDivision.Count); //on crée un nombre aléatoire pour
                                    } while (m_listEtreVivantDivision[ChoixAleatoire].Etat == false);
                                    EtreVivant.Tuer(m_listEtreVivantDivision[ChoixAleatoire]);
                                    Console.WriteLine($"{m_listEtreVivantDivision[ChoixAleatoire].Nom} a ete tue. ");
                                    ShowEtrevivant(m_listEtreVivantReproduction, m_listEtreVivantDivision);
                                }else if(nombreTuerDivision >= m_listEtreVivantDivision.Count)  // si tous les etre vivant qui se divise sont mort on ne peut pas en tuer plus 
                                    Console.WriteLine("Impossible de tuer un etre vivant qui se divise, il ne reste plus personne!");
                            }
                            else if(nombreTuer >= nombreEtreVivant)
                            Console.WriteLine("Impossible de tuer un etre vivant, il ne reste plus personne!");
                        }
                        break;

                    case 2: //Reproduire
                        for (int i = 0; i < 3; i++) // On essaye 3 reproduction
                        {
                            //Génération d'un nombre aléatoire
                            nombreEtreVivant = m_listEtreVivantReproduction.Count + m_listEtreVivantDivision.Count;
                            ChoixAleatoire = aleatoire.Next(1, nombreEtreVivant);
                            int ChoixAleatoire2 = aleatoire.Next(1, nombreEtreVivant);
                          /* if(m_listEtreVivant[ChoixAleatoire].GetType() == m_listEtreVivant[ChoixAleatoire2].GetType())
                            {
                                
                            }
                            else
                            {
                                Console.WriteLine("La reproduction entre ",m_listEtreVivant[ChoixAleatoire].Nom ,"et", m_listEtreVivant[ChoixAleatoire2].Nom, "a échoué");
                            }*/
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
