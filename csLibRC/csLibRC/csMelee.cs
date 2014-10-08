using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveConversions
{
    class csMelee : csItems
    {
        private int _damage;

        public int damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        private string _group;

        public string group
        {
            get { return _group; }
            set { _group = value; }
        }

        private string _dmgType;

        public string dmgType
        {
            get { return _dmgType; }
            set { _dmgType = value; }
        }


        public csMelee(string Gruppe, int Schaden, string Schadensart, string name, int preis, int vf, int zone, string typ)
        {
            this._damage = Schaden;
            this._dmgType = Schadensart;
            this._group = Gruppe;
            this.Name = name;
            this.Preis = preis;
            this.VF = vf;
            this.Zone = zone;
            this.Typ = typ;
        }

    }
}
