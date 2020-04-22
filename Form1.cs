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

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            bool VleesEter = rbVlees.Checked;
          
            string name = txbxDierNaam.Text;
            Animal newAnimal = new Animal(getGrootteTypes(), VleesEter, name);
            listAnimals.Add(newAnimal);
            lbDierLijst.Items.Add(newAnimal);
        }


    }
}
