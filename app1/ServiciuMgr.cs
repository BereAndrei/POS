using entitati;
namespace app1
{
    public class ServiciuMgr : ProduseAbstractMgr
    {
    

        
        public override ProdusAbstract ReadElement(uint id)
        {
            Console.WriteLine("Introdu un serviciu");
            Console.Write("Numele:");
            String? Nume = Console.ReadLine();
            Console.Write("Codul intern:");
            String? CodIntern = Console.ReadLine();
            Serviciu serv = new Serviciu(id, Nume, CodIntern);
            return serv;
        }

        public static Serviciu ReadUnServicu()
        {
            Console.WriteLine("Introdu un serviciu");
            Console.Write("Numele:");
            String? Nume = Console.ReadLine();
            Console.Write("Codul intern:");
            String? CodIntern = Console.ReadLine();
            Serviciu serv = new Serviciu(0, Nume, CodIntern);
            return serv;
        }
        

        
        public void WriteServicii()
        {
            for (uint i = 0; i < ProduseAbstractMgr.CountElemente; i++)
            {
                Console.WriteLine(ProduseAbstractMgr.elemente[i]);
            }
        }
    }
}
