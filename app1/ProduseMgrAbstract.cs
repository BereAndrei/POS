using entitati;
namespace app1
{
    public abstract class ProduseAbstractMgr
    {
        protected const uint MAX_PRODUSE_ABSTRACTE = 100;
        protected static ProdusAbstract[] elemente = new ProdusAbstract[MAX_PRODUSE_ABSTRACTE];
        protected static int CountElemente { get; set; } = 0;
        public ProduseAbstractMgr() { }
        public bool compareToArray(ProdusAbstract other)
        {
            for (int i = 0; i < ProduseAbstractMgr.CountElemente; i++)
            {
                if (ProduseAbstractMgr.elemente[i]==other)
                    return true;
            }
            return false;
        }
        public abstract ProdusAbstract ReadElement(uint number);

        public void ReadElemente(uint count)
        {
            int start = CountElemente;
            for (int i = start; i < start + (int)count; i++)
            {
                ProdusAbstract? citit = ReadElement((uint)i);
                if (this.compareToArray(citit))
                    Console.WriteLine("Acest element exista deja!");
                else {
                    elemente[CountElemente] = citit;
                    CountElemente++;
                }
            }
        }

        public static ProdusAbstract? Contine(ProdusAbstract other)
        {
            for (int i = 0; i < ProduseAbstractMgr.CountElemente; i++)
            {
                if (ProduseAbstractMgr.elemente[i].Equals(other))
                    return elemente[i];
            }
            return null;
        }

        public static ProdusAbstract[] Cautare_nume(string? numep)
        {
            ProdusAbstract[] produse = new ProdusAbstract[MAX_PRODUSE_ABSTRACTE];
            int counter = 0;
            for (int i = 0; i < ProduseAbstractMgr.CountElemente; i++)
                {
                    if (ProduseAbstractMgr.elemente[i].Nume == numep)
                    {
                    produse[counter] = elemente[i];
                    counter++;
                    }
                }
            ProdusAbstract[] returned = new ProdusAbstract[counter];
            for (int i = 0; i < counter; i++)
            {
                returned[i] = produse[i];
            }
            return returned;
        }
        public static ProdusAbstract? Contine(string? numep)
        {
            for (int i = 0; i < ProduseAbstractMgr.CountElemente; i++)
            {
                if (ProduseAbstractMgr.elemente[i].Nume == numep)
                    return elemente[i];
            }
            return null;
        }




        public void Write2console()
        {
            for (uint i = 0; i < ProduseAbstractMgr.CountElemente; i++)
            {
                Console.WriteLine(ProduseAbstractMgr.elemente[i]);
            }
        }
    }
}
