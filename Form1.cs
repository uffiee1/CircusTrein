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
        List<Animal> allAnimals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            bool VleesEter = rbVlees.Checked;
            Animal.GrootteTypes grootteTypes;

            if (rbDierGroot.Checked)
            {
                grootteTypes = Animal.GrootteTypes.Groot;
            }
            else if (rbDierMiddel.Checked)
            {
                grootteTypes = Animal.GrootteTypes.Middelgroot;
            }
            else
            {
                grootteTypes = Animal.GrootteTypes.Klein;
            }

            string name = txbxDierNaam.Text;
            Animal newAnimal = new Animal();
            allAnimals.Add(newAnimal);
            lbDierLijst.Items.Add(newAnimal);
        }


    }
}
