namespace TP5
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.DevisFacture = new System.Windows.Forms.Button();
            this.ExportExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewDevis = new System.Windows.Forms.DataGridView();
            this.textTP = new System.Windows.Forms.TextBox();
            this.textTVA = new System.Windows.Forms.TextBox();
            this.MT = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SaveCommand = new System.Windows.Forms.Button();
            this.addDevis = new System.Windows.Forms.Button();
            this.dataGridViewProduits = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePickerDevis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DevisN = new System.Windows.Forms.TextBox();
            this.textIFClient = new System.Windows.Forms.TextBox();
            this.textICE = new System.Windows.Forms.TextBox();
            this.textIDClient = new System.Windows.Forms.TextBox();
            this.ComboboxStatus = new System.Windows.Forms.ComboBox();
            this.ComboboxRSClient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.designationProduit = new System.Windows.Forms.TextBox();
            this.QuantiteProduit = new System.Windows.Forms.TextBox();
            this.PrixProduit = new System.Windows.Forms.TextBox();
            this.referenceProduit = new System.Windows.Forms.TextBox();
            this.Counter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Button();
            this.DeletProduct = new System.Windows.Forms.Button();
            this.NexProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.devisTableAdapter1 = new TP5.DataSet1TableAdapters.DevisTableAdapter();
            this.revenirMenu = new System.Windows.Forms.Button();
            this.imprimerdevice = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduits)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DevisFacture
            // 
            this.DevisFacture.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DevisFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevisFacture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DevisFacture.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DevisFacture.Location = new System.Drawing.Point(409, 578);
            this.DevisFacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DevisFacture.Name = "DevisFacture";
            this.DevisFacture.Size = new System.Drawing.Size(194, 57);
            this.DevisFacture.TabIndex = 6;
            this.DevisFacture.Text = "Devis =>Facture";
            this.DevisFacture.UseVisualStyleBackColor = false;
            this.DevisFacture.Click += new System.EventHandler(this.DevisFacture_Click);
            // 
            // ExportExcel
            // 
            this.ExportExcel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportExcel.Location = new System.Drawing.Point(642, 579);
            this.ExportExcel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(163, 56);
            this.ExportExcel.TabIndex = 7;
            this.ExportExcel.Text = "Exporter vers Excel";
            this.ExportExcel.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dataGridViewDevis);
            this.panel2.Location = new System.Drawing.Point(21, 325);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 116);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Liste des Devis";
            // 
            // dataGridViewDevis
            // 
            this.dataGridViewDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevis.Location = new System.Drawing.Point(33, 20);
            this.dataGridViewDevis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDevis.Name = "dataGridViewDevis";
            this.dataGridViewDevis.RowHeadersWidth = 62;
            this.dataGridViewDevis.RowTemplate.Height = 28;
            this.dataGridViewDevis.Size = new System.Drawing.Size(675, 90);
            this.dataGridViewDevis.TabIndex = 0;
            this.dataGridViewDevis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDevis_CellContentClick);
            // 
            // textTP
            // 
            this.textTP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTP.Location = new System.Drawing.Point(832, 498);
            this.textTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTP.Name = "textTP";
            this.textTP.Size = new System.Drawing.Size(123, 22);
            this.textTP.TabIndex = 13;
            // 
            // textTVA
            // 
            this.textTVA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTVA.Location = new System.Drawing.Point(832, 439);
            this.textTVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTVA.Name = "textTVA";
            this.textTVA.Size = new System.Drawing.Size(123, 22);
            this.textTVA.TabIndex = 12;
            // 
            // MT
            // 
            this.MT.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MT.Location = new System.Drawing.Point(832, 387);
            this.MT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MT.Name = "MT";
            this.MT.Size = new System.Drawing.Size(123, 22);
            this.MT.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(704, 501);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "Total à Payer";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(704, 442);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 16);
            this.label16.TabIndex = 9;
            this.label16.Text = "TVA 20% (DH)";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(704, 390);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(127, 16);
            this.label.TabIndex = 8;
            this.label.Text = "Montant toal (DH)";
            // 
            // SaveCommand
            // 
            this.SaveCommand.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SaveCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCommand.Location = new System.Drawing.Point(191, 576);
            this.SaveCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveCommand.Name = "SaveCommand";
            this.SaveCommand.Size = new System.Drawing.Size(195, 59);
            this.SaveCommand.TabIndex = 5;
            this.SaveCommand.Text = "Enregistrer La commande";
            this.SaveCommand.UseVisualStyleBackColor = false;
            this.SaveCommand.Click += new System.EventHandler(this.SaveCommand_Click);
            // 
            // addDevis
            // 
            this.addDevis.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDevis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addDevis.Location = new System.Drawing.Point(18, 576);
            this.addDevis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDevis.Name = "addDevis";
            this.addDevis.Size = new System.Drawing.Size(145, 59);
            this.addDevis.TabIndex = 4;
            this.addDevis.Text = "Ajouter Devis";
            this.addDevis.UseVisualStyleBackColor = false;
            this.addDevis.Click += new System.EventHandler(this.addDevis_Click);
            // 
            // dataGridViewProduits
            // 
            this.dataGridViewProduits.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduits.Location = new System.Drawing.Point(22, 19);
            this.dataGridViewProduits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProduits.Name = "dataGridViewProduits";
            this.dataGridViewProduits.RowHeadersWidth = 62;
            this.dataGridViewProduits.RowTemplate.Height = 28;
            this.dataGridViewProduits.Size = new System.Drawing.Size(664, 129);
            this.dataGridViewProduits.TabIndex = 0;
            this.dataGridViewProduits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduits_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Liste des Produits";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.dataGridViewProduits);
            this.panel3.Location = new System.Drawing.Point(21, 439);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 111);
            this.panel3.TabIndex = 3;
            // 
            // dateTimePickerDevis
            // 
            this.dateTimePickerDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDevis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDevis.Location = new System.Drawing.Point(389, 34);
            this.dateTimePickerDevis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDevis.Name = "dateTimePickerDevis";
            this.dateTimePickerDevis.Size = new System.Drawing.Size(108, 22);
            this.dateTimePickerDevis.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devis N ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "RS Client";
            // 
            // DevisN
            // 
            this.DevisN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevisN.Location = new System.Drawing.Point(103, 11);
            this.DevisN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DevisN.Name = "DevisN";
            this.DevisN.Size = new System.Drawing.Size(108, 22);
            this.DevisN.TabIndex = 3;
            // 
            // textIFClient
            // 
            this.textIFClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIFClient.Location = new System.Drawing.Point(103, 113);
            this.textIFClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textIFClient.Name = "textIFClient";
            this.textIFClient.Size = new System.Drawing.Size(108, 22);
            this.textIFClient.TabIndex = 6;
            // 
            // textICE
            // 
            this.textICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textICE.Location = new System.Drawing.Point(103, 155);
            this.textICE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textICE.Name = "textICE";
            this.textICE.Size = new System.Drawing.Size(108, 22);
            this.textICE.TabIndex = 7;
            // 
            // textIDClient
            // 
            this.textIDClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIDClient.Location = new System.Drawing.Point(103, 198);
            this.textIDClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textIDClient.Name = "textIDClient";
            this.textIDClient.Size = new System.Drawing.Size(108, 22);
            this.textIDClient.TabIndex = 8;
            // 
            // ComboboxStatus
            // 
            this.ComboboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxStatus.FormattingEnabled = true;
            this.ComboboxStatus.Items.AddRange(new object[] {
            "En attente",
            "Terminé"});
            this.ComboboxStatus.Location = new System.Drawing.Point(103, 42);
            this.ComboboxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboboxStatus.Name = "ComboboxStatus";
            this.ComboboxStatus.Size = new System.Drawing.Size(108, 24);
            this.ComboboxStatus.TabIndex = 9;
            this.ComboboxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ComboboxRSClient
            // 
            this.ComboboxRSClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboboxRSClient.FormattingEnabled = true;
            this.ComboboxRSClient.Location = new System.Drawing.Point(103, 76);
            this.ComboboxRSClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboboxRSClient.Name = "ComboboxRSClient";
            this.ComboboxRSClient.Size = new System.Drawing.Size(108, 24);
            this.ComboboxRSClient.TabIndex = 10;
            this.ComboboxRSClient.SelectedValueChanged += new System.EventHandler(this.ComboboxRSClient_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "IF Client:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "ICE Client:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Client Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date de devis:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Désignation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(268, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quantité:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Prix:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(268, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Réference:";
            // 
            // designationProduit
            // 
            this.designationProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationProduit.Location = new System.Drawing.Point(389, 76);
            this.designationProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.designationProduit.Name = "designationProduit";
            this.designationProduit.Size = new System.Drawing.Size(89, 22);
            this.designationProduit.TabIndex = 20;
            // 
            // QuantiteProduit
            // 
            this.QuantiteProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantiteProduit.Location = new System.Drawing.Point(389, 110);
            this.QuantiteProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuantiteProduit.Name = "QuantiteProduit";
            this.QuantiteProduit.Size = new System.Drawing.Size(89, 22);
            this.QuantiteProduit.TabIndex = 21;
            // 
            // PrixProduit
            // 
            this.PrixProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixProduit.Location = new System.Drawing.Point(389, 146);
            this.PrixProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrixProduit.Name = "PrixProduit";
            this.PrixProduit.Size = new System.Drawing.Size(89, 22);
            this.PrixProduit.TabIndex = 22;
            // 
            // referenceProduit
            // 
            this.referenceProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceProduit.Location = new System.Drawing.Point(389, 184);
            this.referenceProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.referenceProduit.Name = "referenceProduit";
            this.referenceProduit.Size = new System.Drawing.Size(89, 22);
            this.referenceProduit.TabIndex = 23;
            // 
            // Counter
            // 
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.Location = new System.Drawing.Point(710, 13);
            this.Counter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(120, 22);
            this.Counter.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(615, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Compteur";
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(569, 53);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(141, 45);
            this.AddProduct.TabIndex = 26;
            this.AddProduct.Text = "Ajouter Produit";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // DeletProduct
            // 
            this.DeletProduct.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DeletProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletProduct.Location = new System.Drawing.Point(570, 116);
            this.DeletProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeletProduct.Name = "DeletProduct";
            this.DeletProduct.Size = new System.Drawing.Size(140, 44);
            this.DeletProduct.TabIndex = 27;
            this.DeletProduct.Text = "Supprimer Produit";
            this.DeletProduct.UseVisualStyleBackColor = false;
            this.DeletProduct.Click += new System.EventHandler(this.DeletProduct_Click);
            // 
            // NexProduct
            // 
            this.NexProduct.BackColor = System.Drawing.Color.LightSkyBlue;
            this.NexProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NexProduct.Location = new System.Drawing.Point(570, 175);
            this.NexProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NexProduct.Name = "NexProduct";
            this.NexProduct.Size = new System.Drawing.Size(140, 45);
            this.NexProduct.TabIndex = 28;
            this.NexProduct.Text = "Nouveau Client";
            this.NexProduct.UseVisualStyleBackColor = false;
            this.NexProduct.Click += new System.EventHandler(this.NexProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.NexProduct);
            this.panel1.Controls.Add(this.DeletProduct);
            this.panel1.Controls.Add(this.AddProduct);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.Counter);
            this.panel1.Controls.Add(this.referenceProduit);
            this.panel1.Controls.Add(this.PrixProduit);
            this.panel1.Controls.Add(this.QuantiteProduit);
            this.panel1.Controls.Add(this.designationProduit);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ComboboxRSClient);
            this.panel1.Controls.Add(this.ComboboxStatus);
            this.panel1.Controls.Add(this.textIDClient);
            this.panel1.Controls.Add(this.textICE);
            this.panel1.Controls.Add(this.textIFClient);
            this.panel1.Controls.Add(this.DevisN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerDevis);
            this.panel1.Location = new System.Drawing.Point(50, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 259);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // devisTableAdapter1
            // 
            this.devisTableAdapter1.ClearBeforeFill = true;
            // 
            // revenirMenu
            // 
            this.revenirMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.revenirMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenirMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.revenirMenu.Location = new System.Drawing.Point(746, 329);
            this.revenirMenu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.revenirMenu.Name = "revenirMenu";
            this.revenirMenu.Size = new System.Drawing.Size(163, 37);
            this.revenirMenu.TabIndex = 14;
            this.revenirMenu.Text = "revenir au menu ";
            this.revenirMenu.UseVisualStyleBackColor = false;
            this.revenirMenu.Click += new System.EventHandler(this.revenirMenu_Click);
            // 
            // imprimerdevice
            // 
            this.imprimerdevice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.imprimerdevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimerdevice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imprimerdevice.Location = new System.Drawing.Point(845, 576);
            this.imprimerdevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imprimerdevice.Name = "imprimerdevice";
            this.imprimerdevice.Size = new System.Drawing.Size(145, 59);
            this.imprimerdevice.TabIndex = 15;
            this.imprimerdevice.Text = "imprimer devis ";
            this.imprimerdevice.UseVisualStyleBackColor = false;
            this.imprimerdevice.Click += new System.EventHandler(this.imprimerdevice_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 707);
            this.Controls.Add(this.imprimerdevice);
            this.Controls.Add(this.revenirMenu);
            this.Controls.Add(this.textTP);
            this.Controls.Add(this.textTVA);
            this.Controls.Add(this.MT);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ExportExcel);
            this.Controls.Add(this.DevisFacture);
            this.Controls.Add(this.SaveCommand);
            this.Controls.Add(this.addDevis);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Text = "Devis";
            this.Load += new System.EventHandler(this.Devis_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduits)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Button DevisFacture;
        private System.Windows.Forms.Button ExportExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewDevis;
        private System.Windows.Forms.TextBox textTP;
        private System.Windows.Forms.TextBox textTVA;
        private System.Windows.Forms.TextBox MT;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button SaveCommand;
        private System.Windows.Forms.Button addDevis;
        private System.Windows.Forms.DataGridView dataGridViewProduits;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DevisN;
        private System.Windows.Forms.TextBox textIFClient;
        private System.Windows.Forms.TextBox textICE;
        private System.Windows.Forms.TextBox textIDClient;
        private System.Windows.Forms.ComboBox ComboboxStatus;
        private System.Windows.Forms.ComboBox ComboboxRSClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox designationProduit;
        private System.Windows.Forms.TextBox QuantiteProduit;
        private System.Windows.Forms.TextBox PrixProduit;
        private System.Windows.Forms.TextBox referenceProduit;
        private System.Windows.Forms.TextBox Counter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button DeletProduct;
        private System.Windows.Forms.Button NexProduct;
        private System.Windows.Forms.Panel panel1;
        private DataSet1TableAdapters.DevisTableAdapter devisTableAdapter1;
        private System.Windows.Forms.Button revenirMenu;
        private System.Windows.Forms.Button imprimerdevice;
    }
}