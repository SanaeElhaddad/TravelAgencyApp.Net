using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyApp.Repository;

namespace TravelAgencyApp.View
{
    public partial class GestionReservation : Form
    {
        private List<object> allReservations;
        private  UnitOfWork unitOfWork;
        public GestionReservation()
        {
            InitializeComponent();
            this.Size = new Size(1390, 570);
            this.StartPosition = FormStartPosition.CenterScreen;
            unitOfWork = new UnitOfWork();
        }
        private void LoadReservations()
        {
            var reservations = unitOfWork.ReservationRepository.GetAll().Select(r => new
            {
                r.ReservationId,
                Voyage = r.Voyage.Titre, // Afficher le nom du voyage
                Client = r.Client.Nom, // Afficher le nom du client
                r.DateReservation
            }).ToList();

            dataGridView1.DataSource = reservations;
        }

        private void GestionReservation_Load(object sender, EventArgs e)
        {
            LoadReservations();
            LoadVoyageNames();
            comboBox1.SelectedIndex = 0;
            textBox1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadVoyageNames()
        {
            var voyageNames = unitOfWork.VoyageRepository.GetAll().Select(v => v.Titre).ToList(); // Récupérer tous les noms de voyage

            // Ajouter "All" comme première option dans la liste des noms de voyage
            voyageNames.Insert(0, "All");

            comboBox1.DataSource = voyageNames; // Lier les noms de voyage au ComboBox
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVoyageName = comboBox1.SelectedItem.ToString();

            if (selectedVoyageName == "All")
            {
                LoadReservations(); // Charger toutes les réservations
            }
            else
            {
                FilterReservations(selectedVoyageName);
            }

            CountReservations(selectedVoyageName);
        }
        private void FilterReservations(string selectedVoyageName)
        {
            var filteredReservations = unitOfWork.ReservationRepository.GetAll()
                .Where(r => selectedVoyageName == "All" || r.Voyage.Titre == selectedVoyageName)
                .Select(r => new
                {
                    r.ReservationId,
                    Voyage = r.Voyage.Titre, // Afficher le nom du voyage
                    Client = r.Client.Nom, // Afficher le nom du client
                    r.DateReservation
                }).ToList();

            dataGridView1.DataSource = filteredReservations;
        }
        private void CountReservations(string selectedVoyageName)
        {
            int count = 0;

            if (selectedVoyageName == "All")
            {
                count = unitOfWork.ReservationRepository.GetAll().Count();
            }
            else
            {
                count = unitOfWork.ReservationRepository.GetAll().Count(r => r.Voyage.Titre == selectedVoyageName);
            }

            textBox1.Text = count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int reservationId = (int)dataGridView1.SelectedRows[0].Cells["ReservationId"].Value;

                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette réservation ?", "Confirmation de suppression", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    unitOfWork.ReservationRepository.Delete(reservationId);
                    unitOfWork.Save();

                    string selectedVoyageName = comboBox1.SelectedItem.ToString();
                    FilterReservations(selectedVoyageName);

                    CountReservations(selectedVoyageName);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une réservation à supprimer.", "Aucune réservation sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
