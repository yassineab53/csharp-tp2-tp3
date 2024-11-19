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

        // Constructeur par d�faut
        public Filiere()
        {
            NomFil = string.Empty;
            ListeEtudiants = new List<Etudiant>();
        }

        // Retourne le nombre d'�tudiants dans la fili�re
        public int GetNbrEtudiants()
        {
            return ListeEtudiants.Count;
        }

        // Ajoute un �tudiant � la fili�re
        public void AddEtudiant(Etudiant e)
        {
            ListeEtudiants.Add(e);
        }

        // Cherche un �tudiant par nom et pr�nom
        public Etudiant Chercher(string nom, string prenom)
        {
            foreach (var etudiant in ListeEtudiants)
            {
                if (etudiant.Nom == nom && etudiant.Prenom == prenom)
                {
                    return etudiant;
                }
            }
            return null; // Retourne null si l'�tudiant n'est pas trouv�
        }

        // Supprime un �tudiant de la fili�re
        public bool DeleteEtudiant(string nom, string prenom)
        {
            var etudiant = Chercher(nom, prenom);
            if (etudiant != null)
            {
                ListeEtudiants.Remove(etudiant);
                return true; // Suppression r�ussie
            }
            return false; // �tudiant non trouv�
        }

        // Affiche la liste de tous les �tudiants
        public void AfficherListeEtudiants()
        {
            Console.WriteLine($"Fili�re: {NomFil}");
            foreach (var etudiant in ListeEtudiants)
            {
                Console.WriteLine(etudiant);
            }
        }
    }
}
