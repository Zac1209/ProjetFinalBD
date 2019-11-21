namespace ProjetFinalBD_ZacaryChevrier
{
    partial class frmMenu
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
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonnementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reabonnementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJDesAbonnésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionDuneDepenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualisationDesRapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualisationDesStatistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnQuitApp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBienvenue.Location = new System.Drawing.Point(0, 63);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(732, 372);
            this.lblBienvenue.TabIndex = 7;
            this.lblBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesEmployésToolStripMenuItem,
            this.abonnementToolStripMenuItem,
            this.reabonnementToolStripMenuItem,
            this.mAJDesAbonnésToolStripMenuItem,
            this.inscriptionDuneDepenseToolStripMenuItem,
            this.visualisationDesRapportsToolStripMenuItem,
            this.visualisationDesStatistiquesToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // gestionDesEmployésToolStripMenuItem
            // 
            this.gestionDesEmployésToolStripMenuItem.Name = "gestionDesEmployésToolStripMenuItem";
            this.gestionDesEmployésToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.gestionDesEmployésToolStripMenuItem.Text = "Gestion des employés";
            this.gestionDesEmployésToolStripMenuItem.Click += new System.EventHandler(this.gestionDesEmployésToolStripMenuItem_Click);
            // 
            // abonnementToolStripMenuItem
            // 
            this.abonnementToolStripMenuItem.Name = "abonnementToolStripMenuItem";
            this.abonnementToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.abonnementToolStripMenuItem.Text = "Abonnement";
            this.abonnementToolStripMenuItem.Click += new System.EventHandler(this.abonnementToolStripMenuItem_Click);
            // 
            // reabonnementToolStripMenuItem
            // 
            this.reabonnementToolStripMenuItem.Name = "reabonnementToolStripMenuItem";
            this.reabonnementToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.reabonnementToolStripMenuItem.Text = "Réabonnement";
            this.reabonnementToolStripMenuItem.Click += new System.EventHandler(this.réabonnementToolStripMenuItem_Click);
            // 
            // mAJDesAbonnésToolStripMenuItem
            // 
            this.mAJDesAbonnésToolStripMenuItem.Name = "mAJDesAbonnésToolStripMenuItem";
            this.mAJDesAbonnésToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.mAJDesAbonnésToolStripMenuItem.Text = "MÀJ des abonnés";
            this.mAJDesAbonnésToolStripMenuItem.Click += new System.EventHandler(this.majDesAbonnésToolStripMenuItem_Click);
            // 
            // inscriptionDuneDepenseToolStripMenuItem
            // 
            this.inscriptionDuneDepenseToolStripMenuItem.Name = "inscriptionDuneDepenseToolStripMenuItem";
            this.inscriptionDuneDepenseToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.inscriptionDuneDepenseToolStripMenuItem.Text = "Inscription d\'une dépense";
            this.inscriptionDuneDepenseToolStripMenuItem.Click += new System.EventHandler(this.inscriptionDuneDepenseToolStripMenuItem_Click);
            // 
            // visualisationDesRapportsToolStripMenuItem
            // 
            this.visualisationDesRapportsToolStripMenuItem.Name = "visualisationDesRapportsToolStripMenuItem";
            this.visualisationDesRapportsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.visualisationDesRapportsToolStripMenuItem.Text = "Visualisation des rapports";
            this.visualisationDesRapportsToolStripMenuItem.Click += new System.EventHandler(this.visualisationDesRapportsToolStripMenuItem_Click);
            // 
            // visualisationDesStatistiquesToolStripMenuItem
            // 
            this.visualisationDesStatistiquesToolStripMenuItem.Name = "visualisationDesStatistiquesToolStripMenuItem";
            this.visualisationDesStatistiquesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.visualisationDesStatistiquesToolStripMenuItem.Text = "Visualisation des statistiques";
            this.visualisationDesStatistiquesToolStripMenuItem.Click += new System.EventHandler(this.visualisationDesStatistiquesToolStripMenuItem_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(12, 400);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(86, 23);
            this.btnLogOff.TabIndex = 9;
            this.btnLogOff.Text = "Déconnexion";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // btnQuitApp
            // 
            this.btnQuitApp.Location = new System.Drawing.Point(113, 400);
            this.btnQuitApp.Name = "btnQuitApp";
            this.btnQuitApp.Size = new System.Drawing.Size(86, 23);
            this.btnQuitApp.TabIndex = 10;
            this.btnQuitApp.Text = "Quitter l\'application";
            this.btnQuitApp.UseVisualStyleBackColor = true;
            this.btnQuitApp.Click += new System.EventHandler(this.btnQuitApp_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 435);
            this.Controls.Add(this.btnQuitApp);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.lblBienvenue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesEmployésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonnementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reabonnementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJDesAbonnésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionDuneDepenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualisationDesRapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualisationDesStatistiquesToolStripMenuItem;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnQuitApp;
    }
}