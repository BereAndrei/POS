namespace entitati
{
    public class Produs : ProdusAbstract
    {
        public static int MaxPachet { get; set; } = -1;
        public string? Producator { get; set; }
        public Produs() { }
        public Produs(uint id, string? nume, string? codIntern, string? producator, int? pret, string? categorie) : base(id, nume, codIntern, pret, categorie)
        {
            Producator = producator;
        }
        public override string ToString() => "Produs: " + " Nume:" + this.Nume + " Cod Intern:" + " Producator:" + this.Producator + " Pret:" + this.Pret + " Categorie:" + this.Categorie;
        
        public override string Descriere() => "Produs: " + " Nume:" + this.Nume + " Cod Intern:" + " Producator:" + this.Producator + " Pret:" + this.Pret + " Categorie:" + this.Categorie;

        public override string AltaDescriere() => "Produs: " + base.AltaDescriere() + " Producator:" + this.Producator + " Pret:" + this.Pret + " Categorie:" + this.Categorie;
      

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
            int count = 0;
            foreach (IPackageable e in pachet.elem_pachet)
            {
                if (e.GetType() == typeof(Produs))
                    count++;
                if (count == Produs.MaxPachet)
                    return false;
            }
            return true;
        }

    }
}