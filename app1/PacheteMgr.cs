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

        public void autoPricePachet(Pachet pac)
        {
            int? pret = 0;
            foreach (IPackageable e in pac.elem_pachet)
            {
                if (e.GetType() == typeof(ProdusAbstract))
                {
                    ProdusAbstract eleme = (ProdusAbstract)e;
                    pret += eleme.Pret;
                }
            }
            pac.Pret = pret;
        }

        public List<ProdusAbstract> listaPachete()
        {
            List<ProdusAbstract> ret = new List<ProdusAbstract>();
            foreach (IPackageable p in elemente)
                if (p.GetType() == typeof(Pachet))
                {
                    autoPricePachet(p as Pachet);
                    ret.Add(p as Pachet);
                }

            ret.Sort((x, y) => Nullable.Compare(x.Pret, y.Pret));
            return ret;
        }

        public void outPachete(List<ProdusAbstract> l)
        {
            foreach (ProdusAbstract p in l)
                Console.WriteLine(p.ToString());
        }


        public void adaugaInPachet(Pachet pac, IPackageable elem)
        {
            Pachet eleme = elem as Pachet;
            eleme.calculPret();
            pac.adaugaPachet(elem);
        }







    }
}
