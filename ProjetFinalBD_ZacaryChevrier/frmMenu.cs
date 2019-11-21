using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinalBD_ZacaryChevrier
{
    public partial class frmMenu : Form
    {
        public static Employes userConnect;
        public frmMenu(Employes user)
        {
            InitializeComponent();
            userConnect = user;
            lblBienvenue.Text = "Bienvenue " + user.Prenom;
        }

        private void gestionDesEmployésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmGestionEmploye()).ShowDialog();
            this.Show();
        }

        private void abonnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new ajoutAbo()).ShowDialog();
            this.Show();
        }

        private void réabonnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmReabonnement()).ShowDialog();
            this.Show();
        }

        private void majDesAbonnésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmMAJAbo()).ShowDialog();
            this.Show();
        }

        private void inscriptionDuneDepenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmDepense()).ShowDialog();
            this.Show();
        }

        private void visualisationDesRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmRapport()).ShowDialog();
            this.Show();
        }

        private void visualisationDesStatistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmStats()).ShowDialog();
            this.Show();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }
    }
}
