using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public enum GrootteTypes
    {
        Groot = 5,
        Middelgroot = 3,
        Klein = 1
    }

    public enum AnimalTypes
    {
        PlantenEter,
        VleesEter
    }

    public class Animal
    {
        public GrootteTypes grootteType { get; }
        public AnimalTypes animalType { get; }

        private string _Naam;
        private bool _AnimalAdded;

        public string Naam
        {
            get { return _Naam; }
            set { _Naam = value; }
        }

        public bool AnimalAdded
        {
            get { return _AnimalAdded; }
            set { _AnimalAdded = value; }
        }

        public Animal(string name, GrootteTypes size, AnimalTypes type)
        {
            this._Naam = name;
            this.grootteType = size;
            this.animalType = type;
        }

        public override string ToString()
        {
            return $"{Naam}, {grootteType}, {animalType}";
        }
    }
}
