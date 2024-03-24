using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelAgencyApp.View
{
    public partial class ModifierClientFormcs : Form
    {
        private Client client;
        public ModifierClientFormcs(Client client)
        {
            InitializeComponent();
            this.client = client;
            textBox1.Text = client.Nom;
            textBox2.Text = client.Prenom;
            textBox3.Text = client.Genre;
            textBox4.Text = client.NumeroTelephone;
            dateTimePicker1.Value = client.DateNaissance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Nom = textBox1.Text;
            client.Prenom = textBox2.Text;
            client.Genre = textBox3.Text;
            client.NumeroTelephone = textBox4.Text;
            client.DateNaissance = dateTimePicker1.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
