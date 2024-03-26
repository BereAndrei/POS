namespace entitati
{
    public class Serviciu : ProdusAbstract
    {
        public Serviciu(uint id, string? nume, string? codIntern) : base(id, nume, codIntern) { }
        public override string ToString() => "Serviciu: " + this.Nume + "[" + this.CodIntern + "]";
        public override string Descriere() => "Serviciu: " + this.Nume + "[" + this.CodIntern + "]";
        
        public override string AltaDescriere() => "Serviciu: " + base.AltaDescriere();       
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
            if (obj == null) return false;
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

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
