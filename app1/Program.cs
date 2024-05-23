using entitati;
using System.Xml.Linq;
namespace app1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produs.MaxPachet = 3;
            Serviciu.MaxPachet = 1;
            String? FISIER_SALVARE = "salvat_arr";
            ProduseMgr produseMgr = new ProduseMgr();
            ServiciuMgr serviciuMgr = new ServiciuMgr();
            
            ProduseMgr.loadxml(FISIER_SALVARE);
            Console.Write("Nr. produse:");
            uint nrProduse = uint.Parse(Console.ReadLine() ?? string.Empty);


            produseMgr.ReadElemente(nrProduse);
            Console.Write("Nr. Servicii:");
            uint nrServicii = uint.Parse(Console.ReadLine() ?? string.Empty);
            serviciuMgr.ReadElemente(nrServicii);

            PacheteMgr pacheteMgr = new PacheteMgr();
            Console.Write("Nr. Pachete:");
            uint nrPachete = uint.Parse(Console.ReadLine() ?? string.Empty);
            pacheteMgr.ReadElemente(nrPachete);


            //pacheteMgr.outPachete(pacheteMgr.listaPachete());

            
            serviciuMgr.Write2console();



           

            List<ICriteriu> crit = new List<ICriteriu>();
            crit.Add(new CriteriuCategorie("Tehnologia Informatiei"));
            crit.Add(new CriteriuPretMin(0));
            List<ProdusAbstract> ret = serviciuMgr.filtreaza(ServiciuMgr.elemente, crit);
            Console.WriteLine("\n\n\nElementele returnate filtrarii sunt: \n");
            foreach (ProdusAbstract produsAbstract in ret)
                Console.Write(produsAbstract.ToString() + "\n");




            serviciuMgr.save2xml(FISIER_SALVARE);

        }
    }
}