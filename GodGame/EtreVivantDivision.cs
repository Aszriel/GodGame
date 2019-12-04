using System;
using System.Collections.Generic;
using System.Text;

namespace GodGame
{
    /// <summary>
    /// Cette classe désigne un être vivant qui se divise
    /// </summary>
    public abstract class EtreVivantDivision : EtreVivant, IDivision
    {
        public abstract EtreVivantDivision Division();
    }
}
