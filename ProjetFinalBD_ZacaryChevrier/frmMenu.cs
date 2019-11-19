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
        Employes user;
        public frmMenu(Employes user)
        {
            InitializeComponent();
            this.user = user;
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

        }

        private void réabonnementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void majDesAbonnésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inscriptionDuneDépenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visualisationDesRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visualisationDesStatistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
