using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TP LinQ JF Rancourt 27-4-2022
//https://docs.microsoft.com/en-us/dotnet/csharp/linq/perform-inner-joins
//https://www.geeksforgeeks.org/c-sharp-program-to-join-multiple-data-sources-using-linq/

namespace boulangerie
{
    public partial class Form1 : Form
    {
        List<Produits> ListProduits = new List<Produits>();
        List<Recettes> ListRecettes = new List<Recettes>();
        List<JoinRecetteProduit> ListJoinProduitRecette = new List<JoinRecetteProduit>();

        int noIDRecetteFind = 0;
        string nomVariete = "";
        string rep = "";

        public Form1()
        {
            InitializeComponent();

            ListProduits.Add(new Produits(1, "farine blanche", 18.00));
            ListProduits.Add(new Produits(2, "farine blé entier", 25.00));
            ListProduits.Add(new Produits(3, "farine seigle", 25.00));
            ListProduits.Add(new Produits(4, "farine épeautre", 30.00));
            ListProduits.Add(new Produits(5, "sel", 5.00));
            ListProduits.Add(new Produits(6, "eau", 0.00));
            ListProduits.Add(new Produits(7, "levure sèche", 10.00));
            ListProduits.Add(new Produits(8, "lait", 3.00));
            ListProduits.Add(new Produits(9, "sucre", 2.00));
            ListProduits.Add(new Produits(10, "huile végétale", 3.00));
            ListProduits.Add(new Produits(11, "beurre", 15.00));

            ListRecettes.Add(new Recettes(1, "Pain blanc"));
            ListRecettes.Add(new Recettes(2, "Croissant"));
            ListRecettes.Add(new Recettes(3, "Burger"));
            ListRecettes.Add(new Recettes(4, "Épeautre"));
            ListRecettes.Add(new Recettes(5, "Pizza"));
            ListRecettes.Add(new Recettes(6, "Pain de campagne"));

            ListJoinProduitRecette.Add(new JoinRecetteProduit(1, 1, 1, 1));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(2, 1, 5, 0.020));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(3, 1, 6, 0.7));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(4, 1, 7, 0.01));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(5, 2, 1, 1));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(6, 2, 5, 0.02));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(7, 2, 6, 0.3));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(8, 2, 7, 0.0125));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(9, 2, 8, 0.3));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(10, 2, 9, 0.15));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(11, 2, 11, 0.45));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(12, 3, 1, 1));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(13, 3, 5, 0.012));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(14, 3, 6, 0.33));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(15, 3, 7, 0.01));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(16, 3, 8, 0.25));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(17, 3, 9, 0.07));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(18, 3, 11, 0.08));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(19, 4, 4, 1));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(20, 4, 5, 0.02));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(21, 4, 6, 0.7));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(22, 4, 7, 0.01));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(23, 5, 1, 1));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(24, 5, 5, 0.02));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(25, 5, 6, 0.6));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(26, 5, 7, 0.012));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(27, 5, 10, 0.07));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(28, 6, 1, 0.7));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(29, 6, 2, 0.2));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(30, 6, 3, 0.1));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(31, 6, 5, 0.02));
            ListJoinProduitRecette.Add(new JoinRecetteProduit(32, 6, 6, 0.01));
        }

        private void btnVoirLaRecette_Click(object sender, EventArgs e)
        {
            rep = "";
            if(!(txtRecette.Text ==""))
            {
                int noIDRecetteFind = Int32.Parse(txtRecette.Text);
                var nomVariete = ListRecettes[noIDRecetteFind - 1].nomRecette;
                var selectProduitRecette = from p in ListProduits join r in ListJoinProduitRecette on p.idProduit equals r.produitId where r.recetteID == noIDRecetteFind select p;
                rep = "Afficher tous les produits de la recette: " + nomVariete;
                foreach (var nomProduitDansRecette in selectProduitRecette)
                {
                    rep += "\r" + "\r" + nomProduitDansRecette.nomProduit + " au prix/kg " + nomProduitDansRecette.prix_au_kg + " $";
                }
                MessageBox.Show(rep);
            }
            else
            {
                MessageBox.Show("Vous devez entrer un numéro de recette");
            }
        }
        private void btnListRecettes_Click(object sender, EventArgs e)
        {
            rep = "";
            var selectRecette = from r in ListRecettes select r;
            foreach (var nomR in selectRecette)
            {
                rep += "\r" + "\r" + nomR.nomRecette + " ID: " + nomR.idRecette;
            }
            MessageBox.Show(rep);
        }
        private void btnListProduits_Click(object sender, EventArgs e)
        {
            rep = "Liste des produits";
            var selectProduit = from p in ListProduits select p;
            foreach (var nomP in selectProduit)
            {
                rep += "\r" + "\r" + nomP.nomProduit + " | prix au Kg de: " + nomP.prix_au_kg + " $";
            }
            MessageBox.Show(rep);
        }
        private void btnJoinRecetteProduits_Click(object sender, EventArgs e)
        {
            rep = "Liste des Joins Produits-Recettes";
            var selectJoin = from j in ListJoinProduitRecette select j;
            foreach (var nomJ in selectJoin)
            {
                rep += "\r" + "\r" + "Join ID: " + nomJ.id + " | produit ID: " + nomJ.produitId + ", poids du produit " + nomJ.quantiteProduit + ", Kg " + " pour Recette ID: " + nomJ.recetteID;
            }
            MessageBox.Show(rep);
        }
        private void btnPoidsProdRecette_Click(object sender, EventArgs e)
        {
            // Join the recetteet 2 tables
            int noIDRecetteFind = Int32.Parse(txtRecette.Text);
            var nomVariete = ListRecettes[noIDRecetteFind - 1].nomRecette;
            var result = (from r in ListRecettes
                          join j in ListJoinProduitRecette on
                          r.idRecette equals j.recetteID
                          join p in ListProduits on j.produitId equals p.idProduit
                          where j.recetteID == noIDRecetteFind
                          select new
                          {
                              ID = r.idRecette,
                              nomRecette = r.nomRecette,
                              produit = p.nomProduit,
                              poids = j.quantiteProduit,
                              prix_par_kg = p.prix_au_kg,
                              prixProduitdelaRecette = Math.Round(p.prix_au_kg * j.quantiteProduit, 2)
                          }).ToList();
            // Display the result
            string message = "ID: " + noIDRecetteFind.ToString() + " -->  " + nomVariete + "\r\r";
            double prixTotal = 0;
            foreach (var e1 in result)
            {
                prixTotal += e1.prixProduitdelaRecette;
                message = message + e1.produit + " -->  " + e1.poids.ToString() + " Kg = " + e1.prixProduitdelaRecette.ToString() + " $\r";
            }
            MessageBox.Show(message + "\r\rPrix total de la recette " + Math.Round(prixTotal, 2).ToString() + " $");
        }
        private void btnMiseAJourPrixRecette_Click(object sender, EventArgs e)
        {
            var laRecette = ListRecettes.Where(s => s.idRecette == noIDRecetteFind);
            MessageBox.Show("Voici le nom de la recette no: " + laRecette.First().nomRecette);
        }
        private void txtRecette_TextChanged(object sender, EventArgs e)
        {
            try
            {
                noIDRecetteFind = Convert.ToInt32(txtRecette.Text);
                if (noIDRecetteFind < 6)
                {
                    noIDRecetteFind = Int32.Parse(txtRecette.Text);
                    nomVariete = ListRecettes[noIDRecetteFind].nomRecette;
                    var laRecette = ListRecettes.Where(s => s.idRecette == noIDRecetteFind);
                    MessageBox.Show("Voici le nom de la recette no: " + laRecette.First().nomRecette);
                        }
                else
                {
                    MessageBox.Show("Ce numéro n'existe pas");
                }
            }
            catch (Exception h)
            {
                MessageBox.Show("SVP veuillez entrer seulement un numéro");
            }
           
        }
        private void btnListRecettesLambda_Click(object sender, EventArgs e)
        {
            rep ="";
            var laRecette = ListRecettes.Where(r => r.idRecette > 0);
            foreach ( var r in laRecette)
            {
                rep += "\r" + "\r" + r.nomRecette + " ID: " + r.idRecette;
            }
            MessageBox.Show(rep);
        }

        private void btnListProdLambda_Click(object sender, EventArgs e)
        {
            rep = "Liste des produits";
            var selectProduit = ListProduits.Where(p => p.idProduit > 0);
            foreach(var nomP in selectProduit)
            {
                rep += "\r" + "\r" + nomP.nomProduit + " | prix au Kg de: " + nomP.prix_au_kg + " $";
            }
            MessageBox.Show(rep);
        }
        private void btnPrixRecettev2_Click(object sender, EventArgs e)
        {
            //https://www.tutorialspoint.com/how-to-make-use-of-join-with-linq-and-lambda-in-chash
            string message = "";
            int noIDRecetteFind = Int32.Parse(txtRecette.Text);
            var nomVariete = ListRecettes[noIDRecetteFind - 1].nomRecette;
           // var laRecette = (ListJoinProduitRecette.Where(r => r.recetteID == noIDRecetteFind)).Join(ListProduits,
                  var laRecette = ListJoinProduitRecette.Join(ListProduits,
                produitIDJoin => produitIDJoin.produitId,
                produitId => produitId.idProduit,
                (produitIDJoin, produitId) => new { ProduitIdJoin = produitIDJoin, ProduitID = produitId.idProduit, ProduitNom = produitId.nomProduit, ProduitPRixKg = produitId.prix_au_kg, QteProduit = produitIDJoin.quantiteProduit, RecetteId = produitIDJoin.recetteID })
               .Where(produitAndRecette => (produitAndRecette.RecetteId == noIDRecetteFind));
             message = "ID: " + noIDRecetteFind.ToString() + " -->  " + nomVariete + "\r\r";
            double prixTotal = 0;
            foreach (var r in laRecette)
            {
                message += "\r" + r.ProduitNom + " : " + r.QteProduit + " Kg " + "au prix de " + r.ProduitPRixKg + "$/kg = " + Math.Round(r.ProduitPRixKg * r.QteProduit,2).ToString();
                prixTotal += Math.Round(r.ProduitPRixKg * r.QteProduit, 2);
            }
            MessageBox.Show(message+"\r\r"+"Le Prix total sera de : "+ Math.Round(prixTotal,2).ToString());  
        }
    }
}


