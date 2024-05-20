using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace entitati
{
    [XmlInclude(typeof(Produs))]
    [XmlInclude(typeof(Pachet))]
    [XmlInclude(typeof(Serviciu))]
    public abstract class ProdusAbstract : IPackageable
    {
        public uint Id { get; set; }
        public string? Nume { get; set; }
        public string? CodIntern { get; set; }
        public int? Pret { get; set; }
        public string? Categorie { get; set; }
        public ProdusAbstract() { }
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
            return " Nume:" +this.Nume + " Cod Intern:" + this.CodIntern;
        }

        public abstract bool compareTo(ProdusAbstract other);
        public virtual bool canAddToPackage(Pachet pachet) => false;

        public void add2xml(XmlSerializer xs, StreamWriter sw)
        {
            
            xs.Serialize(sw, this);
            
        }
    }
}
