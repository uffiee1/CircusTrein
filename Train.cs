using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Train
    {
        public List<Wagon> Wagons = new List<Wagon>();

        public Wagon AnimalToNewWagon(Animal animal)
        {
            Wagon newWagon = new Wagon();

            newWagon.AddAnimal(animal);

            Wagons.Add(newWagon);

            return newWagon;
        }

        public List<Animal> SortAnimals(List<Animal> disorderedAnimals)
        {
            //Zet vleeseters eerst en het hoogste punten daarna sorteer van groot naar klein
            return disorderedAnimals.OrderByDescending(Animal => Animal.VleesEter).ThenByDescending(Animal => (int)Animal.Grootte).ToList();
        }

        public void FillWagons(List<Animal> allAnimals)
        {
            allAnimals = SortAnimals(allAnimals);

            foreach (Animal currentAnimal in allAnimals)
            {
                if (currentAnimal.VleesEter)
                {
                    AnimalToNewWagon(currentAnimal);
                }
                else
                {
                    bool wagonCapacity = false;

                    foreach(Wagon currentWagon in Wagons)
                    { 
                        wagonCapacity = currentWagon.AddAnimal(currentAnimal);
                        if (wagonCapacity) break;
                    }

                    if (!wagonCapacity)
                    {
                        AnimalToNewWagon(currentAnimal);
                    }
                }
            }
        }
    }
}
