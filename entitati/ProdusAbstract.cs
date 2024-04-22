using System.Reflection.Metadata.Ecma335;

namespace entitati
{
    public abstract class ProdusAbstract : IPackageable
    {
        public uint Id { get; set; }
        public string? Nume { get; set; }
        public string? CodIntern { get; set; }
        public int? Pret { get; set; }
        public string? Categorie { get; set; }

        public ProdusAbstract(uint id, string? nume, string? codIntern, int? pret, string? categorie)
        {
            Id = id;
            Nume = nume;
            CodIntern = codIntern;
            Pret = pret;
            Categorie = categorie;
        }
        public abstract string Descriere();
        public virtual string AltaDescriere()
        {
            return this.Nume + "[" + this.CodIntern + "]";
        }

        public abstract bool compareTo(ProdusAbstract other);
        public virtual bool canAddToPackage(Pachet pachet) => false;
    }
}
