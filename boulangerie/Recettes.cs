using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boulangerie
{
    class Recettes 
    {
        public int idRecette;
        public string nomRecette = "";
      
        public double prix_kg = 0;

        public  Recettes (int id,string nom)
        {
            this.idRecette = id;
            this.nomRecette = nom;
        }
    }
}
