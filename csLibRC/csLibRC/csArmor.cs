using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveConversions
{
    class csArmor : csItems
    {
        private string _armorClass;

        public string armorClass
        {
            get { return _armorClass; }
            set { _armorClass = value; }
        }

        private int _ballistic;

        public int ballistic
        {
            get { return _ballistic; }
            set { _ballistic = value; }
        }

        private int _impact;

        public int impact
        {
            get { return _impact; }
            set { _impact = value; }
        }

        private int _fire;

        public int fire
        {
            get { return _fire; }
            set { _fire = value; }
        }

        private int _electro;

        public int electro
        {
            get { return _electro; }
            set { _electro = value; }
        }

        private int _chemic;

        public int chemic
        {
            get { return _chemic; }
            set { _chemic = value; }
        }

        private int _rad;

        public int rad
        {
            get { return _rad; }
            set { _rad = value; }
        }

        private int _psi;

        public int psi
        {
            get { return _psi; }
            set { _psi = value; }
        }

        private int _modCap;

        public int modCap
        {
            get { return _modCap; }
            set { _modCap = value; }
        }

        public List<string> mods = new List<string>();


        public csArmor(string Rüstungsklasse, int Ballistisch, int Chemisch, int Elektro, int Feuer, int Strahlung, int Stoß, int Slots, int Psi, string name, int preis, int vf, int zone, string typ)
        {
            this._armorClass = Rüstungsklasse;
            this._ballistic = Ballistisch;
            this._chemic = Chemisch;
            this._electro = Elektro;
            this._fire = Feuer;
            this._impact = Stoß;
            this._modCap = Slots;
            this._psi = Psi;
            this._rad = Strahlung;
            this.Name = name;
            this.Preis = preis;
            this.VF = vf;
            this.Zone = zone;
            this.Typ = typ;

        }
        
        
        
        
        
        
    }
}
