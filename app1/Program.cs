using entitati;
namespace app1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProduseMgr produseMgr = new ProduseMgr();
            ServiciuMgr serviciuMgr = new ServiciuMgr();
            PacheteMgr pacheteMgr = new PacheteMgr();
            ProduseMgr.InitListafromXML();
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



        }
    }
}