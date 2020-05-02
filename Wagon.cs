using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        private List<Animal> _AnimalToWagon = new List<Animal>();
        private int _Capacity = 10;
        private bool _IsFull = false;

        public List<Animal> AnimalToWagon
        {
            get { return _AnimalToWagon; }
            set { _AnimalToWagon = value; }
        }

        public int Capacity
        {
            get { return _Capacity; }
            set { _Capacity = value; }
        }

        public bool IsFull
        {
            get { return _IsFull; }
            set { _IsFull = value; }
        }

        public Wagon(int capacity, bool isFull)
        {
            AnimalToWagon = AnimalToWagon;
            _Capacity = capacity;
            _IsFull = isFull;
        }

        public bool AddToWagon(Animal animal)
        {
            //Hier wordt animals toegevoegd in wagon(Alleen als CompatibilityCheck en CheckSize goedgekeurd wordt)
            if (!CompatibilityCheck(animal) || !sizeCheck(animal)) return false;
            //Na het toegevoegd animal wordt capaciteit van de wagon aangepast
            AnimalToWagon.Add(animal);
            animal.AnimalAdded = true;
            Capacity = Capacity - (int) animal.grootteTypes;
            return true;
        }

        private bool CompatibilityCheck(Animal animal)
        {
            //Hier wordt elke dier in wagon gecontroleerd of er zelfde type en soort in zit(Alleen geldig voor VleesEter)
            return AnimalToWagon.All(animalCheck => (animalCheck.grootteTypes > animal.grootteTypes 
                                                       || animal.animalTypes != AnimalTypes.VleesEter) 
                                                      && (animalCheck.animalTypes != AnimalTypes.VleesEter 
                                                          || animalCheck.grootteTypes < animal.grootteTypes));
        }

        private bool sizeCheck(Animal animal)
        {
            //Hier wordt de animal gecontroleerd welke grootte het is
            return Capacity - animal.grootteTypes >= 0;
        }

        public override string ToString()
        {
            return $"Wagon, {Capacity}";
        }
    }
}
