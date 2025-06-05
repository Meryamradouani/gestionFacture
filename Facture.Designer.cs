namespace TP5
{
    partial class Facture
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textDesignation = new System.Windows.Forms.TextBox();
            this.textReference = new System.Windows.Forms.TextBox();
            this.textQuantite = new System.Windows.Forms.TextBox();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantTva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.N_Facture = new System.Windows.Forms.TextBox();
            this.RSCLIENT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IF_Client = new System.Windows.Forms.TextBox();
            this.ICE_CLient = new System.Windows.Forms.TextBox();
            this.Cient_ID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Montant_Total = new System.Windows.Forms.TextBox();
            this.TVAtext = new System.Windows.Forms.TextBox();
            this.TotalAPayer = new System.Windows.Forms.TextBox();
            this.Validate = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.revenirMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Désignation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Réference :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = " Prix :";
            // 
            // textDesignation
            // 
            this.textDesignation.Location = new System.Drawing.Point(176, 63);
            this.textDesignation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDesignation.Name = "textDesignation";
            this.textDesignation.Size = new System.Drawing.Size(114, 22);
            this.textDesignation.TabIndex = 4;
            // 
            // textReference
            // 
            this.textReference.Location = new System.Drawing.Point(176, 103);
            this.textReference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textReference.Name = "textReference";
            this.textReference.Size = new System.Drawing.Size(114, 22);
            this.textReference.TabIndex = 5;
            // 
            // textQuantite
            // 
            this.textQuantite.Location = new System.Drawing.Point(176, 143);
            this.textQuantite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textQuantite.Name = "textQuantite";
            this.textQuantite.Size = new System.Drawing.Size(114, 22);
            this.textQuantite.TabIndex = 6;
            // 
            // textPrix
            // 
            this.textPrix.Location = new System.Drawing.Point(176, 180);
            this.textPrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(114, 22);
            this.textPrix.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.radioButton20);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(663, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 80);
            this.panel1.TabIndex = 8;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(78, 48);
            this.radioButton20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(51, 20);
            this.radioButton20.TabIndex = 2;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "20%";
            this.radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(78, 16);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(44, 20);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7%";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "TVA :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Designation,
            this.Prix,
            this.Quantite,
            this.MontantHT,
            this.MontantTva,
            this.TotalTTC,
            this.reference});
            this.dataGridView1.Location = new System.Drawing.Point(14, 264);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(814, 140);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Désignation";
            this.Designation.MinimumWidth = 8;
            this.Designation.Name = "Designation";
            this.Designation.Width = 150;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 8;
            this.Prix.Name = "Prix";
            this.Prix.Width = 150;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.MinimumWidth = 8;
            this.Quantite.Name = "Quantite";
            this.Quantite.Width = 150;
            // 
            // MontantHT
            // 
            this.MontantHT.HeaderText = "Montant HT";
            this.MontantHT.MinimumWidth = 8;
            this.MontantHT.Name = "MontantHT";
            this.MontantHT.Width = 150;
            // 
            // MontantTva
            // 
            this.MontantTva.HeaderText = "Montant TVA";
            this.MontantTva.MinimumWidth = 8;
            this.MontantTva.Name = "MontantTva";
            this.MontantTva.Width = 150;
            // 
            // TotalTTC
            // 
            this.TotalTTC.HeaderText = "Total(TTC)";
            this.TotalTTC.MinimumWidth = 8;
            this.TotalTTC.Name = "TotalTTC";
            this.TotalTTC.Width = 150;
            // 
            // reference
            // 
            this.reference.HeaderText = "Réference";
            this.reference.MinimumWidth = 8;
            this.reference.Name = "reference";
            this.reference.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "N Facture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "RS Client";
            // 
            // N_Facture
            // 
            this.N_Facture.Location = new System.Drawing.Point(499, 64);
            this.N_Facture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.N_Facture.Name = "N_Facture";
            this.N_Facture.Size = new System.Drawing.Size(108, 22);
            this.N_Facture.TabIndex = 12;
            // 
            // RSCLIENT
            // 
            this.RSCLIENT.FormattingEnabled = true;
            this.RSCLIENT.Location = new System.Drawing.Point(499, 117);
            this.RSCLIENT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RSCLIENT.Name = "RSCLIENT";
            this.RSCLIENT.Size = new System.Drawing.Size(108, 24);
            this.RSCLIENT.TabIndex = 13;
            this.RSCLIENT.SelectedValueChanged += new System.EventHandler(this.RSCLIENT_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "IF Client";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "ICE Client";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Client_ID";
            // 
            // IF_Client
            // 
            this.IF_Client.Location = new System.Drawing.Point(176, 216);
            this.IF_Client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IF_Client.Name = "IF_Client";
            this.IF_Client.Size = new System.Drawing.Size(114, 22);
            this.IF_Client.TabIndex = 17;
            // 
            // ICE_CLient
            // 
            this.ICE_CLient.Location = new System.Drawing.Point(499, 216);
            this.ICE_CLient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ICE_CLient.Name = "ICE_CLient";
            this.ICE_CLient.Size = new System.Drawing.Size(108, 22);
            this.ICE_CLient.TabIndex = 18;
            // 
            // Cient_ID
            // 
            this.Cient_ID.Location = new System.Drawing.Point(499, 170);
            this.Cient_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cient_ID.Name = "Cient_ID";
            this.Cient_ID.Size = new System.Drawing.Size(108, 22);
            this.Cient_ID.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 431);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Montant total(dh)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(567, 469);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "TVA(7% ou 20%)( DH )";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(567, 517);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Total à payer (DH)";
            // 
            // Montant_Total
            // 
            this.Montant_Total.Location = new System.Drawing.Point(713, 425);
            this.Montant_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Montant_Total.Name = "Montant_Total";
            this.Montant_Total.Size = new System.Drawing.Size(115, 22);
            this.Montant_Total.TabIndex = 23;
            // 
            // TVAtext
            // 
            this.TVAtext.Location = new System.Drawing.Point(713, 463);
            this.TVAtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TVAtext.Name = "TVAtext";
            this.TVAtext.Size = new System.Drawing.Size(117, 22);
            this.TVAtext.TabIndex = 24;
            // 
            // TotalAPayer
            // 
            this.TotalAPayer.Location = new System.Drawing.Point(713, 511);
            this.TotalAPayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalAPayer.Name = "TotalAPayer";
            this.TotalAPayer.Size = new System.Drawing.Size(115, 22);
            this.TotalAPayer.TabIndex = 25;
            // 
            // Validate
            // 
            this.Validate.BackColor = System.Drawing.Color.Plum;
            this.Validate.Location = new System.Drawing.Point(688, 202);
            this.Validate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(113, 51);
            this.Validate.TabIndex = 26;
            this.Validate.Text = "Valider";
            this.Validate.UseVisualStyleBackColor = false;
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Update.Location = new System.Drawing.Point(14, 449);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(123, 50);
            this.Update.TabIndex = 27;
            this.Update.Text = "Modifier";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Quit.Location = new System.Drawing.Point(430, 452);
            this.Quit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(116, 51);
            this.Quit.TabIndex = 28;
            this.Quit.Text = "Quiter";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Plum;
            this.printButton.Location = new System.Drawing.Point(688, 137);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(111, 49);
            this.printButton.TabIndex = 29;
            this.printButton.Text = "Imprimer";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.DeleteButton.Location = new System.Drawing.Point(301, 452);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 51);
            this.DeleteButton.TabIndex = 30;
            this.DeleteButton.Text = "Supprimer";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // revenirMenu
            // 
            this.revenirMenu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.revenirMenu.Location = new System.Drawing.Point(153, 449);
            this.revenirMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revenirMenu.Name = "revenirMenu";
            this.revenirMenu.Size = new System.Drawing.Size(123, 50);
            this.revenirMenu.TabIndex = 31;
            this.revenirMenu.Text = "revenu au menu";
            this.revenirMenu.UseVisualStyleBackColor = false;
            this.revenirMenu.Click += new System.EventHandler(this.revenirMenu_Click);
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 575);
            this.Controls.Add(this.revenirMenu);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Validate);
            this.Controls.Add(this.TotalAPayer);
            this.Controls.Add(this.TVAtext);
            this.Controls.Add(this.Montant_Total);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Cient_ID);
            this.Controls.Add(this.ICE_CLient);
            this.Controls.Add(this.IF_Client);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RSCLIENT);
            this.Controls.Add(this.N_Facture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textPrix);
            this.Controls.Add(this.textQuantite);
            this.Controls.Add(this.textReference);
            this.Controls.Add(this.textDesignation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Facture";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Facture_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDesignation;
        private System.Windows.Forms.TextBox textReference;
        private System.Windows.Forms.TextBox textQuantite;
        private System.Windows.Forms.TextBox textPrix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantTva;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox N_Facture;
        private System.Windows.Forms.ComboBox RSCLIENT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IF_Client;
        private System.Windows.Forms.TextBox ICE_CLient;
        private System.Windows.Forms.TextBox Cient_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Montant_Total;
        private System.Windows.Forms.TextBox TVAtext;
        private System.Windows.Forms.TextBox TotalAPayer;
        private System.Windows.Forms.Button Validate;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button revenirMenu;
    }
}