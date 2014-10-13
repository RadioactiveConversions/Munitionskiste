using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveConversions
{
    class csRanged : csItems
    {
        private string _cal;

        public string cal
        {
            get { return _cal; }
            set { _cal = value; }
        }

        private string _group;

        public string group
        {
            get { return _group; }
            set { _group = value; }
        }

        private string _modus;

        public string modus
        {
            get { return _modus; }
            set { _modus = value; }
        }

        private int _rc;

        public int rc
        {
            get { return _rc; }
            set { _rc = value; }
        }

        private int _magsize;

        public int magsize
        {
            get { return _magsize; }
            set { _magsize = value; }
        }

        public List<string> mods = new List<string>();

        private int _modCap;

        public int modCap
        {
            get { return _modCap; }
            set { _modCap = value; }
        }


        public csRanged(string Kaliber, string Gruppe, string Modus, int RK, int Magazin, int Modlimit, string name, int preis, int vf, int zone, string typ)
        {
            this._cal = Kaliber;
            this._group = Gruppe;
            this._magsize = Magazin;
            this._modCap = Modlimit;
            this._modus = Modus;
            this._rc = RK;
            this.Name = name;
            this.Preis = preis;
            this.VF = vf;
            this.Zone = zone;
            this.Typ = typ;
        
        }
        
        
        
    }
}
