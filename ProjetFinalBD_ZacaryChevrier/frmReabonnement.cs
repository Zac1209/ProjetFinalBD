using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinalBD_ZacaryChevrier
{
    public partial class frmReabonnement : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        public frmReabonnement()
        {
            InitializeComponent();
            List<Abonnements> lstAboPrincipal = new List<Abonnements>();
            var abo = from unAbo in monDataContext.Abonnements
                      select unAbo;
            foreach(Abonnements unAbo in abo)
            {
                String resultString = Regex.Match(unAbo.Id, @"\d+").Value;
                int idEnChiffreNew = Int32.Parse(resultString);
                String lettreDefinitionAbonnement = unAbo.Id.Substring(unAbo.Id.IndexOf(idEnChiffreNew.ToString()) + idEnChiffreNew.ToString().Length, 1);
                if (lettreDefinitionAbonnement.ToUpper().Equals("P"))
                {
                    int countReabonnement = (from Reabo in monDataContext.Reabonnements
                                            where Reabo.IdAbonnement == unAbo.Id && Reabo.DateRenouvellement.Year == DateTime.Now.Year
                                            select Reabo).Count();
                    if(countReabonnement < 2)
                        lstAboPrincipal.Add(unAbo);
                }
            }
            abonnementsBindingSource.DataSource = lstAboPrincipal;                           
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            Reabonnements reabo = new Reabonnements
            {
                IdAbonnement = abonnementsDataGridView.SelectedRows[0].Cells[0].Value.ToString(),
                DateRenouvellement = DateTime.Now,
                Remarque = tbRemarque.Text.Trim()
            };
            monDataContext.Reabonnements.InsertOnSubmit(reabo);
            try
            {
                monDataContext.SubmitChanges();
                MessageBox.Show("Succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Erreur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e1);
            }
        }

        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
