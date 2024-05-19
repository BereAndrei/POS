using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class FiltrareCriteriu : IFiltrare
    {
        public List<ProdusAbstract> Filtrare(List<ProdusAbstract> elemente, ICriteriu criteriu)
        {
            IEnumerable < ProdusAbstract > returnat =
             from elem in elemente
             where criteriu.IsIndeplinit(elem)
             orderby elem.Nume
             select elem;
            return returnat.ToList<ProdusAbstract>();
        }

        
    }
}
