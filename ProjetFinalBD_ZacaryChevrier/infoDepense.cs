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
    public partial class infoDepense : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        public infoDepense(int typeAbo, String idAbo, String nom, DateTime date, decimal montant, String typeService, String employe)
        {
            InitializeComponent();
            lblNom.Text = nom;
            lblDate.Text = date.ToShortDateString();
            lblMontant.Text = montant.ToString("C") + "$";
            lblService.Text = typeService;
            lblEmploye.Text = employe;

            decimal depensesTotal = (from uneDepense in monDataContext.Depenses
                                 where uneDepense.IdAbonnement == idAbo
                                 select (decimal)uneDepense.Montant).Sum();
            decimal depenseObligatoirePourAbonnement = (from depense in monDataContext.PrixDepensesAbonnements
                                                       where depense.NoTypeAbonnement == typeAbo
                                                       select depense.DepensesObligatoires).FirstOrDefault();
            lblTotal.Text = depensesTotal.ToString("C");
            lblRestant.Text = (depenseObligatoirePourAbonnement - depensesTotal).ToString("C");
        }
    }
}
