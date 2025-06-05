using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TP5
{
    public partial class Form3 : MetroForm
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Client.mdf;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
            // Initialiser le thème
            this.StyleManager = new MetroFramework.Components.MetroStyleManager();
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Light; // ou Dark
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Blue;
            this.ExportExcel.Click += new System.EventHandler(this.ExportExcel_Click);
        }

        private void Devis_Load(object sender, EventArgs e)
        {
            LoadClientData();
            LoadDevis();
            dataGridViewDevis.SelectionChanged += dataGridViewDevis_SelectionChanged;
        }


        private void dataGridViewDevis_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDevis.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewDevis.SelectedRows[0];

                if (int.TryParse(selectedRow.Cells["DevisId"].Value.ToString(), out int devisId))
                {
                    currentDevisId = devisId;

                    // Remplir les informations du devis
                    FillDevisInfo(selectedRow);

                    // Remplir les informations client
                    FillClientInfo(selectedRow);

                    // Recharger les produits liés à ce devis
                    LoadProduits();
                    UpdateMontantsFromSelectedRow();
                    UpdateCounter();
                }
            }
        }

        private void FillDevisInfo(DataGridViewRow devisRow)
        {
            try
            {
                // Remplir les champs du devis
                DevisN.Text = devisRow.Cells["DevisNumber"].Value?.ToString() ?? "";
                ComboboxStatus.Text = devisRow.Cells["Status"].Value?.ToString() ?? "";

                // Mettre à jour les montants
                MT.Text = devisRow.Cells["TotalHT"].Value?.ToString() ?? "0";
                decimal totalHT = Convert.ToDecimal(devisRow.Cells["TotalHT"].Value ?? 0);
                decimal tva = totalHT * 0.20m;
                textTVA.Text = tva.ToString("F2");
                textTP.Text = (totalHT + tva).ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du remplissage des informations du devis: {ex.Message}");
            }
        }

        private void FillClientInfo(DataGridViewRow devisRow)
        {
            try
            {
                string rs = devisRow.Cells["RS"].Value?.ToString() ?? "";

                // Sélectionner le client dans le ComboBox
                ComboboxRSClient.SelectedItem = rs;

                // Charger les autres infos client depuis la base
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT IFiscale, ICE, Id FROM InfosClient WHERE RS = @RS";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@RS", rs);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        textIFClient.Text = reader["IFiscale"].ToString();
                        textICE.Text = reader["ICE"].ToString();
                        textIDClient.Text = reader["Id"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du remplissage des informations client: {ex.Message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gestion du ComboBox si nécessaire
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Gestion du panel si nécessaire
        }

        private int? currentDevisId = null;
        private void AddProduct_Click(object sender, EventArgs e)
        {

            if (currentDevisId == null)
            {
                MessageBox.Show("Ajoutez d'abord un devis avant d'ajouter un produit.");
                return;
            }

            if (string.IsNullOrWhiteSpace(designationProduit.Text) ||
                string.IsNullOrWhiteSpace(referenceProduit.Text) ||
                !int.TryParse(QuantiteProduit.Text, out int quantite) ||
                !decimal.TryParse(PrixProduit.Text, out decimal prix))
            {
                MessageBox.Show("Veuillez vérifier les informations du produit.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO Produits (DesignationP, QuantiteP, PrixP, referenceP, DevisId)
            VALUES (@DesignationP, @QuantiteP, @PrixP, @referenceP, @DevisId)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DesignationP", designationProduit.Text);
                cmd.Parameters.AddWithValue("@QuantiteP", quantite);
                cmd.Parameters.AddWithValue("@PrixP", prix);
                cmd.Parameters.AddWithValue("@referenceP", referenceProduit.Text);
                cmd.Parameters.AddWithValue("@DevisId", currentDevisId);

                connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produit ajouté avec succès.");
                LoadProduits();
                ClearProductFields();
                UpdateCounter();

            }
        }



        private void ClearProductFields()
        {
            designationProduit.Clear();
            referenceProduit.Clear();
            PrixProduit.Clear();
            QuantiteProduit.Clear();
        }



        private void LoadProduits()
        {
            try
            {
                string query = @"SELECT * FROM Produits WHERE DevisId = @DevisId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DevisId", currentDevisId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewProduits.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des produits : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optionnel : interaction avec les cellules
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
                        ComboboxRSClient.Items.Add(row["RS"].ToString());

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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboboxRSClient_SelectedValueChanged(object sender, EventArgs e)
        {
            // Vérifier qu'un élément est bien sélectionné
            if (ComboboxRSClient.SelectedItem == null) return;

            string query = "SELECT IFiscale, ICE, Id FROM InfosClient WHERE RS = @selectedRS";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection)) // Correction: utiliser connection au lieu de connectionString
                {
                    // Récupérer la valeur correcte (utiliser SelectedValue si ValueMember est défini)
                    string selectedValue = ComboboxRSClient.SelectedValue?.ToString() ?? ComboboxRSClient.SelectedItem.ToString();
                    command.Parameters.AddWithValue("@selectedRS", selectedValue);

                    // Ouvrir la connexion
                    connection.Open(); // Correction: utiliser connection.Open() au lieu de connectionString.Open()

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Correction des noms de colonnes pour correspondre à votre requête SQL
                            textIFClient.Text = reader["IFiscale"].ToString(); // Correction: "IdF" au lieu de "Id"
                            textICE.Text = reader["ICE"].ToString(); // Correction: "Ice" au lieu de "IdClient"
                            textIDClient.Text = reader["Id"].ToString(); // Correction: orthographe de "Client_ID"
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

        private void SaveCommand_Click(object sender, EventArgs e)
        {
            if (currentDevisId == null)
            {
                MessageBox.Show("Aucun devis à mettre à jour.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = @"
            SELECT SUM(PrixP * QuantiteP) AS TotalHT, SUM(QuantiteP) AS QuantiteTotale
            FROM Produits
            WHERE DevisId = @DevisId";

                string updateQuery = @"
            UPDATE Devis
            SET TotalHT = @TotalHT, QuantiteTotale = @QuantiteTotale
            WHERE DevisId = @DevisId";

                SqlCommand selectCmd = new SqlCommand(selectQuery, connection);
                selectCmd.Parameters.AddWithValue("@DevisId", currentDevisId);

                connection.Open();
                SqlDataReader reader = selectCmd.ExecuteReader();

                decimal totalHT = 0;
                int quantiteTotale = 0;

                if (reader.Read())
                {
                    totalHT = reader["TotalHT"] != DBNull.Value ? Convert.ToDecimal(reader["TotalHT"]) : 0;
                    quantiteTotale = reader["QuantiteTotale"] != DBNull.Value ? Convert.ToInt32(reader["QuantiteTotale"]) : 0;
                }

                reader.Close();

                SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@TotalHT", totalHT);
                updateCmd.Parameters.AddWithValue("@QuantiteTotale", quantiteTotale);
                updateCmd.Parameters.AddWithValue("@DevisId", currentDevisId);

                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Commande enregistrée et devis mis à jour.");

                LoadDevis();
            }
        }

        private void LoadDevis()
        {
            try
            {
                string query = @"SELECT DevisId, Status, DevisNumber, RS, TotalHT
                         FROM Devis 
                         ORDER BY DateDevis DESC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Ajouter la colonne TTC avec calcul automatique
                    dt.Columns.Add("TotalTTC", typeof(decimal));

                    foreach (DataRow row in dt.Rows)
                    {
                        if (decimal.TryParse(row["TotalHT"]?.ToString(), out decimal totalHT))
                        {
                            row["TotalTTC"] = totalHT + (totalHT * 0.20m); // Ajout TVA 20%
                        }
                        else
                        {
                            row["TotalTTC"] = 0;
                        }
                    }

                    dataGridViewDevis.DataSource = dt;
                    dataGridViewDevis.Columns["DevisId"].Visible = false;

                    dataGridViewDevis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewDevis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // Afficher automatiquement la première ligne si disponible
                    if (dataGridViewDevis.Rows.Count > 0)
                    {
                        dataGridViewDevis.Rows[0].Selected = true;
                        UpdateMontantsFromSelectedRow();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des devis : {ex.Message}",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void UpdateMontantsFromSelectedRow()
        {
            if (dataGridViewDevis.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataGridViewDevis.CurrentRow;
                try
                {
                    var cellValue = selectedRow.Cells["TotalHT"]?.Value;
                    if (cellValue != null && cellValue != DBNull.Value)
                    {
                        decimal totalHT = Convert.ToDecimal(cellValue);
                        decimal montantTVA = totalHT * 0.20m;
                        decimal totalTTC = totalHT + montantTVA;

                        MT.Text = totalHT.ToString("F2");
                        textTVA.Text = montantTVA.ToString("F2");
                        textTP.Text = totalTTC.ToString("F2");
                    }
                    else
                    {
                        MT.Text = textTVA.Text = textTP.Text = "0.00";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur UpdateMontants: " + ex.Message);
                }
            }
        }


        private void dataGridViewDevis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addDevis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DevisN.Text) || string.IsNullOrWhiteSpace(textIDClient.Text))
            {
                MessageBox.Show("Veuillez sélectionner un client et entrer un numéro de devis.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO Devis (DevisNumber, Id, DateDevis, Status, TotalHT, QuantiteTotale, RS)
            VALUES (@DevisNumber, @IdClient, @DateDevis, @Status, 0, NULL, @RS);
            SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DevisNumber", DevisN.Text);
                cmd.Parameters.AddWithValue("@IdClient", textIDClient.Text);
                cmd.Parameters.AddWithValue("@DateDevis", dateTimePickerDevis.Value); // Utilisation directe de la valeur
                cmd.Parameters.AddWithValue("@Status", ComboboxStatus.Text);
                cmd.Parameters.AddWithValue("@RS", ComboboxRSClient.Text);

                try
                {
                    connection.Open();
                    var insertedId = cmd.ExecuteScalar();
                    currentDevisId = Convert.ToInt32(insertedId);

                    MessageBox.Show($"Devis {DevisN.Text} ajouté. ID: {currentDevisId}", "Succès");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'ajout du devis: {ex.Message}", "Erreur");
                }
            }
        }

        private void DeletProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduits.SelectedRows.Count > 0)
            {
                try

                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Produits WHERE Id_Produit=@Id_Produit", connection))
                    {
                        connection.Open();

                        int rowID = Convert.ToInt32(dataGridViewProduits.SelectedRows[0].Cells["Id_Produit"].Value);


                        cmd.Parameters.AddWithValue("@Id_Produit", rowID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Suppression réussie !");
                            LoadProduits();
                        }
                        else
                        {
                            MessageBox.Show("Aucune ligne supprimée. ID introuvable ?");
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

        }
        private void UpdateCounter()
        {
            try
            {
                if (currentDevisId == null) return;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Produits WHERE DevisId = @DevisId";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@DevisId", currentDevisId);

                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    Counter.Text = count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour du compteur: {ex.Message}",
                              "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportToExcel()
        {
            if (dataGridViewDevis.Rows.Count == 0)
            {
                MessageBox.Show("Aucune donnée à exporter.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fichier CSV (.csv)|.csv";
            sfd.FileName = "export_devis.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        // Écrire l'en-tête
                        for (int i = 0; i < dataGridViewDevis.Columns.Count; i++)
                        {
                            if (dataGridViewDevis.Columns[i].Visible) // N'exporter que les colonnes visibles
                            {
                                sw.Write(dataGridViewDevis.Columns[i].HeaderText);
                                if (i < dataGridViewDevis.Columns.Count - 1)
                                    sw.Write(";");
                            }
                        }
                        sw.WriteLine();

                        // Écrire les lignes
                        foreach (DataGridViewRow row in dataGridViewDevis.Rows)
                        {
                            for (int i = 0; i < dataGridViewDevis.Columns.Count; i++)
                            {
                                if (dataGridViewDevis.Columns[i].Visible) // N'exporter que les colonnes visibles
                                {
                                    sw.Write(row.Cells[i].Value?.ToString()?.Replace(";", " ") ?? "");
                                    if (i < dataGridViewDevis.Columns.Count - 1)
                                        sw.Write(";");
                                }
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
        private void ExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void NexProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Client clientForm = new Client();
                clientForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Client form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DevisFacture_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un devis à convertir",
                              "Aucun devis sélectionné",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedDevisId = Convert.ToInt32(dataGridViewDevis.SelectedRows[0].Cells["DevisId"].Value);

                // Mettre à jour le statut du devis en "Validé"
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE Devis SET Status = 'Validé' WHERE DevisId = @DevisId";

                    SqlCommand cmd = new SqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@DevisId", selectedDevisId);


                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Le statut du devis a été mis à jour en 'Validé'",
                                      "Succès",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                        // Recharger les devis pour afficher le nouveau statut
                        LoadDevis();
                    }
                }

                // Ouvrir le formulaire de rapport (comme dans imprimerdevice)
                Form5 reportForm = new Form5(selectedDevisId); // Note: J'utilise Form4 comme dans imprimerdevice
                reportForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la conversion du devis:\n{ex.Message}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

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

  
        private void imprimerdevice_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un devis à convertir",
                              "Aucun devis sélectionné",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedDevisId = Convert.ToInt32(dataGridViewDevis.SelectedRows[0].Cells["DevisId"].Value);
                Form4 reportForm = new Form4(selectedDevisId);
                reportForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture du rapport:\n{ex.Message}",
                              "Erreur",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
    }

}