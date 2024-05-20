using System.Xml;
using System.Xml.Serialization;
namespace entitati
{
    [Serializable]
    public class Serviciu : ProdusAbstract
    {
        public Serviciu(uint id, string? nume, string? codIntern, int? pret, string? categorie) : base(id, nume, codIntern, pret, categorie) { }
        public Serviciu() { }
        public override string ToString() => "Serviciu: " + " Nume:" + this.Nume + " Cod Intern:" + this.CodIntern + " Pret:" + this.Pret + " Categorie:" + this.Categorie;
        public override string Descriere()
        {
            return "Serviciu: " + " Nume:" + this.Nume + " Cod Intern:" + this.CodIntern + " Pret:" + this.Pret + " Categorie:" + this.Categorie;
        }
        public override string AltaDescriere()
        {
            return "Serviciu:" + base.AltaDescriere() + " Pret:" + this.Pret + " Categorie:" + this.Categorie;
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
            int count = 0;
            foreach (IPackageable e in pachet.elem_pachet)
            {
                if (e.GetType() == typeof(Serviciu))
                    count++;
                if (count == Pachet.MaxServicii)
                    return false;
            }
            return true;
        }
        

    }
}
