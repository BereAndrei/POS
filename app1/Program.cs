using entitati;
namespace app1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String? FISIER_SALVARE = "salvat_arr";
            ProduseMgr produseMgr = new ProduseMgr();
            ServiciuMgr serviciuMgr = new ServiciuMgr();
            PacheteMgr pacheteMgr = new PacheteMgr();
            ProduseMgr.InitListafromXML2(FISIER_SALVARE);
            Console.Write("Nr. produse:");
            uint nrProduse = uint.Parse(Console.ReadLine() ?? string.Empty);


            produseMgr.ReadElemente(nrProduse);
            Console.Write("Nr. Servicii:");
            uint nrServicii = uint.Parse(Console.ReadLine() ?? string.Empty);


            Console.Write("Nr. Pachete:");
            uint nrPachete = uint.Parse(Console.ReadLine() ?? string.Empty);
            pacheteMgr.ReadElemente(nrPachete);


            //pacheteMgr.outPachete(pacheteMgr.listaPachete());

            serviciuMgr.ReadElemente(nrServicii);
            serviciuMgr.Write2console();


            ICriteriu criteriu = new CriteriuCategorie("Tehnologia Informatiei");
            serviciuMgr.filtr(criteriu);






            serviciuMgr.save2xml(FISIER_SALVARE);

        }
    }
}