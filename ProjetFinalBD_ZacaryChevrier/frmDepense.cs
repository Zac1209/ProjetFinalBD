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
    public partial class frmDepense : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        int serviceEmployeNo = 0;

        public frmDepense()
        {
            InitializeComponent();
            List<Abonnements> lstAboPrincipal = new List<Abonnements>();
            var abo = from unAbo in monDataContext.Abonnements
                      select unAbo;
            foreach (Abonnements unAbo in abo)
            {
                String resultString = Regex.Match(unAbo.Id, @"\d+").Value;
                int idEnChiffreNew = Int32.Parse(resultString);
                String lettreDefinitionAbonnement = unAbo.Id.Substring(unAbo.Id.IndexOf(idEnChiffreNew.ToString()) + idEnChiffreNew.ToString().Length, 1);
                if (lettreDefinitionAbonnement.ToUpper().Equals("P"))
                {                    
                    lstAboPrincipal.Add(unAbo);
                }
            }
            abonnementsBindingSource.DataSource = lstAboPrincipal;

            //Remplir liste service
            Dictionary<int, String> dicTypeService = new Dictionary<int, String>();
            dicTypeService.Add(5, "Magasin Pro Shop");
            dicTypeService.Add(6, "Restaurant");
            dicTypeService.Add(7, "Leçon de golf");
            cbTypeService.DataSource = new BindingSource(dicTypeService, null);
            cbTypeService.DisplayMember = "Value";
            cbTypeService.ValueMember = "Key";

            //Set automatiquement le type de service si applicable
            if(frmMenu.userConnect.NoTypeEmploye >= 5)
            {
                cbTypeService.SelectedValue = frmMenu.userConnect.NoTypeEmploye;
                cbTypeService.Enabled = false;

                //Ajouter le service pour l'employé s'il n'existe pas
                var service = (from unService in monDataContext.Services
                              where unService.TypeService == cbTypeService.SelectedText && unService.NoEmploye == frmMenu.userConnect.No
                              select unService).FirstOrDefault();
                if(service == null)
                {
                    int noService = (from unService in monDataContext.Services
                                     orderby unService.No descending
                                     select (int)unService.No).FirstOrDefault() + 1;
                    serviceEmployeNo = noService;
                    Services serviceToAdd = new Services
                    {
                        No = noService,
                        TypeService = cbTypeService.SelectedText,
                        NoEmploye = frmMenu.userConnect.No
                    };
                    monDataContext.Services.InsertOnSubmit(serviceToAdd);
                }
                else
                {
                    serviceEmployeNo = service.No;
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int noDepense = (from unDep in monDataContext.Depenses
                             orderby unDep.No descending
                             select (int)unDep.No).FirstOrDefault() + 1;
            Depenses depense = new Depenses
            {
                No = noDepense,
                IdAbonnement = abonnementsDataGridView.SelectedRows[0].Cells[0].Value.ToString(),
                DateDepense = DateTime.Now,
                Montant = tbMontant.Value,
                NoService = serviceEmployeNo,
                Remarque = tbRemarque.Text.Trim()
            };
            monDataContext.Depenses.InsertOnSubmit(depense);
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
    }
}
