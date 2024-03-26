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
        public virtual string AltaDescriere()
        {
            return this.Nume + "[" + this.CodIntern + "]";
        }

        

        public abstract bool compareTo(ProdusAbstract other);

        
    }
}
