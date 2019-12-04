using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    class Bacterie : EtreVivantDivision
    {
        public Bacterie(string p_nom, byte p_nombreParents, String p_sexe) :
          base(p_nom, p_nombreParents, Regne.Bacterie, GenreVivant.ProcaryotesUnicellulaire, p_sexe)
        {
        }

        public override void Deplace()
        {
            Console.WriteLine($"{m_nom} nage dans le cytoplasme");
        }

        public override EtreVivantDivision Division()
        {
            Random aleatoire = new Random();
            int NomRandom = aleatoire.Next(1, EtreVivant.nomEtreVivantMasculin.Length);
            String nom = EtreVivant.nomEtreVivantMasculin[NomRandom];
            Bacterie b = new Bacterie(nom, 1, "none");
            return b;
        }

        public override string ToString()
        {
            return $"{m_nom} est une bacterie ayant {m_nombreParents} parent(s) de regne Bacterie et est un procaryote unicellulaire";
        }
    }
}
