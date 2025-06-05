using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace TP5
{
    public partial class Facture : MetroForm
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Client.mdf;Integrated Security=True";

        public Facture()
        {
            InitializeComponent();
            this.Font = new System.Drawing.Font("Segoe UI", 14f);

            // Configurer le style APRÈS InitializeComponent()
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.Container);
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Blue;

            // Configurer la police de manière sécurisée
            try
            {
                this.Font = MetroFramework.MetroFonts.Default(14f);
            }
            catch
            {
                // Fallback sur une police standard si MetroFonts échoue
                this.Font = new System.Drawing.Font("Segoe UI", 14f);
            }
            radioButton7.Checked = true;
        }


        private void Facture_Load(object sender, EventArgs e)
        {
            LoadClientData();
            DisplayData();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged; // Ajoutez cette ligne
        }

        private void LoadClientData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT RS FROM InfosClient", connection))
                {
                    connection.Open();

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    // Donne les données au ComboBox
                    foreach (DataRow row in table.Rows)

                    {
                        RSCLIENT.Items.Add(row["RS"].ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données: {ex.Message}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void CalculerTotaux()
        {
            // Validation des champs obligatoires
            if (string.IsNullOrWhiteSpace(textPrix.Text) ||
                string.IsNullOrWhiteSpace(textQuantite.Text) ||
                string.IsNullOrWhiteSpace(textDesignation.Text) ||
                string.IsNullOrWhiteSpace(textReference.Text) ||
                string.IsNullOrWhiteSpace(N_Facture.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de valider.",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // Conversion des valeurs numériques
            if (!double.TryParse(textPrix.Text, out double prixUnitaire) ||
                !int.TryParse(textQuantite.Text, out int quantite))
            {
                MessageBox.Show("Veuillez entrer des valeurs numériques valides.",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // Calcul des montants
            double MontantHT = prixUnitaire * quantite;
            double TVA = radioButton20.Checked ? 0.20 : 0.07;
            double MontantTVA = MontantHT * TVA;
            double MontantTTC = MontantHT + MontantTVA;

            // Initialisation des colonnes si nécessaire
            if (dataGridView1.ColumnCount == 0)
            {
                dataGridView1.Columns.Add("Id_Facture", "N_Facture");
                dataGridView1.Columns.Add("Designation", "Désignation");
                dataGridView1.Columns.Add("PrixUnitaire", "Prix Unitaire");
                dataGridView1.Columns.Add("Quantite", "Quantité");
                dataGridView1.Columns.Add("MontantHT", "Montant HT");
                dataGridView1.Columns.Add("MontantTVA", "Montant TVA");
                dataGridView1.Columns.Add("MontantTTC", "Montant TTC");
            }

            // Ajout de la ligne dans le DataGridView
            dataGridView1.Rows.Add(
     N_Facture.Text,
     textDesignation.Text,
     prixUnitaire,
     quantite,
     MontantHT,
     MontantTVA,
     MontantTTC);

            // Calcul des totaux
            double totalHT = 0, totalTVA = 0, totalTTC = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null &&
                    row.Cells[4].Value != null &&
                    row.Cells[5].Value != null)
                {
                    totalHT += Convert.ToDouble(row.Cells[3].Value);
                    totalTVA += Convert.ToDouble(row.Cells[4].Value);
                    totalTTC += Convert.ToDouble(row.Cells[5].Value);
                }
            }

            // Affichage des totaux
            Montant_Total.Text = totalHT.ToString("F2");
            TVAtext.Text = totalTVA.ToString("F2");
            TotalAPayer.Text = totalTTC.ToString("F2");
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée (mode édition)
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Update_Click(sender, e); // Si une ligne est sélectionnée, faire une mise à jour
            }
            else
            {
                CalculerTotaux(); // Sinon, ajouter une nouvelle ligne
                ADD_Facture();
            }

            ClearInputFields();
        }

        private void ClearInputFields()
        {
            textDesignation.Text = "";
            textPrix.Text = "";
            textQuantite.Text = "";
            textReference.Text = "";
            radioButton7.Checked = true;
        }

        private void ADD_Facture()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Facture (Id_Facture, Designation, Refernce, Quantite, Prix) " +
                    "VALUES (@Id_Facture, @Designation, @Refernce, @Quantite, @Prix)", connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@Id_Facture", N_Facture.Text.Trim());
                    cmd.Parameters.AddWithValue("@Designation", textDesignation.Text.Trim());
                    cmd.Parameters.AddWithValue("@Refernce", textReference.Text.Trim());
                    cmd.Parameters.AddWithValue("@Quantite", int.TryParse(textQuantite.Text, out int qte) ? qte : 0);
                    cmd.Parameters.AddWithValue("@Prix", double.TryParse(textPrix.Text, out double prix) ? prix : 0.0);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Facture ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la facture : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Code pour gérer les clics sur les cellules si nécessaire
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // Code pour gérer le clic sur le label si nécessaire
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Vérifiez les noms exacts de vos colonnes dans le DataGridView
                textDesignation.Text = selectedRow.Cells["Designation"].Value?.ToString() ?? "";
                textPrix.Text = selectedRow.Cells["PrixUnitaire"].Value?.ToString() ?? "";
                textQuantite.Text = selectedRow.Cells["Quantite"].Value?.ToString() ?? "";

                // Ajoutez cette vérification pour la référence
                if (selectedRow.Cells["Refernce"] != null)
                {
                    textReference.Text = selectedRow.Cells["Refernce"].Value?.ToString() ?? "";
                }

                // Mettez à jour le numéro de facture si nécessaire
                if (selectedRow.Cells["Id_Facture"] != null)
                {
                    N_Facture.Text = selectedRow.Cells["Id_Facture"].Value?.ToString() ?? "";
                }
            }
        }

        private void RSCLIENT_SelectedValueChanged(object sender, EventArgs e)
        {
            // Vérifier qu'un élément est bien sélectionné
            if (RSCLIENT.SelectedItem == null) return;

            string query = "SELECT IFiscale, ICE, Id FROM InfosClient WHERE RS = @selectedRS";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection)) // Correction: utiliser connection au lieu de connectionString
                {
                    // Récupérer la valeur correcte (utiliser SelectedValue si ValueMember est défini)
                    string selectedValue = RSCLIENT.SelectedValue?.ToString() ?? RSCLIENT.SelectedItem.ToString();
                    command.Parameters.AddWithValue("@selectedRS", selectedValue);

                    // Ouvrir la connexion
                    connection.Open(); // Correction: utiliser connection.Open() au lieu de connectionString.Open()

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Correction des noms de colonnes pour correspondre à votre requête SQL
                            IF_Client.Text = reader["IFiscale"].ToString(); // Correction: "IdF" au lieu de "Id"
                            ICE_CLient.Text = reader["ICE"].ToString(); // Correction: "Ice" au lieu de "IdClient"
                            Cient_ID.Text = reader["Id"].ToString(); // Correction: orthographe de "Client_ID"
                        }
                    }
                    // Le using fermera automatiquement le reader
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données client: {ex.Message}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à mettre à jour.",
                              "Avertissement",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // Validation des champs obligatoires
            if (string.IsNullOrWhiteSpace(textDesignation.Text) ||
                string.IsNullOrWhiteSpace(textPrix.Text) ||
                string.IsNullOrWhiteSpace(textQuantite.Text) ||
                string.IsNullOrWhiteSpace(textReference.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de mettre à jour.",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return;
            }

            // Conversion sécurisée des valeurs numériques
            if (!double.TryParse(textPrix.Text, out double prix))
            {
                MessageBox.Show("Veuillez entrer un prix valide.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textQuantite.Text, out int quantite))
            {
                MessageBox.Show("Veuillez entrer une quantité valide.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Récupérer l'ID de la facture à partir de la ligne sélectionnée
                    var selectedRow = dataGridView1.SelectedRows[0];
                    string idFacture = selectedRow.Cells["Id_Facture"].Value?.ToString();

                    if (string.IsNullOrEmpty(idFacture))
                    {
                        MessageBox.Show("Impossible de déterminer l'ID de la facture à mettre à jour.",
                                      "Erreur",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE Facture SET Designation=@Designation, Prix=@Prix, " +
                        "Quantite=@Quantite, Refernce=@Refernce WHERE Id_Facture=@Id_Facture", connection))
                    {
                        cmd.Parameters.AddWithValue("@Designation", textDesignation.Text.Trim());
                        cmd.Parameters.AddWithValue("@Prix", prix);
                        cmd.Parameters.AddWithValue("@Quantite", quantite);
                        cmd.Parameters.AddWithValue("@Refernce", textReference.Text.Trim());
                        cmd.Parameters.AddWithValue("@Id_Facture", idFacture);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mise à jour réussie!",
                                         "Succès",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

                            // Mettre à jour la ligne dans le DataGridView
                            selectedRow.Cells["Designation"].Value = textDesignation.Text.Trim();
                            selectedRow.Cells["PrixUnitaire"].Value = prix;
                            selectedRow.Cells["Quantite"].Value = quantite;
                            selectedRow.Cells["Refernce"].Value = textReference.Text.Trim();

                            // Calculer les nouveaux montants pour la ligne mise à jour
                            double montantHT = prix * quantite;
                            double tvaRate = radioButton20.Checked ? 0.20 : 0.07;
                            double montantTVA = montantHT * tvaRate;
                            double montantTTC = montantHT + montantTVA;

                            // Mettre à jour les cellules de montants
                            selectedRow.Cells["MontantHT"].Value = montantHT;
                            selectedRow.Cells["MontantTVA"].Value = montantTVA;
                            selectedRow.Cells["MontantTTC"].Value = montantTTC;

                            // Recalculer les totaux
                            RecalculerTotaux();
                        }
                        else
                        {
                            MessageBox.Show("Aucune ligne mise à jour. La facture n'existe peut-être plus.",
                                           "Avertissement",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour: {ex.Message}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
        private void RecalculerTotaux()
        {
            double totalHT = 0, totalTVA = 0, totalTTC = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MontantHT"].Value != null &&
                    row.Cells["MontantTVA"].Value != null &&
                    row.Cells["MontantTTC"].Value != null)
                {
                    totalHT += Convert.ToDouble(row.Cells["MontantHT"].Value);
                    totalTVA += Convert.ToDouble(row.Cells["MontantTVA"].Value);
                    totalTTC += Convert.ToDouble(row.Cells["MontantTTC"].Value);
                }
            }

            // Affichage des totaux
            Montant_Total.Text = totalHT.ToString("F2");
            TVAtext.Text = totalTVA.ToString("F2");
            TotalAPayer.Text = totalTTC.ToString("F2");
        }

        private void DisplayData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT Id_Facture, Designation, Refernce, Quantite, Prix FROM Facture", connection))
                {
                    connection.Open();

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);

                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    // Ajouter les colonnes avec des noms cohérents
                    dataGridView1.Columns.Add("Id_Facture", "N_Facture");
                    dataGridView1.Columns.Add("Designation", "Désignation");
                    dataGridView1.Columns.Add("Refernce", "Référence");
                    dataGridView1.Columns.Add("PrixUnitaire", "Prix Unitaire");
                    dataGridView1.Columns.Add("Quantite", "Quantité");
                    dataGridView1.Columns.Add("MontantHT", "Montant HT");
                    dataGridView1.Columns.Add("MontantTVA", "Montant TVA");
                    dataGridView1.Columns.Add("MontantTTC", "Montant TTC");

                    foreach (DataRow row in table.Rows)
                    {
                        double prixUnitaire = Convert.ToDouble(row["Prix"]);
                        int quantite = Convert.ToInt32(row["Quantite"]);
                        double montantHT = prixUnitaire * quantite;
                        double tvaRate = radioButton20.Checked ? 0.20 : 0.07;
                        double montantTVA = montantHT * tvaRate;
                        double montantTTC = montantHT + montantTVA;

                        dataGridView1.Rows.Add(
                            row["Id_Facture"].ToString(),
                            row["Designation"].ToString(),
                            row["Refernce"].ToString(),
                            prixUnitaire,
                            quantite,
                            montantHT,
                            montantTVA,
                            montantTTC
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des données : " + ex.Message,
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Demander confirmation avant suppression
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette ligne?",
                                                   "Confirmation",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Récupérer la ligne sélectionnée avant la suppression
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                        string idFacture = selectedRow.Cells["Id_Facture"].Value?.ToString();

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Facture WHERE Id_Facture=@Id_Facture", connection))
                        {
                            connection.Open();
                            cmd.Parameters.AddWithValue("@Id_Facture", idFacture);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Supprimer la ligne du DataGridView
                                dataGridView1.Rows.Remove(selectedRow);

                                // Recalculer les totaux après suppression
                                RecalculerTotaux();

                                MessageBox.Show("Suppression réussie !", "Succès",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Aucune ligne supprimée. La facture n'existe peut-être plus.",
                                              "Avertissement",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la suppression: {ex.Message}",
                                      "Erreur",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.",
                              "Information",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Aucune donnée à exporter.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fichier CSV (*.csv)|*.csv";
            sfd.FileName = "export_clients.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        // Écrire l'en-tête
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            sw.Write(dataGridView1.Columns[i].HeaderText);
                            if (i < dataGridView1.Columns.Count - 1)
                                sw.Write(";");
                        }
                        sw.WriteLine();

                        // Écrire les lignes
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString()?.Replace(";", " ") ?? "");
                                if (i < dataGridView1.Columns.Count - 1)
                                    sw.Write(";");
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Exportation réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'exportation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void revenirMenu_Click(object sender, EventArgs e)
        {
            // Masquer le formulaire actuel
            this.Hide();

            // Créer et afficher le menu principal
            Form2 menuPrincipal = new Form2();
            menuPrincipal.Show();

            // Fermer proprement le formulaire actuel quand le menu est fermé
            menuPrincipal.FormClosed += (s, args) => this.Close();
        }
    }
}