using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    public class Corail : EtreVivantReproduction
    {
        public Corail(string p_nom, byte p_nombreParents, string p_sexe) :
            base(p_nom, p_nombreParents, Regne.Animal, GenreVivant.EucaryotesMulticellulaires, p_sexe)
        {
        }

        public override void Deplace()
        {
            Console.WriteLine($"{m_nom} ne se deplace pas");
        }

        public override EtreVivantReproduction Reproduction(EtreVivantReproduction p_etreVivant)
        {
            Random aleatoire = new Random();
            int SexeRandom = aleatoire.Next(0, 2);
            if (SexeRandom == 0) // Si masculin
            {
                int NomRandom = aleatoire.Next(1, EtreVivant.nomEtreVivantMasculin.Length);
                String nom = EtreVivant.nomEtreVivantMasculin[NomRandom];
                Corail corailMasculin = new Corail(nom, 2, "male");
                return corailMasculin;
            }
            else //Sinon féminin
            {
                int NomRandom = aleatoire.Next(1, EtreVivant.nomEtreVivantFeminin.Length);
                String nom = EtreVivant.nomEtreVivantFeminin[NomRandom];
                Corail corailFeminin= new Corail(nom, 2, "femelle");
                return corailFeminin;
            }
        }

        public override string ToString()
        {
            return $"{m_nom} est un corail de sexe {m_sexe} ayant {m_nombreParents} parent(s) de regne Animal et est un eucaryote multicellulaires";
        }

    }
}
