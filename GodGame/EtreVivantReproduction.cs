using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    /// <summary>
    /// Cette classe désigne un être vivant qui se reproduit
    /// </summary>
    public abstract class EtreVivantReproduction : EtreVivant, IReproduction
    {
        public EtreVivantReproduction(string p_nom, byte p_nbParents, Regne p_regne, GenreVivant p_genreVivant, string p_sexe)
        {
            m_nom = p_nom;
            m_nombreParents = p_nbParents;
            m_regne = p_regne;
            m_genreVivant = p_genreVivant;
            m_etat = true;
            m_sexe = p_sexe;
        }
        public abstract EtreVivantReproduction Reproduction(EtreVivantReproduction p_etreVivant);
    }
}
