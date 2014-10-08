using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveConversions
    
{
    public class csItems
    {
        private String aktuellerName;

        private int aktuelleZone;

        public string aktuellerTyp;

        public string Typ
        {
            get { return aktuellerTyp; }
            set { aktuellerTyp = value; }
        }

        public int Zone
        {
            get { return aktuelleZone; }
            set { aktuelleZone = value; }
        }


        public string Name
        {
            get { return aktuellerName; }
            set { aktuellerName = value; }
        }

        private int aktuelleVF;

        public int VF
        {
            get { return aktuelleVF; }
            set { aktuelleVF = value; }
        }

        private int aktuellerPreis;

        public int Preis
        {
            get { return aktuellerPreis; }
            set { aktuellerPreis = value; }
        }

        public csItems(string name, int preis, int vf, int zone, string typ)
        {
            this.aktuellerName = name;
            this.aktuellerPreis = preis;
            this.aktuelleVF = vf;
            this.aktuelleZone = zone;
            this.aktuellerTyp = typ;

        }

        public csItems()
        {
            this.aktuellerName = "";
            this.aktuellerPreis = 0;
            this.aktuelleVF = 0;
            this.aktuelleZone = 0;
            this.aktuellerTyp = "Gemischt";
        }

        public string preufZone(int zone)
        {
            if (this.aktuelleZone < zone)
            {
                return "";
            }

            return "Item nicht in dieser Handelszone verfügbar";

        }



    }
}
