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
            Console.Write("Pretul:");
            int? Pret = Convert.ToInt32(Console.ReadLine());
            Console.Write("Categoria:");
            String? Categorie = Console.ReadLine();
            return new Serviciu(id, Nume, CodIntern, Pret, Categorie);
        }


        /*
        public void WriteServicii()
        {
            for (uint i = 0; i < ProduseAbstractMgr.CountElemente; i++)
            {
                Console.WriteLine(ProduseAbstractMgr.elemente[i]);
            }
        }
        */
    }
}
