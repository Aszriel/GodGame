using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    public abstract class EtreVivant
    {

        #region Attributs
        protected static string[] nomEtreVivantMasculin = {"Marshall","Toto","Titi","Robert",
            "Jean-luc","Leo","Arthur", "Luc", "Robin", "Pierre", "Pascal"};
        protected static string[] nomEtreVivantFeminin = {"Julia", "Julie","Juliano","Virginie",
        "Cornellia","Elisa","Chouquette", "Georgette","Gertrude"};
        protected String m_nom;
        protected byte m_nombreParents;
        protected bool m_etat; //Mort = false, Vivant = true
        protected Regne m_regne;
        protected GenreVivant m_genreVivant;
        protected String m_sexe;
        #endregion



        /// <summary>
        /// Tue l'être vivant passé en paramètre, en mettant son état à false
        /// </summary>
        /// <param name="p_etreVivant">L'être vivant à tuer</param>
        public static void Tuer(EtreVivant p_etreVivant)
        {
            p_etreVivant.m_etat = false;
        }

        public bool Etat
        {
            get { return m_etat; }
        }

        public String Nom
        {
            get { return m_nom; }
        }

        public abstract void Deplace();


    }
}
