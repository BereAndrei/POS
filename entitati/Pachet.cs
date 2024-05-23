using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Pachet : ProdusAbstract
    {
        public List<ProdusAbstract>? elem_pachet;

     public Pachet() { }
        public Pachet(uint id, string? nume, string? codIntern, string? categorie) : base(id, nume, codIntern, 0, categorie)
        {
            elem_pachet = new List<ProdusAbstract>();
        }
        public void adaugaPachet(IPackageable elem)
        {
            if (elem.canAddToPackage(this))
                elem_pachet.Add((ProdusAbstract)elem);
        }
        public override bool canAddToPackage(Pachet pachet) => base.canAddToPackage(pachet);
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
                Pret = Pret + ((ProdusAbstract)p).Pret;
            
            this.Pret = Pret;
        }
        public override string Descriere()
        {
            string ret = "Pachet: " + " Nume:" + this.Nume + " Cod Intern:" + this.CodIntern + " Pret:" + this.Pret + " Categorie:" + this.Categorie; 
            foreach (IPackageable elem in elem_pachet)
                ret = ret + "\n    " + elem.ToString();
            return ret;
        }
        public override string? ToString()
        {
            string ret = ret = "Pachet: " + " Nume:" + this.Nume + " Cod Intern:" + this.CodIntern + " Pret:" + this.Pret + " Categorie:" + this.Categorie;
            foreach (IPackageable elem in elem_pachet)
                ret = ret + "\n    " + elem.ToString();
            return ret;
        }
    }
}
