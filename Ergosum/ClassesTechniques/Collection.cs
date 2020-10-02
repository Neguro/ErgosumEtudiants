using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ergosum.ClassesTechniques
{
    class Collection<T> : System.Collections.ObjectModel.Collection<T>
    {
        public Collection() : base() { }
        public Collection(List<T> l) : base(l) { }



        public int Cardinal()
        {
            return this.Count;
        }

        public T ObtenirObjet(int unIndex)
        {
            return this[unIndex];
        }

        public void Ajouter(T unObjet)
        {
            this.Add(unObjet);
        }
    }
}
