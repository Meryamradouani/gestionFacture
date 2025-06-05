using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;
using MetroFramework.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP5
{
    public partial class Client : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Client.mdf;Integrated Security=True"

        );





        public Client()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textIDClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRaisonS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIFClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTypeSociete_TextChanged(object sender, EventArgs e)
        {

        }

        private void textICE_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            vider();

        }

        private void vider()
        {
            textIDClient.Text = "";
            textRaisonS.Text = "";
            textIFClient.Text = "";
            textTypeSociete.Text = "";
            textICE.Text = "";
            textRegistreCommerce.Text = "";
            textNomResponsable.Text = "";
            textPatente.Text = "";
            NameClient.Text = "";
            PrenomClient.Text = "";
            EmailClient.Text = "";
            TelClient.Text = "";
            FaxClient.Text = "";
            PortableClient.Text = "";
            VilleClient.Text = "";
            textAdresse.Text = "";
            PaysClient.Text = "";
        }

        private object GetDbValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return DBNull.Value;
            else
                return value;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO InfosClient (Id, NomResp, TypeSocite, Nom, Prenom, Tel, Portable, Fax, Email, Adresse, Ville, Pays, RS, IFiscale, ICE, RegistreCommerce, Patente) " +
                                  "VALUES (@Id, @NomResp, @TypeSocite, @Nom, @Prenom, @Tel, @Portable, @Fax, @Email, @Adresse, @Ville, @Pays, @RS, @IFiscale, @ICE, @RegistreCommerce, @Patente)";

                cmd.Parameters.AddWithValue("@Id", GetDbValue(textIDClient.Text));
                cmd.Parameters.AddWithValue("@NomResp", GetDbValue(textNomResponsable.Text));
                cmd.Parameters.AddWithValue("@TypeSocite", GetDbValue(textTypeSociete.Text));
                cmd.Parameters.AddWithValue("@Nom", GetDbValue(NameClient.Text));
                cmd.Parameters.AddWithValue("@Prenom", GetDbValue(PrenomClient.Text));
                cmd.Parameters.AddWithValue("@Tel", GetDbValue(TelClient.Text));
                cmd.Parameters.AddWithValue("@Portable", GetDbValue(PortableClient.Text));
                cmd.Parameters.AddWithValue("@Fax", GetDbValue(FaxClient.Text));
                cmd.Parameters.AddWithValue("@Email", GetDbValue(EmailClient.Text));
                cmd.Parameters.AddWithValue("@Adresse", GetDbValue(textAdresse.Text));
                cmd.Parameters.AddWithValue("@Ville", GetDbValue(VilleClient.Text));
                cmd.Parameters.AddWithValue("@Pays", GetDbValue(PaysClient.Text));
                cmd.Parameters.AddWithValue("@RS", GetDbValue(textRaisonS.Text));
                cmd.Parameters.AddWithValue("@IFiscale", GetDbValue(textIFClient.Text));
                cmd.Parameters.AddWithValue("@ICE", GetDbValue(textICE.Text));
                cmd.Parameters.AddWithValue("@RegistreCommerce", GetDbValue(textRegistreCommerce.Text));
                cmd.Parameters.AddWithValue("@Patente", GetDbValue(textPatente.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Client ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            display_data();

        }

        private void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM InfosClient"; // Affiche toutes les colonnes
            cmd.ExecuteNonQuery();

            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }


        private void Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int rowID = Convert.ToInt32(textIDClient.Text); // On lit directement le champ Id

                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE InfosClient 
                                SET NomResp = @NomResp,
                                    TypeSocite = @TypeSocite,
                                    Nom = @Nom,
                                    Prenom = @Prenom,
                                    Tel = @Tel,
                                    Portable = @Portable,
                                    Fax = @Fax,
                                    Email = @Email,
                                    Adresse = @Adresse,
                                    Ville = @Ville,
                                    Pays = @Pays,
                                    RS = @RS,
                                    IFiscale = @IFiscale,
                                    ICE = @ICE,
                                    RegistreCommerce = @RegistreCommerce,
                                    Patente = @Patente
                                WHERE Id = @Id";

                    cmd.Parameters.AddWithValue("@NomResp", textNomResponsable.Text);
                    cmd.Parameters.AddWithValue("@TypeSocite", textTypeSociete.Text);
                    cmd.Parameters.AddWithValue("@Nom", NameClient.Text);
                    cmd.Parameters.AddWithValue("@Prenom", PrenomClient.Text);
                    cmd.Parameters.AddWithValue("@Tel", TelClient.Text);
                    cmd.Parameters.AddWithValue("@Portable", PortableClient.Text);
                    cmd.Parameters.AddWithValue("@Fax", FaxClient.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailClient.Text);
                    cmd.Parameters.AddWithValue("@Adresse", textAdresse.Text);
                    cmd.Parameters.AddWithValue("@Ville", VilleClient.Text);
                    cmd.Parameters.AddWithValue("@Pays", PaysClient.Text);
                    cmd.Parameters.AddWithValue("@RS", textRaisonS.Text);
                    cmd.Parameters.AddWithValue("@IFiscale", textIFClient.Text);
                    cmd.Parameters.AddWithValue("@ICE", textICE.Text);
                    cmd.Parameters.AddWithValue("@RegistreCommerce", textRegistreCommerce.Text);
                    cmd.Parameters.AddWithValue("@Patente", textPatente.Text);
                    cmd.Parameters.AddWithValue("@Id", rowID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mise à jour réussie !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                display_data();
            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lancer la recherche à chaque changement de colonne de recherche
            PerformSearch();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            // Lancer la recherche à chaque changement de texte
            PerformSearch();
        }

        private void PerformSearch()
        {
            string colonne = "";

            // Valider la colonne choisie
            if (comboBoxSearch.Text == "Nom") colonne = "Nom";
            else if (comboBoxSearch.Text == "Ville") colonne = "Ville";
            else if (comboBoxSearch.Text == "Id") colonne = "Id";
            else
            {
                // Colonne non reconnue : afficher tout ou ne rien faire
                display_data();
                return;
            }

            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (string.IsNullOrWhiteSpace(textSearch.Text))
                {
                    // Si la recherche est vide, afficher toutes les données
                    cmd.CommandText = "SELECT * FROM InfosClient";
                }
                else
                {
                    // Recherche avec LIKE + paramètre
                    cmd.CommandText = $"SELECT * FROM InfosClient WHERE {colonne} LIKE @valeur";
                    cmd.Parameters.AddWithValue("@valeur", textSearch.Text + "%");
                }

                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }




        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                textIDClient.Text = selectedRow.Cells["Id"].Value?.ToString() ?? "";
                textNomResponsable.Text = selectedRow.Cells["NomResp"].Value?.ToString() ?? "";
                textTypeSociete.Text = selectedRow.Cells["TypeSocite"].Value?.ToString() ?? "";
                NameClient.Text = selectedRow.Cells["Nom"].Value?.ToString() ?? "";
                PrenomClient.Text = selectedRow.Cells["Prenom"].Value?.ToString() ?? "";
                TelClient.Text = selectedRow.Cells["Tel"].Value?.ToString() ?? "";
                PortableClient.Text = selectedRow.Cells["Portable"].Value?.ToString() ?? "";
                FaxClient.Text = selectedRow.Cells["Fax"].Value?.ToString() ?? "";
                EmailClient.Text = selectedRow.Cells["Email"].Value?.ToString() ?? "";
                textAdresse.Text = selectedRow.Cells["Adresse"].Value?.ToString() ?? "";
                VilleClient.Text = selectedRow.Cells["Ville"].Value?.ToString() ?? "";
                PaysClient.Text = selectedRow.Cells["Pays"].Value?.ToString() ?? "";
                textRaisonS.Text = selectedRow.Cells["RS"].Value?.ToString() ?? "";
                textIFClient.Text = selectedRow.Cells["IFiscale"].Value?.ToString() ?? "";
                textICE.Text = selectedRow.Cells["ICE"].Value?.ToString() ?? "";
                textRegistreCommerce.Text = selectedRow.Cells["RegistreCommerce"].Value?.ToString() ?? "";
                textPatente.Text = selectedRow.Cells["Patente"].Value?.ToString() ?? "";
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int rowID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM InfosClient WHERE Id = @Id";
                        cmd.Parameters.AddWithValue("@Id", rowID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Client supprimé avec succès.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }

                    display_data();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.");
            }
        }

        private void Export_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
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
    }
}