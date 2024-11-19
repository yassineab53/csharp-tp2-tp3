using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    // tp2
    /*class Program
    {
        //main pour ex3
        static void Main(string[] args)
        {
            Filiere informatique = new Filiere { NomFil = "Informatique" };

            Etudiant etudiant1 = new Etudiant(1, "Dupont", "Jean");
            etudiant1.Filiere = "Informatique";
            etudiant1.Notes = new float[] { 14.5f, 15.0f, 16.0f };

            Etudiant etudiant2 = new Etudiant(2, "Durand", "Marie");
            etudiant2.Filiere = "Informatique";
            etudiant2.Notes = new float[] { 13.0f, 14.0f, 15.0f };

            
            informatique.AddEtudiant(etudiant1);
            informatique.AddEtudiant(etudiant2);

            
            informatique.AfficherListeEtudiants();

            
            var cherche = informatique.Chercher("Durand", "Marie");
            if (cherche != null)
            {
                Console.WriteLine($"Étudiant trouvé : {cherche}");
            }
            else
            {
                Console.WriteLine("Étudiant non trouvé.");
            }

           
            bool supprime = informatique.DeleteEtudiant("Durand", "Marie");
            Console.WriteLine(supprime
                ? "Étudiant supprimé avec succès."
                : "Étudiant non trouvé pour suppression.");

            
            informatique.AfficherListeEtudiants();

            
            Console.WriteLine($"Nombre d'étudiants dans la filière {informatique.NomFil}: {informatique.GetNbrEtudiants()}");
            Console.ReadLine();
        }


        //main pour ex2
        /*static void Main(string[] args)
        {
            
            Etudiant etudiant1 = new Etudiant();
            etudiant1.Numero = 1;
            etudiant1.Nom = "Dupont";
            etudiant1.Prenom = "Jean";
            etudiant1.Filiere = "Mathématiques";
            etudiant1.Notes = new float[] { 14.5f, 16.0f, 12.0f, 15.0f, 18.0f };

            
            Etudiant etudiant2 = new Etudiant(2, "Durand", "Marie");
            etudiant2.Filiere = "Informatique";
            etudiant2.Notes = new float[] { 13.0f, 14.0f, 15.5f, 17.0f, 16.0f };

            
            Console.WriteLine(etudiant1);
            Console.WriteLine(etudiant2);

            Console.ReadLine();
        }*/

        //main pour ex1
        /*static void Main(string[] args)
        {
            
            Etudiant[] etudiants = new Etudiant[5];

            
            for (int i = 0; i < etudiants.Length; i++)
            {
                etudiants[i] = new Etudiant
                {
                    Numero = i + 1,
                    Nom = $"Nom{i + 1}",
                    Prenom = $"Prenom{i + 1}",
                    Filiere = "Informatique",
                    Notes = GenererNotesAleatoires(5)
                };
            }

           
            foreach (var etudiant in etudiants)
            {
                Console.WriteLine(etudiant);
            }

            Console.ReadLine();
        }


        
        static float[] GenererNotesAleatoires(int nombreNotes)
        {
            Random random = new Random();
            float[] notes = new float[nombreNotes];
            for (int i = 0; i < nombreNotes; i++)
            {
                notes[i] = (float)Math.Round(random.NextDouble() * 20, 2); 
            }
            return notes;
        } */




    //tp3
    class Program
    {
        static int[] tableau = new int[] { 17, 12, 15, 38, 29, 157, 89, -22, 0, 5 };

        static int division(int indice, int diviseur)
        {
            return tableau[indice] / diviseur;
        }

        //add a personilize Exception NoSuchElementException
        public class NoSuchElementException : Exception
        {
            public NoSuchElementException(string message) : base(message) { }
        }

        public class RechercheEntier
        {
            public static int Rechercher(int[] tableau, int cible)
            {
                try
                {
                    for (int i = 0; i < tableau.Length; i++)
                    {
                        if (tableau[i] == cible)
                        {
                            return i;
                        }
                    }
                    throw new NoSuchElementException("Element non trouve dans le tableau.");
                }
                finally
                {
                    Console.WriteLine("Au revoir !");
                }
            }

            public stativ void Main(string[] args)
            {

            }
        }




        /* static void Main(string[] args)
        {
            /*try
            {
                int x, y;

                Console.WriteLine("Entrez l’indice de l’entier à diviser: ");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Entrez le diviseur: ");
                y = int.Parse(Console.ReadLine());

                Console.WriteLine("Le résultat de la division est: ");
                Console.WriteLine(division(x, y));
            }
            
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Erreur : L'indice est en dehors des limites du tableau.");
            }
            
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erreur : Division par zéro non permise.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erreur : Entrée invalide, veuillez entrer un nombre entier.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erreur : Nombre trop grand pour un entier.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur inattendue : {ex.Message}");
            }

            Console.ReadLine();
        }*/
    }
 }


