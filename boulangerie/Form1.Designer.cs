
namespace boulangerie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListRecettes = new System.Windows.Forms.Button();
            this.btnListProduits = new System.Windows.Forms.Button();
            this.btnVoirLaRecette = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecette = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPoidsProdRecette = new System.Windows.Forms.Button();
            this.btnMiseAJourPrixRecette = new System.Windows.Forms.Button();
            this.btnJoinRecetteProduits = new System.Windows.Forms.Button();
            this.btnListRecettesLambda = new System.Windows.Forms.Button();
            this.btnListProdLambda = new System.Windows.Forms.Button();
            this.btnPrixRecettev2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListRecettes
            // 
            this.btnListRecettes.Location = new System.Drawing.Point(37, 43);
            this.btnListRecettes.Name = "btnListRecettes";
            this.btnListRecettes.Size = new System.Drawing.Size(180, 23);
            this.btnListRecettes.TabIndex = 0;
            this.btnListRecettes.Text = "Voir la liste recettes";
            this.btnListRecettes.UseVisualStyleBackColor = true;
            this.btnListRecettes.Click += new System.EventHandler(this.btnListRecettes_Click);
            // 
            // btnListProduits
            // 
            this.btnListProduits.Location = new System.Drawing.Point(173, 42);
            this.btnListProduits.Name = "btnListProduits";
            this.btnListProduits.Size = new System.Drawing.Size(180, 23);
            this.btnListProduits.TabIndex = 1;
            this.btnListProduits.Text = "Voir listes des produits";
            this.btnListProduits.UseVisualStyleBackColor = true;
            this.btnListProduits.Click += new System.EventHandler(this.btnListProduits_Click);
            // 
            // btnVoirLaRecette
            // 
            this.btnVoirLaRecette.Location = new System.Drawing.Point(55, 128);
            this.btnVoirLaRecette.Name = "btnVoirLaRecette";
            this.btnVoirLaRecette.Size = new System.Drawing.Size(127, 23);
            this.btnVoirLaRecette.TabIndex = 2;
            this.btnVoirLaRecette.Text = "Voir les ingrédients";
            this.btnVoirLaRecette.UseVisualStyleBackColor = true;
            this.btnVoirLaRecette.Click += new System.EventHandler(this.btnVoirLaRecette_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entrez le numéro de la recette...";
            // 
            // txtRecette
            // 
            this.txtRecette.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRecette.Location = new System.Drawing.Point(80, 89);
            this.txtRecette.Name = "txtRecette";
            this.txtRecette.Size = new System.Drawing.Size(86, 26);
            this.txtRecette.TabIndex = 4;
            this.txtRecette.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecette.TextChanged += new System.EventHandler(this.txtRecette_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnPoidsProdRecette);
            this.panel1.Controls.Add(this.btnVoirLaRecette);
            this.panel1.Controls.Add(this.txtRecette);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnListRecettes);
            this.panel1.Location = new System.Drawing.Point(129, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 212);
            this.panel1.TabIndex = 5;
            // 
            // btnPoidsProdRecette
            // 
            this.btnPoidsProdRecette.Location = new System.Drawing.Point(25, 157);
            this.btnPoidsProdRecette.Name = "btnPoidsProdRecette";
            this.btnPoidsProdRecette.Size = new System.Drawing.Size(189, 38);
            this.btnPoidsProdRecette.TabIndex = 10;
            this.btnPoidsProdRecette.Text = "Prix pour cette recette";
            this.btnPoidsProdRecette.UseVisualStyleBackColor = true;
            this.btnPoidsProdRecette.Click += new System.EventHandler(this.btnPoidsProdRecette_Click);
            // 
            // btnMiseAJourPrixRecette
            // 
            this.btnMiseAJourPrixRecette.Location = new System.Drawing.Point(506, 155);
            this.btnMiseAJourPrixRecette.Name = "btnMiseAJourPrixRecette";
            this.btnMiseAJourPrixRecette.Size = new System.Drawing.Size(156, 52);
            this.btnMiseAJourPrixRecette.TabIndex = 6;
            this.btnMiseAJourPrixRecette.Text = "Nom de la Recette Lambda";
            this.btnMiseAJourPrixRecette.UseVisualStyleBackColor = true;
            this.btnMiseAJourPrixRecette.Click += new System.EventHandler(this.btnMiseAJourPrixRecette_Click);
            // 
            // btnJoinRecetteProduits
            // 
            this.btnJoinRecetteProduits.Location = new System.Drawing.Point(111, 99);
            this.btnJoinRecetteProduits.Name = "btnJoinRecetteProduits";
            this.btnJoinRecetteProduits.Size = new System.Drawing.Size(301, 23);
            this.btnJoinRecetteProduits.TabIndex = 7;
            this.btnJoinRecetteProduits.Text = "Voir listes des Join Recette_Produits";
            this.btnJoinRecetteProduits.UseVisualStyleBackColor = true;
            this.btnJoinRecetteProduits.Click += new System.EventHandler(this.btnJoinRecetteProduits_Click);
            // 
            // btnListRecettesLambda
            // 
            this.btnListRecettesLambda.Location = new System.Drawing.Point(506, 220);
            this.btnListRecettesLambda.Name = "btnListRecettesLambda";
            this.btnListRecettesLambda.Size = new System.Drawing.Size(156, 52);
            this.btnListRecettesLambda.TabIndex = 8;
            this.btnListRecettesLambda.Text = "Liste des recettes Lambda";
            this.btnListRecettesLambda.UseVisualStyleBackColor = true;
            this.btnListRecettesLambda.Click += new System.EventHandler(this.btnListRecettesLambda_Click);
            // 
            // btnListProdLambda
            // 
            this.btnListProdLambda.Location = new System.Drawing.Point(506, 99);
            this.btnListProdLambda.Name = "btnListProdLambda";
            this.btnListProdLambda.Size = new System.Drawing.Size(156, 39);
            this.btnListProdLambda.TabIndex = 11;
            this.btnListProdLambda.Text = "Liste des produits Lambda";
            this.btnListProdLambda.UseVisualStyleBackColor = true;
            this.btnListProdLambda.Click += new System.EventHandler(this.btnListProdLambda_Click);
            // 
            // btnPrixRecettev2
            // 
            this.btnPrixRecettev2.Location = new System.Drawing.Point(506, 366);
            this.btnPrixRecettev2.Name = "btnPrixRecettev2";
            this.btnPrixRecettev2.Size = new System.Drawing.Size(156, 52);
            this.btnPrixRecettev2.TabIndex = 12;
            this.btnPrixRecettev2.Text = "Ingrédients des recettes Lambda_v2";
            this.btnPrixRecettev2.UseVisualStyleBackColor = true;
            this.btnPrixRecettev2.Click += new System.EventHandler(this.btnPrixRecettev2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrixRecettev2);
            this.Controls.Add(this.btnListProdLambda);
            this.Controls.Add(this.btnListRecettesLambda);
            this.Controls.Add(this.btnJoinRecetteProduits);
            this.Controls.Add(this.btnMiseAJourPrixRecette);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListProduits);
            this.Name = "Form1";
            this.Text = "Recettes de la boulangerie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListRecettes;
        private System.Windows.Forms.Button btnListProduits;
        private System.Windows.Forms.Button btnVoirLaRecette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecette;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMiseAJourPrixRecette;
        private System.Windows.Forms.Button btnJoinRecetteProduits;
        private System.Windows.Forms.Button btnPoidsProdRecette;
        private System.Windows.Forms.Button btnListRecettesLambda;
        private System.Windows.Forms.Button btnListProdLambda;
        private System.Windows.Forms.Button btnPrixRecettev2;
    }
}

