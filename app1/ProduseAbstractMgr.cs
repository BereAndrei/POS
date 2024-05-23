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

        public void Write2console()
        {
            foreach (ProdusAbstract element in elemente)
            {
                Console.WriteLine(element);
            }
        }
        public abstract ProdusAbstract ReadElement(uint number);
        public List<ProdusAbstract> filtreaza(List<ProdusAbstract> elemente, ICriteriu criteriu)
        {
            FiltrareCriteriu filtrareCriteriu = new FiltrareCriteriu();
            List<ProdusAbstract> ret = filtrareCriteriu.Filtrare(elemente, criteriu);
            return ret;
        }

        public List<ProdusAbstract> filtreaza(List<ProdusAbstract> elemente, List<ICriteriu> criteriu)
        {
            FiltrareCriteriu filtrareCriteriu = new FiltrareCriteriu();
            List<ProdusAbstract> ret = new List<ProdusAbstract>(elemente.Capacity);
            ret.AddRange(elemente); 
            foreach(ICriteriu crit in criteriu)
                ret = filtrareCriteriu.Filtrare(ret, crit);
            return ret; 
        }


        public void save2xml(string? filename)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<ProdusAbstract>));
            StreamWriter sw = new StreamWriter(filename + ".xml");
            xs.Serialize(sw, elemente);
            sw.Close();
        }

        public static void loadxml(string? filename)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<ProdusAbstract>));
            FileStream fs = new FileStream(filename + ".xml", FileMode.Open);
            XmlReader reader = new XmlTextReader(fs);
            elemente = (List<ProdusAbstract>)xs.Deserialize(reader);           
            fs.Close();
        }
        }
}
