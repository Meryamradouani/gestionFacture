using System;
using System.Windows.Forms;

namespace TP5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Configuration de la fenêtre
            this.Text = "Main Menu";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Création des labels pour les informations personnelles
            Label labelNom = new Label();
            labelNom.Text = "Nom : Radouani";
            labelNom.Location = new System.Drawing.Point(20, 20);
            labelNom.AutoSize = true;

            Label labelPrenom = new Label();
            labelPrenom.Text = "Prénom : Meryam";
            labelPrenom.Location = new System.Drawing.Point(20, 50);
            labelPrenom.AutoSize = true;

            Label labelEmail = new Label();
            labelEmail.Text = "Email : meryamm.radouani@gmail.com";
            labelEmail.Location = new System.Drawing.Point(20, 80);
            labelEmail.AutoSize = true;

            Label labelDateNaissance = new Label();
            labelDateNaissance.Text = "Date de naissance : 28/12/2003";
            labelDateNaissance.Location = new System.Drawing.Point(20, 110);
            labelDateNaissance.AutoSize = true;

            // Ajout des labels à la fenêtre
            this.Controls.Add(labelNom);
            this.Controls.Add(labelPrenom);
            this.Controls.Add(labelEmail);
            this.Controls.Add(labelDateNaissance);
        }

        private void buttonFacture_Click(object sender, EventArgs e)
        {
            try
            {
                Facture factureForm = new Facture();
                factureForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture du formulaire Facture: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client clientForm = new Client();
                clientForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture du formulaire Client: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDevice_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 devisForm = new Form3();
                devisForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture du formulaire Devis: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Code d'initialisation au chargement, si nécessaire
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Quitter",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
