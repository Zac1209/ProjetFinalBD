namespace ProjetFinalBD_ZacaryChevrier
{
    partial class frmReabonnement
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
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonnementsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitre = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnQuitApp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(ProjetFinalBD_ZacaryChevrier.Abonnements);
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
            this.dataGridViewTextBoxColumn4});
            this.abonnementsDataGridView.DataSource = this.abonnementsBindingSource;
            this.abonnementsDataGridView.Location = new System.Drawing.Point(49, 85);
            this.abonnementsDataGridView.MultiSelect = false;
            this.abonnementsDataGridView.Name = "abonnementsDataGridView";
            this.abonnementsDataGridView.ReadOnly = true;
            this.abonnementsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abonnementsDataGridView.Size = new System.Drawing.Size(356, 220);
            this.abonnementsDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 26);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(431, 39);
            this.lblTitre.TabIndex = 35;
            this.lblTitre.Text = "Réabonnement";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(133, 321);
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(185, 72);
            this.tbRemarque.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Remarque";
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Location = new System.Drawing.Point(153, 422);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(146, 54);
            this.btnRenew.TabIndex = 38;
            this.btnRenew.Text = "Renouveller l\'abonnement";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnQuitApp
            // 
            this.btnQuitApp.Location = new System.Drawing.Point(84, 520);
            this.btnQuitApp.Name = "btnQuitApp";
            this.btnQuitApp.Size = new System.Drawing.Size(136, 23);
            this.btnQuitApp.TabIndex = 39;
            this.btnQuitApp.Text = "Quitter l\'application";
            this.btnQuitApp.UseVisualStyleBackColor = true;
            this.btnQuitApp.Click += new System.EventHandler(this.btnQuitApp_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 520);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 23);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmReabonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 555);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnQuitApp);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.abonnementsDataGridView);
            this.Name = "frmReabonnement";
            this.Text = "Réabonnement";
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.DataGridView abonnementsDataGridView;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnQuitApp;
        private System.Windows.Forms.Button btnBack;
    }
}