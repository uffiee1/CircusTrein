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

            //Als er niks ingecheked is bij dieren grootte dan maakt automatisch 0 punten bij de dieren lijst aan.
            MessageBox.Show("Selecteer dier grootte");
            return GrootteTypes.Geen;
            
            //Als er niks ingecheked is bij dieren grootte maakt het automatisch een kleine dier aan.
            //return GrootteTypes.Klein;
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            bool VleesEter = rbVlees.Checked;
          
            string name = txbxDierNaam.Text;
            Animal newAnimal = new Animal(getGrootteTypes(), VleesEter, name);
            listAnimals.Add(newAnimal);
            lbDierLijst.Items.Add(newAnimal);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            //Hier wordt de wagon lijst verwijderd en update als er dieren toegevoegd worden
            train.Wagons.Clear();
            train.FillWagons(listAnimals);
            
            //Vul listboxes
            lbDierLijst.Items.Clear();
            foreach (Animal item in listAnimals)
            {
                lbDierLijst.Items.Add(item);
            }
            lbTrein.Items.Clear();
            foreach (Wagon currentWagon in train.Wagons)
            {
                lbTrein.Items.Add(currentWagon);
            }
        }
    }
}
