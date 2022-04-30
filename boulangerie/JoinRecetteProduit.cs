using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boulangerie
{
    class JoinRecetteProduit
    {
        public int id;
        public int recetteID;
        public int produitId;
        public double quantiteProduit;
   
        public JoinRecetteProduit(int idJoin, int recetteID, int produitId,double quantite) //la quantite est en kg comme unité
        {
            this.id = idJoin;
            this.recetteID = recetteID;
            this.produitId = produitId;
            this.quantiteProduit = quantite;
  
        }
    }
}
