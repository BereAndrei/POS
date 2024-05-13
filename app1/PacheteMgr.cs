using entitati;

namespace app1
{
    internal class PacheteMgr : ProduseAbstractMgr
    {
        public override ProdusAbstract ReadElement(uint id)
        {
            Console.WriteLine("Introdu un Pachet");
            Console.Write("Numele:");
            String? Nume = Console.ReadLine();
            Console.Write("Codul intern:");
            String? CodIntern = Console.ReadLine();
            Console.Write("Categoria:");
            String? Categorie = Console.ReadLine();
            Pachet pac = new Pachet(id, Nume, CodIntern, Categorie);

            ProduseMgr produseMgr = new ProduseMgr();
            ServiciuMgr serviciuMgr = new ServiciuMgr();


            Console.Write("Nr. produse:");
            uint nrProduse = uint.Parse(Console.ReadLine() ?? string.Empty);
            for (int i = 0; i < (int)nrProduse; i++)
            {
                ProdusAbstract add = produseMgr.ReadElement((uint)pac.elem_pachet.Count);
                pac.adaugaPachet(add);

            }


            Console.Write("Nr. Servicii:");
            uint nrServicii = uint.Parse(Console.ReadLine() ?? string.Empty);
            for (int i = 0; i < (int)nrServicii; i++)
            {
                ProdusAbstract add = serviciuMgr.ReadElement((uint)pac.elem_pachet.Count);
                pac.adaugaPachet(add);

            }
            return pac;
        }


        public IPackageable? citesteUnElement(Pachet pac)
        {
            Console.WriteLine("1 - Produse \n 2 - Servicii");
            int choice = Convert.ToInt32(Console.ReadKey());
            ProdusAbstract eleme;
            ProduseMgr produseMgr = new ProduseMgr();
            ServiciuMgr serviciuMgr = new ServiciuMgr();
            if (choice == 1)
            {
                eleme = produseMgr.ReadElement((uint)pac.elem_pachet.Count);
                return eleme;

            }

            if (choice == 2)
            {
                eleme = serviciuMgr.ReadElement((uint)pac.elem_pachet.Count);
                return eleme;
            }
            return null;

        }

       
        public List<ProdusAbstract> listaPachete()
        {
            List<ProdusAbstract> ret = new List<ProdusAbstract>();
            foreach (IPackageable p in elemente)
                if (p.GetType() == typeof(Pachet))
                {
                    ((Pachet)p).calculPret();
                    ret.Add((Pachet)p);
                }

            ret.Sort((x, y) => Nullable.Compare(x.Pret, y.Pret));
            return ret;
        }

        public void outPachete(List<ProdusAbstract> l)
        {
            foreach (ProdusAbstract p in l)
                Console.WriteLine(p.ToString());
        }


        public void adaugaInPachet(Pachet p, IPackageable elem)
        {
            p.adaugaPachet(elem);
            ((Pachet)p).calculPret();
        }







    }
}
