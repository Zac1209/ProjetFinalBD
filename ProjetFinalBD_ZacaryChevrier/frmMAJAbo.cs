using JThomas.Controls;
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
    public partial class frmMAJAbo : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        List<Abonnements> lstAboToModify = new List<Abonnements>();
        String regexNom = "[A-Z][a-zA-Z][^#&<>\"~;$^%{}?]{1,20}$";
        String regexEmail = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";

        public frmMAJAbo()
        {
            InitializeComponent();
            List<Abonnements> lstAboPrincipal = new List<Abonnements>();
            ((DataGridViewComboBoxColumn)abonnementsDataGridView.Columns[9]).DataSource = from Pro in monDataContext.Provinces
                                                                                          select Pro;
            ((DataGridViewComboBoxColumn)abonnementsDataGridView.Columns[9]).DisplayMember = "Nom";
            ((DataGridViewComboBoxColumn)abonnementsDataGridView.Columns[9]).ValueMember = "Id";
            Dictionary<String, String> dicSexe = new Dictionary<string, string>();
            dicSexe.Add("H", "Homme");
            dicSexe.Add("F", "Femme");
            ((DataGridViewComboBoxColumn)abonnementsDataGridView.Columns[4]).DataSource = new BindingSource(dicSexe, null);
            ((DataGridViewComboBoxColumn)abonnementsDataGridView.Columns[4]).DisplayMember = "Value";
            ((DataGridViewComboBoxColumn)abonnementsDataGridView.Columns[4]).ValueMember = "Key";

            ((DataGridViewComboBoxColumn)abonneSecondaireDataGridView.Columns[12]).DataSource = from Pro in monDataContext.Provinces
                                                                                          select Pro;
            ((DataGridViewComboBoxColumn)abonneSecondaireDataGridView.Columns[12]).DisplayMember = "Nom";
            ((DataGridViewComboBoxColumn)abonneSecondaireDataGridView.Columns[12]).ValueMember = "Id";
            ((DataGridViewComboBoxColumn)abonneSecondaireDataGridView.Columns[3]).DataSource = new BindingSource(dicSexe, null);
            ((DataGridViewComboBoxColumn)abonneSecondaireDataGridView.Columns[3]).DisplayMember = "Value";
            ((DataGridViewComboBoxColumn)abonneSecondaireDataGridView.Columns[3]).ValueMember = "Key";

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

            
            
        }

        private void abonnementsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (abonnementsDataGridView.SelectedRows.Count != 0)
            {
                String aboId = abonnementsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                String aboIdTemplate = getIdentifiantAbo(aboId);
                List<Abonnements> lstAboSecondaire = new List<Abonnements>();
                var abo = from unAbo in monDataContext.Abonnements
                          where unAbo.Id.Contains(aboIdTemplate)
                          select unAbo;
                foreach (Abonnements unAbo in abo)
                {
                    String resultString = Regex.Match(unAbo.Id, @"\d+").Value;
                    int idEnChiffreNew = Int32.Parse(resultString);
                    String lettreDefinitionAbonnement = unAbo.Id.Substring(unAbo.Id.IndexOf(idEnChiffreNew.ToString()) + idEnChiffreNew.ToString().Length, 1);
                    String nomAbo = unAbo.Id.Substring(0, unAbo.Id.IndexOf(idEnChiffreNew.ToString())) + idEnChiffreNew.ToString();
                    if (!lettreDefinitionAbonnement.ToUpper().Equals("P"))
                    {
                        lstAboSecondaire.Add(unAbo);
                    }
                }
                abonneSecondaireDataGridView.DataSource = lstAboSecondaire;
            }
        }

        private String getIdentifiantAbo(String id)
        {
            String resultString = Regex.Match(id, @"\d+").Value;
            int idEnChiffreNew = Int32.Parse(resultString);
            String nomAbo = id.Substring(0, id.IndexOf(idEnChiffreNew.ToString())) + idEnChiffreNew.ToString();
            return nomAbo;
        }

        private void abonnementsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Abonnements abonneModifier = (from unAbo in monDataContext.Abonnements
                                          where unAbo.Id == abonnementsDataGridView.SelectedRows[0].Cells[0].Value.ToString()
                                          select unAbo).FirstOrDefault();
            abonneModifier.Prenom = abonnementsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            abonneModifier.Sexe = abonnementsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            abonneModifier.NoCivique = int.Parse(abonnementsDataGridView.SelectedRows[0].Cells[6].Value.ToString());
            abonneModifier.Rue = abonnementsDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            abonneModifier.Ville = abonnementsDataGridView.SelectedRows[0].Cells[8].Value.ToString();
            abonneModifier.IdProvince = abonnementsDataGridView.SelectedRows[0].Cells[9].Value.ToString();
            abonneModifier.CodePostal = abonnementsDataGridView.SelectedRows[0].Cells[10].Value.ToString();
            abonneModifier.Telephone = abonnementsDataGridView.SelectedRows[0].Cells[11].Value.ToString();
            abonneModifier.Cellulaire = nullToString(abonnementsDataGridView.SelectedRows[0].Cells[12].Value);
            abonneModifier.Courriel = abonnementsDataGridView.SelectedRows[0].Cells[13].Value.ToString();
            abonneModifier.Remarque = nullToString(abonnementsDataGridView.SelectedRows[0].Cells[15].Value);
            
        }

        private void abonneSecondaireDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Abonnements abonneModifier = (from unAbo in monDataContext.Abonnements
                                          where unAbo.Id == abonneSecondaireDataGridView.SelectedRows[0].Cells[0].Value.ToString()
                                          select unAbo).FirstOrDefault();
            abonneModifier.Prenom = abonneSecondaireDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            abonneModifier.Sexe = abonneSecondaireDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            abonneModifier.NoCivique = int.Parse(abonneSecondaireDataGridView.SelectedRows[0].Cells[8].Value.ToString());
            abonneModifier.Rue = abonneSecondaireDataGridView.SelectedRows[0].Cells[9].Value.ToString();
            abonneModifier.Ville = abonneSecondaireDataGridView.SelectedRows[0].Cells[10].Value.ToString();
            abonneModifier.IdProvince = abonneSecondaireDataGridView.SelectedRows[0].Cells[12].Value.ToString();
            abonneModifier.CodePostal = abonneSecondaireDataGridView.SelectedRows[0].Cells[11].Value.ToString();
            abonneModifier.Telephone = abonneSecondaireDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            abonneModifier.Cellulaire = nullToString(abonneSecondaireDataGridView.SelectedRows[0].Cells[12].Value);
            abonneModifier.Courriel = abonneSecondaireDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            abonneModifier.Remarque = nullToString(abonneSecondaireDataGridView.SelectedRows[0].Cells[13].Value);
            
        }

        private void abonnementsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            validateDataGridView(e, abonnementsDataGridView);
        }

        private void validateDataGridView(DataGridViewCellValidatingEventArgs e, DataGridView dg)
        {
            string headerText = dg.Columns[e.ColumnIndex].HeaderText;
            string data = e.FormattedValue.ToString().Trim();
            
            string strErreur = String.Empty;
            switch (headerText)
            {
                case "Nom":
                case "Prenom":
                    if (data == String.Empty)
                    {
                        e.Cancel = true;
                        strErreur = "Veuillez entrer une valeur";
                    }
                    else
                    {
                        Match match = Regex.Match(data, regexNom, RegexOptions.IgnoreCase);
                        if (!match.Success)
                        {
                            e.Cancel = true;
                            strErreur = "Format de nom invalide";
                        }
                    }
                    break;
                case "NoCivique":
                    if (data == String.Empty)
                    {
                        e.Cancel = true;
                        strErreur = "Veuillez entrer une valeur";
                    }
                    else
                    {
                        int no = 0;
                        if (!Int32.TryParse(data, out no))
                        {
                            e.Cancel = true;
                            strErreur = "Veuillez entrer une valeur numérique";
                        }
                    }
                    break;
                case "Rue":
                case "Ville":
                    if (data == String.Empty)
                    {
                        e.Cancel = true;
                        strErreur = "Veuillez entrer une valeur";
                    }
                    break;
                case "CodePostal":
                    if (data == String.Empty)
                    {
                        e.Cancel = true;
                        strErreur = "Veuillez entrer une valeur";
                    }
                    else if (data.Replace(" ", "").Length != 6)
                    {
                        e.Cancel = true;
                        strErreur = "Veuillez entrer un code postal de 6 chiffres";

                    }
                    break;
                case "Telephone":
                case "Cellulaire":
                    if(data.Length != 14 && data.Length != 10)
                    {
                        e.Cancel = true;
                        strErreur = "Champs obligatoire";
                    }
                    break;
                case "Courriel":
                    if (data == String.Empty)
                    {
                        e.Cancel = true;
                        strErreur = "Veuillez entrer une valeur";
                    }
                    else
                    {
                        Match match = Regex.Match(data, regexEmail, RegexOptions.IgnoreCase);
                        if (!match.Success)
                        {
                            e.Cancel = true;
                            strErreur = "Format de courriel";
                        }
                    }
                    break;
            }
            if(!strErreur.Equals(""))
                MessageBox.Show(strErreur, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private String nullToString(object value)
        {
            return value == null ? "" : value.ToString();
        }

        private void abonneSecondaireDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            validateDataGridView(e, abonneSecondaireDataGridView);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*foreach(Abonnements abo in lstAboToModify)
            {
                monDataContext.Abonnements.InsertOnSubmit(abo);
            }*/
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
