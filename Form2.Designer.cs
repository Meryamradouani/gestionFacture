namespace TP5
{
    partial class Form2
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
            this.buttonDevice = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonFacture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ajouter facture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ajouter client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ajouter devis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gestion de Facture:";
            // 
            // buttonDevice
            // 
            this.buttonDevice.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonDevice.BackgroundImage = global::TP5.Properties.Resources.icons8_facturation_64__1_;
            this.buttonDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDevice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDevice.Location = new System.Drawing.Point(508, 331);
            this.buttonDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDevice.Name = "buttonDevice";
            this.buttonDevice.Size = new System.Drawing.Size(184, 87);
            this.buttonDevice.TabIndex = 2;
            this.buttonDevice.UseVisualStyleBackColor = false;
            this.buttonDevice.Click += new System.EventHandler(this.buttonDevice_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonClient.BackgroundImage = global::TP5.Properties.Resources.icons8_facturation_64;
            this.buttonClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClient.Location = new System.Drawing.Point(276, 331);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(184, 84);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonFacture
            // 
            this.buttonFacture.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonFacture.BackgroundImage = global::TP5.Properties.Resources.icons8_facturation_64__2_;
            this.buttonFacture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFacture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFacture.Location = new System.Drawing.Point(43, 330);
            this.buttonFacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFacture.Name = "buttonFacture";
            this.buttonFacture.Size = new System.Drawing.Size(184, 85);
            this.buttonFacture.TabIndex = 0;
            this.buttonFacture.UseVisualStyleBackColor = false;
            this.buttonFacture.Click += new System.EventHandler(this.buttonFacture_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDevice);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonFacture);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button buttonFacture;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}