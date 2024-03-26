namespace entitati
{
    public abstract class ProdusAbstract
    {
        public uint Id { get; set; }
        public string? Nume { get; set; }
        public string? CodIntern { get; set; }

        public ProdusAbstract(uint id, string? nume, string? codIntern)
        {
            Id = id;
            Nume = nume;
            CodIntern = codIntern;
        }
        public abstract string Descriere();
        public virtual string AltaDescriere() => this.Nume + "[" + this.CodIntern + "]";
        public abstract bool compareTo(ProdusAbstract other);
        public static bool operator ==(ProdusAbstract e1, ProdusAbstract e2) => e1.Equals(e2);
        public static bool operator !=(ProdusAbstract e1, ProdusAbstract e2) => !e1.Equals(e2);

        public override bool Equals(object? obj)
        {   
            if (ReferenceEquals(null, obj)) return false; 
            return obj is ProdusAbstract &&
            base.Equals(obj);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
