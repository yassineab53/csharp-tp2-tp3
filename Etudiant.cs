using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    [Serializable]
    public class Etudiant : Personne
    {
        public string Filiere { get; set; }
        public float[] Notes { get; set; }

        // Constructeur par défaut
        public Etudiant()
        {
            Numero = 0;
            Nom = string.Empty;
            Prenom = string.Empty;
            Filiere = string.Empty;
            Notes = new float[0];
        }

        // Constructeur avec paramètres pour numéro, nom et prénom
        public Etudiant(int numero, string nom, string prenom)
        {
            Numero = numero;
            Nom = nom;
            Prenom = prenom;
            Filiere = string.Empty; // Par défaut vide
            Notes = new float[0];   // Pas de notes par défaut
        }

        // Méthode pour calculer la moyenne
        public float CalculMoyenne()
        {
            if (Notes == null || Notes.Length == 0) return 0;
            float somme = 0;
            foreach (var note in Notes)
            {
                somme += note;
            }
            return somme / Notes.Length;
        }

        public override string ToString()
        {
            return base.ToString() + $", Filière: {Filiere}, Moyenne: {CalculMoyenne():0.00}";
        }
    }

}
