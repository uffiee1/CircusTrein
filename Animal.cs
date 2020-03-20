using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Dieren
    {
        public enum GrootteTypes
        {
            Groot = 5,
            Middelgroot = 3,
            Klein = 1
        }

        private GrootteTypes Grootte;

        private string _Naam;
        private bool _VleesEter;

        public string Naam
        {
            get { return this._Naam; }
            set { _Naam = value; }
        }
        public bool VleesEter
        {
            get { return this._VleesEter; }
            set { _VleesEter = value; }
        }

        public void Dier(GrootteTypes grootte, bool VleesEtende, string naam)
        {
            Grootte = grootte;
            VleesEter = VleesEtende;
            Naam = naam;
        }

        
    }
}
