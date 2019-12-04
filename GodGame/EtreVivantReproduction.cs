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
        public abstract EtreVivantReproduction Reproduction(EtreVivantReproduction p_etreVivant);
    }
}
