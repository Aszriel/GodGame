using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    public class Dauphin : EtreVivantReproduction
    {
        public Dauphin(string p_nom, byte p_nombreParents, String p_sexe) :
            base(p_nom, p_nombreParents, Regne.Animal, GenreVivant.EucaryotesMulticellulaires, p_sexe)
        {
        }

        public override void Deplace()
        {
            Console.WriteLine($"{m_nom} nage");
        }

        public override EtreVivantReproduction Reproduction(EtreVivantReproduction p_etreVivant)
        {
            Random aleatoire = new Random();
            int SexeRandom = aleatoire.Next(0, 1);
            if (SexeRandom == 0) // Si masculin
            {
                int NomRandom = aleatoire.Next(1, EtreVivant.nomEtreVivantMasculin.Length);
                String nom = EtreVivant.nomEtreVivantMasculin[NomRandom];
                Dauphin dauphinM = new Dauphin(nom, 2, "male");
                return dauphinM;
            }
            else //Sinon féminin
            {
                int NomRandom = aleatoire.Next(1, EtreVivant.nomEtreVivantFeminin.Length);
                String nom = EtreVivant.nomEtreVivantFeminin[NomRandom];
                Dauphin dauphinF = new Dauphin(nom, 2, "femelle");
                return dauphinF;
            }
        }

        public override string ToString()
        {
            return $"{m_nom} est un dauphin de sexe {m_sexe} ayant {m_nombreParents} parent(s) de regne Animal et est un eucaryote multicellulaires";
        }

    }
}
