namespace entitati
{
    public class Produs : ProdusAbstract
    {
        public string? Producator { get; set; }

        public Produs(uint id, string? nume, string? codIntern, string? producator):base(id, nume, codIntern) => Producator = producator;
        public override string ToString() => "Produs: " + this.Nume + "[" + this.CodIntern + "]" + this.Producator;
        
        public override string Descriere() => "Produs: " + this.Nume + "[" + this.CodIntern + "]" + this.Producator;
        public override string AltaDescriere() => "Produse: " + base.AltaDescriere() + this.Producator;

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (this.GetType() == obj.GetType()) {
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
        {   if(this.GetType() == other.GetType()) 
            if (this.Nume == other.Nume && this.CodIntern == other.CodIntern && this.Producator == ((Produs)other).Producator)   
                return true;
            
            return false;
        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}