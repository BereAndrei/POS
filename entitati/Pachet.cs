using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Pachet : ProdusAbstract
    {
        public List<IPackageable>? elem_pachet;

        public Pachet(uint id, string? nume, string? codIntern, string? categorie) : base(id, nume, codIntern, 0, categorie)
        {
            elem_pachet = new List<IPackageable>();
        }

        public void adaugaPachet(IPackageable elem)
        {
            if (elem.canAddToPackage(this))
                elem_pachet.Add(elem);
        }

        public override bool canAddToPackage(Pachet pachet)
        {
            return base.canAddToPackage(pachet);
        }

        public override bool compareTo(ProdusAbstract other)
        {
            {
                if (this.GetType() == other.GetType())
                    if (this.Nume == other.Nume && this.CodIntern == other.CodIntern)
                        return true;
                return false;
            }
        }

        public void calculPret()
        {
            int? Pret = 0;
            foreach (IPackageable p in elem_pachet)
            {
                ProdusAbstract pr = p as ProdusAbstract;
                Pret = Pret + pr.Pret;
            }
        }
        public override string Descriere()
        {
            string ret = "Pachet: " + this.Nume + "[" + this.CodIntern + "]" + " " + this.Pret + " " + this.Categorie; ;
            foreach (IPackageable elem in elem_pachet)
                ret = ret + "\n    " + elem.ToString();
            return ret;
        }

        public override string? ToString()
        {
            string ret = "Pachet: " + this.Nume + "[" + this.CodIntern + "]" + " " + this.Pret + " " + this.Categorie; ;
            foreach (IPackageable elem in elem_pachet)
                ret = ret + "\n    " + elem.ToString();
            return ret;
        }
    }



}
