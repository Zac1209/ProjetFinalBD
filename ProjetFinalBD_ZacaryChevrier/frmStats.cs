using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinalBD_ZacaryChevrier
{
    public partial class frmStats : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        public frmStats()
        {
            InitializeComponent();

            var lstAnneeAbonnement = (from unAbo in monDataContext.Abonnements
                                     select unAbo.DateAbonnement.Year).Distinct();
            var lstDepense = from dep in monDataContext.Depenses
                             select dep;
            List < TypesAbonnement > lstTypeAbo = (from type in monDataContext.TypesAbonnement
                                                   select type).ToList();

            
            foreach(int annee in lstAnneeAbonnement)
            {
                double depenseTotalAnneePourTous = 0.0;
                int nbAboTotalAnneePourTous = 0;
                List<TreeNode> childsAbo = new List<TreeNode>();
                List<TreeNode> childsDepAnneeAbo = new List<TreeNode>();

                foreach (TypesAbonnement typeAbo in lstTypeAbo)
                {
                    int count = 0;
                    var lstAboParAnnee = from unAbo in monDataContext.Abonnements
                                         where unAbo.TypesAbonnement == typeAbo
                                         select unAbo;                    
                    foreach (Abonnements unAbo in lstAboParAnnee)
                    {
                        //Abonnement par année et type
                        String resultString = Regex.Match(unAbo.Id, @"\d+").Value;
                        int idEnChiffreNew = Int32.Parse(resultString);
                        String lettreDefinitionAbonnement = unAbo.Id.Substring(unAbo.Id.IndexOf(idEnChiffreNew.ToString()) + idEnChiffreNew.ToString().Length, 1);
                        if (lettreDefinitionAbonnement.ToUpper().Equals("P"))
                        {
                            count++;
                            nbAboTotalAnneePourTous++;
                            //Dépenses par année et abonnement
                            var lstDepenseAnneeAbo = lstDepense.Where(x => x.DateDepense.Year == annee).Where(x => x.Abonnements.Equals(unAbo)).Select(x => x.Montant);
                            double depenseTotalAnnee;
                            if (lstDepenseAnneeAbo.Count() == 0)
                                depenseTotalAnnee = 0.00;
                            else
                                depenseTotalAnnee = lstDepenseAnneeAbo.Sum();
                            depenseTotalAnneePourTous += depenseTotalAnnee;
                            childsDepAnneeAbo.Add(new TreeNode(unAbo.Id + ": " + depenseTotalAnnee.ToString("C")));                
                        }                       
                    }
                    childsAbo.Add(new TreeNode(typeAbo.Description + ": " + count + " abonnement(s)"));
                }
                TreeNode treeNodeAbo = new TreeNode(annee.ToString() + ": " + nbAboTotalAnneePourTous + " abonnement(s)",childsAbo.ToArray());
                TreeNode treeNodeDepAnneeAbo = new TreeNode(annee.ToString() + ": " + depenseTotalAnneePourTous.ToString("C"), childsDepAnneeAbo.ToArray());
                tvAbo.Nodes.Add(treeNodeAbo);
                tvDepenseAnneAbo.Nodes.Add(treeNodeDepAnneeAbo);
            }
            if(tvAbo.Nodes.Count != 0)
                tvAbo.Nodes[0].Expand();
            if (tvDepenseAnneAbo.Nodes.Count != 0)
                tvDepenseAnneAbo.Nodes[0].Expand();
            


            //Dépenses par mois et abonnement
            for (int i = 1; i < 13; i++)
            {
                double depenseTotalMoisPourTous = 0.0;
                List<TreeNode> childsDepMoisAbo = new List<TreeNode>();
                var lstAboParAnnee = from unAbo in monDataContext.Abonnements                                     
                                     select unAbo;
                foreach (Abonnements unAbo in lstAboParAnnee)
                {
                    String resultString = Regex.Match(unAbo.Id, @"\d+").Value;
                    int idEnChiffreNew = Int32.Parse(resultString);
                    String lettreDefinitionAbonnement = unAbo.Id.Substring(unAbo.Id.IndexOf(idEnChiffreNew.ToString()) + idEnChiffreNew.ToString().Length, 1);
                    if (lettreDefinitionAbonnement.ToUpper().Equals("P"))
                    {
                        var lstDepenseAnneeAbo = lstDepense.Where(x => x.DateDepense.Month == i).Where(x => x.Abonnements.Equals(unAbo)).Select(x => x.Montant);
                        double depenseTotalMois;
                        if (lstDepenseAnneeAbo.Count() == 0)
                            depenseTotalMois = 0.00;
                        else
                            depenseTotalMois = lstDepenseAnneeAbo.Sum();
                        depenseTotalMoisPourTous += depenseTotalMois;
                        childsDepMoisAbo.Add(new TreeNode(unAbo.Id + ": " + depenseTotalMois.ToString("C")));
                    }
                }
                string nomMois = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                TreeNode treeNodeDepMoisAbo = new TreeNode(nomMois + ": " + depenseTotalMoisPourTous.ToString("C"), childsDepMoisAbo.ToArray());
                tvDepenseMoisAbo.Nodes.Add(treeNodeDepMoisAbo);

            }
            if (tvDepenseMoisAbo.Nodes.Count != 0)
                tvDepenseMoisAbo.Nodes[0].Expand();
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
