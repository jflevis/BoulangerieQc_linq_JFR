using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boulangerie
{
    class RecettePrix
    {
        public string nomRecette;
        public string nomProduit;
        public int idRecette;
        public int idProduit;
        public double qteProduit;
        public double prix_kg;

        public RecettePrix (string nomRecette, string nomProduit, int idRecette, int idProduit, double qteProduit, double prix_kg)
        {
            this.nomRecette = nomRecette;
            this.nomProduit = nomProduit;
            this.idRecette = idRecette;
            this.idProduit = idProduit;
            this.qteProduit = qteProduit;
            this.prix_kg = prix_kg;
        }
    }
}
