using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    public class Personne
    {
        public int Numero { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public override string ToString()
        {
            return $"Numéro: {Numero}, Nom: {Nom}, Prénom: {Prenom}";
        }
    }

}
