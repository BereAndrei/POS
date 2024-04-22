using entitati;
using System.Collections.Generic;
using System.Xml;

namespace app1
{
    public abstract class ProduseAbstractMgr
    {
        protected static List<ProdusAbstract> elemente = new List<ProdusAbstract>();
        public ProduseAbstractMgr() { }
        public static void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\Elemente.xml");
            XmlNodeList lista_noduri = doc.SelectNodes("/elemente/Produs");
            foreach (XmlNode nod in lista_noduri)
            {
                string? nume = nod["Nume"].InnerText;
                string? codIntern = nod["CodIntern"].InnerText;
                string? producator = nod["Producator"].InnerText;
                int? pret = Convert.ToInt32((nod["Pret"].InnerText));
                string? categorie = nod["Categorie"].InnerText;
                elemente.Add(new Produs((uint)elemente.Count + 1, nume, codIntern,
                producator, pret, categorie));
            }
            XmlNodeList lista_noduri2 = doc.SelectNodes("/elemente/Serviciu");
            foreach (XmlNode nod in lista_noduri2)
            {
                string? nume = nod["Nume"].InnerText;
                string? codIntern = nod["CodIntern"].InnerText;
                int? pret = Convert.ToInt32(nod["Pret"].InnerText);
                string? categorie = nod["Categorie"].InnerText;
                elemente.Add(new Serviciu((uint)elemente.Count + 1, nume, codIntern, pret, categorie));
            }
        }
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
