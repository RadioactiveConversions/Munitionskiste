using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveConversions
{
    class csMed : csItems
    {
        private string _effect;

        public string effect
        {
            get { return _effect; }
            set { _effect = value; }
        }

        private string _sideEffect;

        public string sideEffect
        {
            get { return _sideEffect; }
            set { _sideEffect = value; }
        }

        private string _duration;

        public string duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public csMed(string Wirkung, string Nebenwirkung, string Dauer, string name, int preis, int vf, int zone, string typ)
        {
            this._duration = Dauer;
            this._effect = Wirkung;
            this._sideEffect = Nebenwirkung;
            this.Name = name;
            this.Preis = preis;
            this.VF = vf;
            this.Zone = zone;
            this.Typ = typ;
        }
    }
}
