using System;
using System.Collections.Generic;
using System.Linq;
using Ergosum.ClassesTechniques;

namespace Ergosum.ClassesTechniques
{

    class Dictionnaire<TypeCle, TypeValeur> : Dictionary<Object, Object>
    {
        /// <summary>
        /// ajoute un élément (clé, valeur) dont le premier paramètre est la clé et le second 
        /// paramètre la valeur.
        /// </summary>
        /// <param name="cle"></param>
        /// <param name="valeur"></param>
        public void Ajouter(TypeCle cle, TypeValeur valeur)
        {
            this.Add(cle, valeur);
        }
        public void Modifier(TypeCle cle, TypeValeur valeur)
        {
            this[cle] = valeur;
        }

        public TypeValeur DonnerValeur(TypeCle cle)
        {
            return (TypeValeur)this[cle];
        }    
        
        public Collection<TypeCle> DonnerToutesLesCles()
        {
            return new Collection<TypeCle>((this.Keys).Cast<TypeCle>().ToList());
        }


        public bool Existe(TypeCle cle)
        {
            return this.ContainsKey(cle);
        }

        public void Retirer(TypeCle cle)
        {
            this.Remove(cle);
        }
    }
}
