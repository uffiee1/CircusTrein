using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        List<Animal> listAnimals = new List<Animal>();
        private readonly Train train = new Train();

        public Form1()
        {
            InitializeComponent();
        }

        private GrootteTypes getGrootteTypes()
        {
            if (rbDierGroot.Checked) return GrootteTypes.Groot;
            if (rbDierMiddel.Checked) return GrootteTypes.Middelgroot;
            if (rbDierKlein.Checked) return GrootteTypes.Klein;

            //Als er niks ingecheked is bij dieren grootte maakt het automatisch een kleine dier aan.
            return GrootteTypes.Klein;
        }

        private AnimalTypes getAnimalTypes()
        {
            if (rbPlant.Checked) return AnimalTypes.PlantenEter;
            if (rbVlees.Checked) return AnimalTypes.VleesEter;

            return AnimalTypes.PlantenEter;
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            string name = txbxDierNaam.Text;
            Animal newAnimal = new Animal(name, getGrootteTypes(), getAnimalTypes());
            listAnimals.Add(newAnimal);

            lbAnimal.Items.Add(newAnimal);
        }

        public void updateTrain()
        {
            
            lbAnimal.Items.Clear();
            lbTrain.Items.Clear();
            foreach (Animal animal in train.Animals)
            {
                lbAnimal.Items.Add(animal);
            }
            foreach (Wagon wagon in train.Wagons)
            {
                lbTrain.Items.Add(wagon);
            }
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            try
            {
                //Create and add an animal to a wagon
                if (train.AddAnimal(txbxDierNaam.Text, getGrootteTypes(), getAnimalTypes()))
                {
                    updateTrain();
                }
                //Geef aan dat er een nieuwe wagon gemaakt wordt
                else
                {
                    MessageBox.Show("Nieuwe wagon is aangemaakt");
                    updateTrain();
                }
            }
            
            //Wanneer velden leeg zijn voorkomt dat programma crasht
            catch
            {
                MessageBox.Show("Er is iets misgegaan. Heeft u alle velden ingevuld?");
            }
        }
    }
}
