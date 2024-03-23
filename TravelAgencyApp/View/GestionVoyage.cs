using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyApp.Model;
using TravelAgencyApp.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelAgencyApp.View
{

    public partial class GestionVoyage : Form
    {
        private UnitOfWork unitOfWork;

        public GestionVoyage()

        {
            unitOfWork=new UnitOfWork();
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                string titre = zoneTitre.Text;
            string description = zoneDescription.Text;
            String destination=zoneDestination.Text;
            DateTime dateDepart = dateDepartPicker.Value;
            DateTime dateRetour = dateRetourPicker.Value;
            int prix = int.Parse(zonePrix.Text);
            int placesDisponibles = int.Parse(zoneNbPlace.Text);
            int guideId = int.Parse(GuidecomboBox.SelectedItem.ToString());
            if (guideId != null)
            {
                MessageBox.Show("pas null");
            }


            else
            {
                MessageBox.Show("null");
            }
              
            
           
            Voyage nouveauVoyage = new Voyage()
            {
                Titre = titre,
                Description = description,
                Destinations=destination,
                DateDepart = dateDepart,
                DateRetour = dateRetour,
                Prix = prix,
                NombrePlacesDisponibles = placesDisponibles,
                GuideId = guideId
            };
            unitOfWork.VoyageRepository.Insert(nouveauVoyage);
            unitOfWork.Save();
                MessageBox.Show("Le voyage a été ajouté avec succès !");
            }
            catch (DbEntityValidationException ex)
            {
                // Parcourir toutes les erreurs de validation pour chaque entité
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    // Parcourir toutes les erreurs de validation pour une entité spécifique
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        // Afficher les détails de l'erreur de validation (par exemple, la propriété affectée et le message d'erreur)
                        MessageBox.Show($"Erreur de validation pour la propriété : {validationError.PropertyName}");
                        MessageBox.Show($"Message d'erreur : {validationError.ErrorMessage}");
                    }
                }
               

            }
        }

        private void GestionVoyage_Load(object sender, EventArgs e)
        {
            IEnumerable<Guide> guides = unitOfWork.GuideRepository.GetAll();
            foreach (Guide guide in guides)
            {
                GuidecomboBox.Items.Add(guide.PersonnelId);
            }
        }
    }
}
