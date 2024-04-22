namespace entitati
{
    public class Serviciu : ProdusAbstract
    {
        public Serviciu(uint id, string? nume, string? codIntern, int? pret, string? categorie) : base(id, nume, codIntern, pret, categorie) { }
        public override string ToString() => "Serviciu: " + this.Nume + "[" + this.CodIntern + "]" + " " + this.Pret + " " + this.Categorie;
        public override string Descriere()
        {
            return "Serviciu: " + this.Nume + "[" + this.CodIntern + "]" + " " + this.Pret + " " + this.Categorie;
        }
        public override string AltaDescriere()
        {
            return "Serviciu: " + base.AltaDescriere() + " " + this.Pret + " " + this.Categorie;
        }

        public static bool operator ==(Serviciu e1, Serviciu e2)
        {
            if (e1.Nume == e2.Nume && e1.CodIntern == e2.CodIntern)
                return true;
            return false;
        }

        public static bool operator !=(Serviciu e1, Serviciu e2)
        {
            if (!(e1.Nume == e2.Nume && e1.CodIntern == e2.CodIntern))
                return true;
            return false;
        }

        public override bool Equals(object? obj)
        {
            if (this.GetType() == obj.GetType())
            {
                Serviciu obj2 = (Serviciu)obj;
                return (this == obj2);

            }
            return false;
        }
        public override bool compareTo(ProdusAbstract other)
        {
            if (this.GetType() == other.GetType())
                if (this.Nume == other.Nume && this.CodIntern == other.CodIntern)
                    return true;
            return false;
        }

        public override bool canAddToPackage(Pachet pachet)
        {
            //max =-1 : no limit
            //max = most of this element that can fit in one package
            int max = -1;
            int s = 0;
            foreach (IPackageable e in pachet.elem_pachet)
            {
                if (e.GetType() == typeof(Serviciu))
                    s++;
                if (s == max)
                    return false;
            }
            return true;
        }
    }
}
