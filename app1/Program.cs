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

            /*
            Console.WriteLine("Cauta un Produs");
            Produs pr = ProduseMgr.ReadUnProdus();
            ProdusAbstract? contine = ProduseAbstractMgr.Contine(pr);
            if (contine is not null)
                Console.WriteLine("Contine " + contine.ToString());
            else
                Console.WriteLine("Nu contine " + pr.ToString());
            */

            Console.WriteLine("Cauta Produse/servicii dupa nume ");
            string? nume = Console.ReadLine();
            ProdusAbstract?[] gasite = ProduseAbstractMgr.Cautare_nume(nume);
            if (gasite.Length > 0)
            {
                for (int i = 0; i < gasite.Length; i++)
                    {
                        ProdusAbstract gasit = gasite[i];
                        Console.WriteLine("Contine " + gasit.ToString());
                    }
            }
            else
                Console.WriteLine("Nu contine " + nume);
        }
    }
}