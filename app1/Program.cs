using entitati;
namespace app1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nr. produse:");
            uint nrProduse = uint.Parse(Console.ReadLine() ?? string.Empty);

            ProduseMgr produseMgr = new ProduseMgr();
            produseMgr.ReadElemente(nrProduse);
            Console.Write("Nr. Servicii:");
            uint nrServicii = uint.Parse(Console.ReadLine() ?? string.Empty);
            ServiciuMgr serviciuMgr = new ServiciuMgr();
            serviciuMgr.ReadElemente(nrServicii);
            serviciuMgr.Write2console();


            Console.WriteLine("Cauta un Produs");
            Produs pr = ProduseMgr.ReadUnProdus();
            ProdusAbstract? contine = ProduseAbstractMgr.Contine(pr);
            if (contine != null)
            {
                Console.WriteLine("Contine " + contine.ToString());
            }
        }
    }
}