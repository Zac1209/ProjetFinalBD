namespace ProjetFinalBD_ZacaryChevrier
{
    partial class frmMAJAbo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.abonnementsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn11 = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.dataGridViewTextBoxColumn12 = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.dataGridViewTextBoxColumn13 = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonneSecondaireDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.dataGridViewTextBoxColumn29 = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCivique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new JThomas.Controls.DataGridViewMaskedTextColumn();
            this.IdProvince = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnQuitApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonneSecondaireDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // abonnementsDataGridView
            // 
            this.abonnementsDataGridView.AllowUserToAddRows = false;
            this.abonnementsDataGridView.AllowUserToDeleteRows = false;
            this.abonnementsDataGridView.AutoGenerateColumns = false;
            this.abonnementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonnementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.abonnementsDataGridView.DataSource = this.abonnementsBindingSource;
            this.abonnementsDataGridView.Location = new System.Drawing.Point(84, 67);
            this.abonnementsDataGridView.MultiSelect = false;
            this.abonnementsDataGridView.Name = "abonnementsDataGridView";
            this.abonnementsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abonnementsDataGridView.Size = new System.Drawing.Size(591, 220);
            this.abonnementsDataGridView.TabIndex = 1;
            this.abonnementsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.abonnementsDataGridView_CellEndEdit);
            this.abonnementsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.abonnementsDataGridView_CellValidating);
            this.abonnementsDataGridView.SelectionChanged += new System.EventHandler(this.abonnementsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateAbonnement";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateAbonnement";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sexe";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn5.HeaderText = "Sexe";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateNaissance";
            this.dataGridViewTextBoxColumn6.HeaderText = "DateNaissance";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NoCivique";
            this.dataGridViewTextBoxColumn7.HeaderText = "NoCivique";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Rue";
            this.dataGridViewTextBoxColumn8.HeaderText = "Rue";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Ville";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ville";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdProvince";
            this.dataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn10.HeaderText = "IdProvince";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CodePostal";
            this.dataGridViewTextBoxColumn11.HeaderText = "CodePostal";
            this.dataGridViewTextBoxColumn11.Mask = "L0L 0L0";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Telephone";
            dataGridViewCellStyle1.Format = "\"(###) ###-####\"";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn12.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn12.Mask = "(000) 000-0000";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Cellulaire";
            this.dataGridViewTextBoxColumn13.HeaderText = "Cellulaire";
            this.dataGridViewTextBoxColumn13.Mask = "(000) 000-0000";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Courriel";
            this.dataGridViewTextBoxColumn14.HeaderText = "Courriel";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "NoTypeAbonnement";
            this.dataGridViewTextBoxColumn15.HeaderText = "NoTypeAbonnement";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn16.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(ProjetFinalBD_ZacaryChevrier.Abonnements);
            // 
            // abonneSecondaireDataGridView
            // 
            this.abonneSecondaireDataGridView.AllowUserToAddRows = false;
            this.abonneSecondaireDataGridView.AllowUserToDeleteRows = false;
            this.abonneSecondaireDataGridView.AutoGenerateColumns = false;
            this.abonneSecondaireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonneSecondaireDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.NoCivique,
            this.Rue,
            this.Ville,
            this.CodePostal,
            this.IdProvince,
            this.dataGridViewTextBoxColumn32});
            this.abonneSecondaireDataGridView.DataSource = this.abonnementsBindingSource;
            this.abonneSecondaireDataGridView.Location = new System.Drawing.Point(84, 334);
            this.abonneSecondaireDataGridView.MultiSelect = false;
            this.abonneSecondaireDataGridView.Name = "abonneSecondaireDataGridView";
            this.abonneSecondaireDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abonneSecondaireDataGridView.Size = new System.Drawing.Size(591, 138);
            this.abonneSecondaireDataGridView.TabIndex = 2;
            this.abonneSecondaireDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.abonneSecondaireDataGridView_CellEndEdit);
            this.abonneSecondaireDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.abonneSecondaireDataGridView_CellValidating);
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn17.HeaderText = "Id";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn19.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn20.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Sexe";
            this.dataGridViewTextBoxColumn21.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn21.HeaderText = "Sexe";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "DateNaissance";
            this.dataGridViewTextBoxColumn22.HeaderText = "DateNaissance";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn28.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn28.Mask = "(000) 000-0000";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Cellulaire";
            this.dataGridViewTextBoxColumn29.HeaderText = "Cellulaire";
            this.dataGridViewTextBoxColumn29.Mask = "(000) 000-0000";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Courriel";
            this.dataGridViewTextBoxColumn30.HeaderText = "Courriel";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // NoCivique
            // 
            this.NoCivique.DataPropertyName = "NoCivique";
            this.NoCivique.HeaderText = "NoCivique";
            this.NoCivique.Name = "NoCivique";
            // 
            // Rue
            // 
            this.Rue.DataPropertyName = "Rue";
            this.Rue.HeaderText = "Rue";
            this.Rue.Name = "Rue";
            // 
            // Ville
            // 
            this.Ville.DataPropertyName = "Ville";
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // CodePostal
            // 
            this.CodePostal.DataPropertyName = "CodePostal";
            this.CodePostal.HeaderText = "CodePostal";
            this.CodePostal.Mask = "L0L 0L0";
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IdProvince
            // 
            this.IdProvince.DataPropertyName = "IdProvince";
            this.IdProvince.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.IdProvince.HeaderText = "IdProvince";
            this.IdProvince.Name = "IdProvince";
            this.IdProvince.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdProvince.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn32.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(316, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modification des abonnés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Abonnés principaux";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Abonnés secondaires";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 23);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnQuitApp
            // 
            this.btnQuitApp.Location = new System.Drawing.Point(84, 506);
            this.btnQuitApp.Name = "btnQuitApp";
            this.btnQuitApp.Size = new System.Drawing.Size(136, 23);
            this.btnQuitApp.TabIndex = 41;
            this.btnQuitApp.Text = "Quitter l\'application";
            this.btnQuitApp.UseVisualStyleBackColor = true;
            this.btnQuitApp.Click += new System.EventHandler(this.btnQuitApp_Click);
            // 
            // frmMAJAbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnQuitApp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.abonneSecondaireDataGridView);
            this.Controls.Add(this.abonnementsDataGridView);
            this.Name = "frmMAJAbo";
            this.Text = "Mise à jour des abonnés";
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonneSecondaireDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.DataGridView abonnementsDataGridView;
        private System.Windows.Forms.DataGridView abonneSecondaireDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private JThomas.Controls.DataGridViewMaskedTextColumn dataGridViewTextBoxColumn11;
        private JThomas.Controls.DataGridViewMaskedTextColumn dataGridViewTextBoxColumn12;
        private JThomas.Controls.DataGridViewMaskedTextColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private JThomas.Controls.DataGridViewMaskedTextColumn dataGridViewTextBoxColumn28;
        private JThomas.Controls.DataGridViewMaskedTextColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCivique;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private JThomas.Controls.DataGridViewMaskedTextColumn CodePostal;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnQuitApp;
    }
}