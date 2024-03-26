using entitati;
namespace app1
{
    public class ProduseMgr : ProduseAbstractMgr
    {

        public override ProdusAbstract ReadElement(uint id)
        {
            Console.WriteLine("Introdu un produs");
            Console.Write("Numele:");
            String? Nume = Console.ReadLine();
            Console.Write("Codul intern:");
            String? CodIntern = Console.ReadLine();
            Console.Write("Producator:");
            string? Producator = Console.ReadLine();
            Produs prod = new Produs(id, Nume, CodIntern, Producator);
            return prod;
        }
        public static Produs ReadUnProdus()
        {
            Console.WriteLine("Introdu un produs");
            Console.Write("Numele:");
            String? Nume = Console.ReadLine();
            Console.Write("Codul intern:");
            String? CodIntern = Console.ReadLine();
            Console.Write("Producator:");
            string? Producator = Console.ReadLine();
            Produs prod = new Produs(0, Nume, CodIntern, Producator);
            return prod;
        }
        
        public void WriteProduse()
        {
            for(uint i = 0; i < ProduseAbstractMgr.CountElemente; i++)
            {
                Console.WriteLine(elemente[i]);
            }
        }


    }
}
