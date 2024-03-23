using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyApp.View;

namespace TravelAgencyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionVoyage gestionVoyage = new GestionVoyage();

            // Afficher la deuxième fenêtre
            gestionVoyage.Show();
        }
    }
}
