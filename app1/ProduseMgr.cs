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
            Console.Write("Pretul:");
            int? Pret = Convert.ToInt32(Console.ReadLine());
            Console.Write("Categoria:");
            String? Categorie = Console.ReadLine();
            Produs prod = new Produs(id, Nume, CodIntern, Producator, Pret, Categorie);
            return prod;
        }


        /*
        public void WriteProduse()
        {
            for(uint i = 0; i < ProduseAbstractMgr.CountElemente; i++)
            {
                Console.WriteLine(elemente[i]);
            }
        }

        */
    }
}
