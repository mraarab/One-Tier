namespace One_Tier
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNouveauClient = new System.Windows.Forms.Button();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nom,
            this.adresse,
            this.solde});
            this.dgvClients.Location = new System.Drawing.Point(155, 63);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 82;
            this.dgvClients.Size = new System.Drawing.Size(859, 408);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(244, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clients :";
            // 
            // btnNouveauClient
            // 
            this.btnNouveauClient.ImageKey = "299068_add_sign_icon.png";
            this.btnNouveauClient.ImageList = this.imageList1;
            this.btnNouveauClient.Location = new System.Drawing.Point(47, 114);
            this.btnNouveauClient.Name = "btnNouveauClient";
            this.btnNouveauClient.Size = new System.Drawing.Size(82, 70);
            this.btnNouveauClient.TabIndex = 2;
            this.btnNouveauClient.UseVisualStyleBackColor = true;
            this.btnNouveauClient.Click += new System.EventHandler(this.btnNouveauClient_Click);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.ImageKey = "32686_error_delete_remove_icon.png";
            this.btnSupprimerClient.ImageList = this.imageList1;
            this.btnSupprimerClient.Location = new System.Drawing.Point(47, 309);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(82, 68);
            this.btnSupprimerClient.TabIndex = 3;
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "32686_error_delete_remove_icon.png");
            this.imageList1.Images.SetKeyName(1, "299068_add_sign_icon.png");
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 50;
            this.nom.Name = "nom";
            this.nom.Width = 150;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "adresse";
            this.adresse.MinimumWidth = 50;
            this.adresse.Name = "adresse";
            this.adresse.Width = 150;
            // 
            // solde
            // 
            this.solde.HeaderText = "solde";
            this.solde.MinimumWidth = 50;
            this.solde.Name = "solde";
            this.solde.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnNouveauClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouveauClient;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn solde;
    }
}

