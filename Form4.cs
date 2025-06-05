using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace TP5
{
    public partial class Form4 : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Client.mdf;Integrated Security=True";
        private readonly int devisId;

        public Form4(int devisId)
        {
            InitializeComponent();
            this.devisId = devisId;
            LoadReport();
        }

        private void LoadReport()
        {
            DataTable produitsTable = null; // Déclaration unique en haut de la méthode

            try
            {
                string reportPath = Path.Combine(Application.StartupPath, "CrystalReport1.rpt");
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("Fichier rapport introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataSet ds = new DataSet();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Table InfosClient
                    DataTable clientTable = new DataTable("InfosClient");
                    new SqlDataAdapter("SELECT * FROM InfosClient WHERE Id IN (SELECT Id FROM Devis WHERE DevisId = @DevisId)", con)
                    {
                        SelectCommand = { Parameters = { new SqlParameter("@DevisId", devisId) } }
                    }.Fill(clientTable);
                    ds.Tables.Add(clientTable);

                    // Table Devis
                    DataTable devisTable = new DataTable("Devis");
                    new SqlDataAdapter("SELECT * FROM Devis WHERE DevisId = @DevisId", con)
                    {
                        SelectCommand = { Parameters = { new SqlParameter("@DevisId", devisId) } }
                    }.Fill(devisTable);
                    ds.Tables.Add(devisTable);

                    // Table Produits - Utilisation de la variable déjà déclarée
                    produitsTable = new DataTable("Produits");
                    new SqlDataAdapter("SELECT * FROM Produits WHERE DevisId = @DevisId", con)
                    {
                        SelectCommand = { Parameters = { new SqlParameter("@DevisId", devisId) } }
                    }.Fill(produitsTable);
                    ds.Tables.Add(produitsTable);
                }

                // Vérification des données
                if (produitsTable.Rows.Count == 0)
                {
                    MessageBox.Show("Aucun produit trouvé pour ce devis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Reste du code inchangé...
                ReportDocument report = new ReportDocument();
                report.Load(reportPath);

                foreach (DataTable table in ds.Tables)
                {
                    if (report.Database.Tables[table.TableName] != null)
                    {
                        report.Database.Tables[table.TableName].SetDataSource(table);
                    }
                }

                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement du rapport:\n{ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckRelations(DataSet1 ds)
        {
            // Vérifie les relations pour le débogage
            StringBuilder sb = new StringBuilder();

            foreach (System.Data.DataRelation relation in ds.Relations)
            {
                sb.AppendLine($"Relation: {relation.RelationName}");
                sb.AppendLine($"Parent: {relation.ParentTable.TableName}");
                sb.AppendLine($"Child: {relation.ChildTable.TableName}");
                sb.AppendLine("-----------");
            }

            MessageBox.Show(sb.ToString(), "Relations dans le DataSet");
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            // Vous pouvez laisser cette méthode vide si vous n'avez pas besoin
            // de code d'initialisation spécifique pour le viewer
            // Ou ajoutez votre code d'initialisation ici
        }
    }
}