using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    public abstract class EtreVivant
    {

        #region Attributs
        protected static string[] nomEtreVivantMasculin = {"Marshall","Toto","Titi","Robert",
            "Jean-luc","Leo","Arthur"};
        protected static string[] nomEtreVivantFeminin = {"Julia", "Julie","Juliano","Virginie",
        "Cornellia","Elisa","Chouquette"};
        protected readonly String m_nom;
        protected byte m_nombreParents;
        protected bool m_etat; //Mort = false, Vivant = true
        protected Regne m_regne;
        protected GenreVivant m_genreVivant;
        protected String m_sexe;
        #endregion

        public EtreVivant(String p_nom, byte p_nombreParents, Regne p_regne, GenreVivant p_genreVivant, String p_sexe)
        {
            m_etat = true;
            m_nom = p_nom;
            m_sexe = p_sexe;
            m_genreVivant = p_genreVivant;
            m_regne = p_regne;
            m_nombreParents = p_nombreParents;
        }

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
