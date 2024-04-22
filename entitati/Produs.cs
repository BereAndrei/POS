namespace entitati
{
    public class Produs : ProdusAbstract
    {
        public string? Producator { get; set; }

        public Produs(uint id, string? nume, string? codIntern, string? producator, int? pret, string? categorie) : base(id, nume, codIntern, pret, categorie)
        {
            Producator = producator;
        }
        public override string ToString()
        {
            return "Produs: " + this.Nume + "[" + this.CodIntern + "]" + this.Producator + " " + this.Pret + " " + this.Categorie;
        }
        public override string Descriere()
        {
            return "Produs: " + this.Nume + "[" + this.CodIntern + "]" + this.Producator + " " + this.Pret + " " + this.Categorie;
        }
        public override string AltaDescriere()
        {
            return "Produse: " + base.AltaDescriere() + this.Producator + " " + this.Pret + " " + this.Categorie;
        }

        public override bool Equals(object? obj)
        {
            if (this.GetType() == obj.GetType())
            {
                Produs obj2 = (Produs)obj;

                return (this == obj2);
            }
            return false;
        }
        public static bool operator ==(Produs e1, Produs e2)
        {
            if (e1.Nume == e2.Nume && e1.CodIntern == e2.CodIntern && e1.Producator == e2.Producator)
                return true;
            return false;
        }

        public static bool operator !=(Produs e1, Produs e2)
        {
            if (!(e1.Nume == e2.Nume && e1.CodIntern == e2.CodIntern && e1.Producator == e2.Producator))
                return true;
            return false;
        }
        public override bool compareTo(ProdusAbstract other)
        {
            if (this.GetType() == other.GetType())
                if (this.Nume == other.Nume && this.CodIntern == other.CodIntern && this.Producator == ((Produs)other).Producator)
                    return true;

            return false;
        }

        public override bool canAddToPackage(Pachet pachet)
        {
            //max =-1 : no limit
            //max = most of this element that can fit in one package
            int max = 1;
            int p = 0;
            foreach (IPackageable e in pachet.elem_pachet)
            {
                if (e.GetType() == typeof(Produs))
                    p++;
                if (p == max)
                    return false;
            }
            return true;
        }
    }
}