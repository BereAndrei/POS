using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class CriteriuCategorie : ICriteriu
    {
        String? Categorie {  get;  }
        public CriteriuCategorie(string? categorie)
        {
            Categorie = categorie;
        }
        public bool IsIndeplinit(ProdusAbstract element)
        {
            if(element.Categorie == Categorie)
                return true;
            return false;
        }
    }
}
