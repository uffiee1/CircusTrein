using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Train
    {
        private List<Animal> _Animals = new List<Animal>();
        private List<Wagon> _Wagons = new List<Wagon>();

        public List<Animal> Animals
        {
            get { return _Animals; }
            set { _Animals = value; }
        }

        public List<Wagon> Wagons
        {
            get { return _Wagons; }
            set { _Wagons = value; }
        }

        public bool AddAnimal(string name, GrootteTypes size, AnimalTypes type)
        {
            Animal animal = new Animal(name, size, type);
            Animals.Add(animal);

            //Hier wordt bij elke wagon gecontroleerd of animal toegevoegd kan worden
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.AddToWagon(animal))
                {
                    return true;
                }
            }
            //Als er geen animal toegevoegd kan worden ga naar AnimalToNewWagon methode
            if (animal.AnimalAdded) return false;
            AnimalToNewWagon(animal);
            return false;
        }

        //Hier wordt een een nieuwe wagon aangemaakt en voegt het animal toe
        private void AnimalToNewWagon(Animal animal)
        {
            Wagon wagon = new Wagon(10, false);
            wagon.AddToWagon(animal);
            Wagons.Add(wagon);
        }

        public Train()
        {
        }


    }
}
