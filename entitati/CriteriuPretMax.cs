using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{

    public class CriteriuPretMax : ICriteriu
    {
        int? Pret { get; }
        public CriteriuPretMax(int? pret)
        {
            Pret = pret;
        }
        public bool IsIndeplinit(ProdusAbstract element)
        {
            if (element.Pret <= Pret)
                return true;
            return false;
        }
    }
}
