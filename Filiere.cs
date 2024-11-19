using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    public class Filiere
    {
        public string NomFil { get; set; }
        public List<Etudiant> ListeEtudiants { get; set; }

        // Constructeur par défaut
        public Filiere()
        {
            NomFil = string.Empty;
            ListeEtudiants = new List<Etudiant>();
        }

        // Retourne le nombre d'étudiants dans la filière
        public int GetNbrEtudiants()
        {
            return ListeEtudiants.Count;
        }

        // Ajoute un étudiant à la filière
        public void AddEtudiant(Etudiant e)
        {
            ListeEtudiants.Add(e);
        }

        // Cherche un étudiant par nom et prénom
        public Etudiant Chercher(string nom, string prenom)
        {
            foreach (var etudiant in ListeEtudiants)
            {
                if (etudiant.Nom == nom && etudiant.Prenom == prenom)
                {
                    return etudiant;
                }
            }
            return null; // Retourne null si l'étudiant n'est pas trouvé
        }

        // Supprime un étudiant de la filière
        public bool DeleteEtudiant(string nom, string prenom)
        {
            var etudiant = Chercher(nom, prenom);
            if (etudiant != null)
            {
                ListeEtudiants.Remove(etudiant);
                return true; // Suppression réussie
            }
            return false; // Étudiant non trouvé
        }

        // Affiche la liste de tous les étudiants
        public void AfficherListeEtudiants()
        {
            Console.WriteLine($"Filière: {NomFil}");
            foreach (var etudiant in ListeEtudiants)
            {
                Console.WriteLine(etudiant);
            }
        }
    }
}
