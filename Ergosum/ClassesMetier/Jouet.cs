using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ergosum.ClassesMetier
{
    class Jouet
    {
        private int numero;
        private string libelle;
        private Categorie categ;
        private TrancheAge tranche;
        
        /// <summary>
        /// Instancie un objet Jouet et l’ajoute dans la collection des jouets de sa catégorie
        /// </summary>
        /// <param name="unNumero"></param>
        /// <param name="unLibelle"></param>
        /// <param name="uneCatégorie"></param>
        /// <param name="uneTranche"></param>
        public Jouet(int unNumero, string unLibelle, Categorie uneCategorie, TrancheAge uneTranche)
        {
            // TODO
        }

        public int Numero { get => numero;  }
        public string Libelle { get => libelle; }
        public Categorie Categ { get => categ;  }
        internal TrancheAge Tranche { get => tranche;  }
         
        /// <summary>
        /// Retourne vrai si le jouet convient à l’âge passé en paramètre.
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        public bool Convient(int unAge) {
            // TODO
            // return à changer
            return true;
        }

        /// <summary>
        /// Retourne une chaîne contenant : le libellé du jouet, le libellé de sa catégorie, 
        /// les âges minimum et maximum de la tranche d’âge lui correspondant.
        /// Les informations sont séparées par des points-virgules.
        /// </summary>
        /// <returns></returns>
        public string GetInfos()
        {
            // TODO
            return "";
        }        

    }
}
