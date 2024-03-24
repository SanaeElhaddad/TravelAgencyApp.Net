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
using TravelAgencyApp.Repository;

namespace TravelAgencyApp.View
{
    public partial class GestionClient : Form
    {
        private UnitOfWork unitOfWork;
        private IEnumerable<Client> allClients;
        public GestionClient()
        {
            InitializeComponent();
            this.Size = new Size(1390, 570);
            this.StartPosition = FormStartPosition.CenterScreen;
            unitOfWork = new UnitOfWork();
            LoadClients();
        }
        private void LoadClients()
        {
            allClients = (IEnumerable<Client>)unitOfWork.ClientRepository.GetAll();
            dataGridView1.DataSource = allClients;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();

            IEnumerable<Client> filteredClients = allClients;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                filteredClients = allClients
                    .Where(client => client.Nom.ToLower().StartsWith(searchText));
            }

            dataGridView1.DataSource = filteredClients.ToList();
        }
        private void BtnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Client selectedClient = (Client)selectedRow.DataBoundItem;

                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Confirmation de suppression", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    unitOfWork.ClientRepository.Delete(selectedClient.ClientId);
                    unitOfWork.Save();

                    LoadClients();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.", "Aucun client sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Client selectedClient = (Client)selectedRow.DataBoundItem;

                ModifierClientFormcs modifierForm = new ModifierClientFormcs(selectedClient);

                DialogResult result = modifierForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    unitOfWork.ClientRepository.Update(selectedClient);
                    unitOfWork.Save();

                    LoadClients();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier.", "Aucun client sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
