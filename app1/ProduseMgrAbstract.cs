using entitati;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace app1
{
    public abstract class ProduseAbstractMgr
    {
        public static List<ProdusAbstract> elemente = new List<ProdusAbstract>();

        public ProduseAbstractMgr() { }
        
        public bool compareToArray(ProdusAbstract other)
        {
            foreach (ProdusAbstract element in elemente)
            {
                if (element.Equals(other))
                    return true;
            }
            return false;
        }
        public void ReadElemente(uint count)
        {
            for (int i = 0; i < (int)count; i++)
            {
                ProdusAbstract? citit = ReadElement((uint)i);
                if (this.compareToArray(citit))
                    Console.WriteLine("Acest element exista deja!");
                else
                    elemente.Add(citit);
            }
        }
        public static ProdusAbstract Contine(ProdusAbstract other)
        {
            if (elemente.Contains(other))
                return other;
            return null;
        }
        public static List<ProdusAbstract> Continere(ProdusAbstract other)
        {
            List<ProdusAbstract> interogare_linq = (from elem in elemente where elem.Categorie == "Tehnologia Informatiei" orderby elem.Nume select elem).ToList();

            return interogare_linq;
        }
        public void Write2console()
        {
            foreach (ProdusAbstract element in elemente)
            {
                Console.WriteLine(element);
            }
        }
        public abstract ProdusAbstract ReadElement(uint number);


        public void filtr(ICriteriu criteriu)
        {
            FiltrareCriteriu filtrareCriteriu = new FiltrareCriteriu();
            Console.WriteLine("Elemente filtrate :");
            List<ProdusAbstract> ret = filtrareCriteriu.Filtrare(elemente, criteriu);
            foreach (ProdusAbstract element in ret)
                Console.WriteLine(element);
        }

        public void save2xml(string? filename)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<ProdusAbstract>));
            StreamWriter sw = new StreamWriter(filename + ".xml");
            xs.Serialize(sw, elemente);
            sw.Close();
        }

        public static void InitListafromXML2(string? filename)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<ProdusAbstract>));
            FileStream xr = new FileStream(filename + ".xml", FileMode.Open);
            XmlReader reader = new XmlTextReader(xr);
            elemente = (List<ProdusAbstract>)xs.Deserialize(reader);
            
            xr.Close();

        }


            /*
               public static ProdusAbstract[] Continee(ProdusAbstract other)
               {
                   ProdusAbstract[] produse = new ProdusAbstract[100];
                   int counter = 0;
                   for (int i = 0; i < ProduseAbstractMgr.CountElemente; i++)
                       {
                           if (ProduseAbstractMgr.elemente[i].Equals(other))
                           {
                           produse[counter] = elemente[i];
                           counter++;
                           }
                       }
                   return produse;
               }
               public static ProdusAbstract Contine(string? numep)
               {
                   for (int i = 0; i < ProduseAbstractMgr.CountElemente; i++)
                   {
                       if (ProduseAbstractMgr.elemente[i].Nume == numep)
                           return elemente[i];
                   }
                   return null;
               }
            */
        }
}
