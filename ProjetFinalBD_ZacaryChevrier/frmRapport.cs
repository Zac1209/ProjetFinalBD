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
    public partial class frmRapport : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        public frmRapport()
        {
            InitializeComponent();

            //Remplir dépenses par employé
            var depenseParEmploye = from uneDep in monDataContext.Depenses
                                    orderby uneDep.NoService
                                    select uneDep;
            foreach(Depenses dep in depenseParEmploye)
            {
                var service = (from unEmp in monDataContext.Services
                               where unEmp.No == dep.NoService
                               select unEmp).FirstOrDefault();
                var index = dgDepenseEmploye.Rows.Add();
                dgDepenseEmploye.Rows[index].Cells[0].Value = service.Employes.Nom + ", " + service.Employes.Prenom;
                dgDepenseEmploye.Rows[index].Cells[1].Value = service.TypeService;
                dgDepenseEmploye.Rows[index].Cells[2].Value = dep.Montant.ToString("C") + "$";
                dgDepenseEmploye.Rows[index].Cells[3].Value = dep.DateDepense.ToShortDateString();
                dgDepenseEmploye.Rows[index].Cells[4].Value = dep.Abonnements.Nom + ", " + dep.Abonnements.Prenom;
            }

            //Remplir dépenses par abonné
            var depenseParAbo = from uneDep in monDataContext.Depenses
                                    orderby uneDep.IdAbonnement
                                    select uneDep;
            foreach (Depenses dep in depenseParAbo)
            {
                var service = (from unEmp in monDataContext.Services
                               where unEmp.No == dep.NoService
                               select unEmp).FirstOrDefault();
                var index = dgDepenseAbo.Rows.Add();
                dgDepenseAbo.Rows[index].Cells[4].Value = service.Employes.Nom + ", " + service.Employes.Prenom;
                dgDepenseAbo.Rows[index].Cells[3].Value = service.TypeService;
                dgDepenseAbo.Rows[index].Cells[1].Value = dep.Montant.ToString("C");
                dgDepenseAbo.Rows[index].Cells[2].Value = dep.DateDepense.ToShortDateString();
                dgDepenseAbo.Rows[index].Cells[0].Value = dep.Abonnements.Nom + ", " + dep.Abonnements.Prenom;
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }
    }
}
