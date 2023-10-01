using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miniProjet_voiture
{
    class Roue
    {
        //attributs
        private string typeRoues;
        //constructeurs
        public Roue(string categorie)
        {
            this.typeRoues = categorie;
        }
        //propriétés
        public string TypeRoues
        {
            get { return typeRoues; }
            set { typeRoues = value; }
        }
        //méthodes
        
    }
}
