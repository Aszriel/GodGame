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

        public EtreVivant Reproduction(EtreVivant p_etreVivant)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{m_nom} est un corail de sexe {m_sexe} ayant {m_nombreParents} parent(s) de regne Animal et est un eucaryote multicellulaires";
        }

    }
}
