using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        public List<Animal> Animals = new List<Animal>();

        private int _Plaats;


        public int Plaats
        {
            get { return this._Plaats; }
            private set{ _Plaats = 10; }
        }

        private Animal.GrootteTypes GrootsteVleeseter()
        {
            List<Animal> VleesEterList = Animals.Where(Animal => Animal.VleesEter).ToList();

            if(VleesEterList.Count == 0)
            {
                return Animal.GrootteTypes.Geen;
            } else
            {
                return VleesEterList.First().Grootte;
            }
        }

        public bool AddAnimal(Animal newAnimal)
        {
            //Check of wagon nog ruimte heeft en het dier in de wagon mag
            if (newAnimal.Grootte > GrootsteVleeseter() && (int) newAnimal.Grootte <= Plaats)
            {
                Animals.Add(newAnimal);
                Plaats = 10 - Animals.Sum(Animal => (int) Animal.Grootte);
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
