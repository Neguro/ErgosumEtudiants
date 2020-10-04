﻿using Ergosum.ClassesTechniques;
using System;
using System.Collections.Generic;
//using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ergosum.ClassesMetier
{
    class Categorie
    {
        private int code;
        private string libelle;
        /// <summary>
        /// ensemble des jouets de cette catégorie
        /// </summary>
        private Collection<Jouet> lesJouets;

        public Categorie(int unCode, string unLibelle)
        {
            this.code = unCode;
            this.libelle = unLibelle;
            lesJouets = new Collection<Jouet>();
        }

        public int Code { get => code; }
        public string Libelle { get => libelle; }

        /// <summary>
        /// Ajoute le jouet passé en paramètre à la collection lesJouets	
        /// </summary>
        /// <param name="unJouet"></param>
        public void AjouterJouet(Jouet unJouet)
        {
            this.lesJouets.Add(unJouet);            
        }

        /// <summary>
        /// Retourne les jouets de la catégorie compatibles avec l'âge passé en paramètre
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public Collection<Jouet> JouetTranche(int age)
        {
            Collection<Jouet> uneCollection = new Collection<Jouet>();
            foreach(Jouet unJouet in this.lesJouets)
            {
                if(unJouet.Convient(age))
                {
                    uneCollection.Add(unJouet);
                }
            }
            return uneCollection;
        }
    }
}
