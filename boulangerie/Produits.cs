using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boulangerie
{
    class Produits
    {
        public int idProduit;
        public string nomProduit;
        public double prix_au_kg;

        public Produits(int id,string nom, double prix_kg)
        {
            this.idProduit = id;
            this.nomProduit = nom;
            this.prix_au_kg = prix_kg;
        }
    }
}
