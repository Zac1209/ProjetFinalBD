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
    public partial class ajoutModEmploye : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        String regexNom = "[A-Z][a-zA-Z][^#&<>\"~;$^%{}?]{1,20}$";
        String regexEmail = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
        Boolean binModeAjout = true;
        int employeID = 0;
        public ajoutModEmploye(Boolean binModeAjout = true, int employeID = 0)
        {
            InitializeComponent();
            this.binModeAjout = binModeAjout;
            this.employeID = employeID;
            if (binModeAjout)
            {
                tbNo.Text = ((from unEmploye in monDataContext.Employes
                              orderby unEmploye.No descending
                              select (int)unEmploye.No).FirstOrDefault() + 1).ToString();
            }
            //Init la list de Sexe
            Dictionary<String, String> dicCbSexe = new Dictionary<String,String>();
            dicCbSexe.Add("H", "Homme");
            dicCbSexe.Add("F", "Femme");
            cbSexe.DataSource = new BindingSource(dicCbSexe, null);
            cbSexe.DisplayMember = "Value";
            cbSexe.ValueMember = "Key";

            //Init type employe
            cbTypeEmpl.DataSource = from unType in monDataContext.TypesEmploye
                                   where unType.Description != "Administrateur"
                                   select unType;
            cbTypeEmpl.DisplayMember = "Description";
            cbTypeEmpl.ValueMember = "No";

            //Init provinces
            cbProvince.DataSource = from province in monDataContext.Provinces
                                    select province;
            cbProvince.DisplayMember = "Nom";
            cbProvince.ValueMember = "Id";


            //Remplir champs si en mode modification
            if (!binModeAjout)
            {
                cbTypeEmpl.Enabled = false;
                lblTitre.Text = "Modification d'un employé";
                btnAjouter.Text = "Modifier";
                Employes employe = (from unEmploye in monDataContext.Employes
                                    where unEmploye.No == employeID
                                    select unEmploye).FirstOrDefault();
                tbNo.Text = employe.No.ToString();
                tbNom.Text = employe.Nom;
                tbPrenom.Text = employe.Prenom;
                cbSexe.SelectedValue = employe.Sexe;
                tbAge.Text = employe.Age.ToString();
                tbMDP.Text = employe.MotDePasse;
                tbTel.Text = employe.Telephone;
                tbCell.Text = employe.Cellulaire;
                tbEmail.Text = employe.Courriel;
                tbSalaire.Text = employe.SalaireHoraire.ToString();
                cbTypeEmpl.SelectedValue = employe.NoTypeEmploye;
                tbRemarque.Text = employe.Remarque;
                tbNoCivique.Text = employe.NoCivique.ToString();
                tbRue.Text = employe.Rue;
                tbVille.Text = employe.Ville;
                tbCodePostal.Text = employe.CodePostal;
                cbProvince.SelectedValue = employe.IdProvince;
            }
        }

        #region Validating
        private void tbNom_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if (tbNom.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer une valeur";
            }
            else
            {
                Match match = Regex.Match(tbNom.Text.Trim(), regexNom, RegexOptions.IgnoreCase);
                if (!match.Success)
                {
                    e.Cancel = true;
                    strErreur = "Format de nom invalide";
                }
            }
            errorProvider1.SetError(tbNom, strErreur);
        }

        private void tbPrenom_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if (tbPrenom.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer une valeur";
            }
            else
            {
                Match match = Regex.Match(tbPrenom.Text.Trim(), regexNom,RegexOptions.IgnoreCase);
                if (!match.Success)
                {
                    e.Cancel = true;
                    strErreur = "Format de prénom invalide";
                }
            }
            errorProvider1.SetError(tbPrenom, strErreur);
        }

        private void tbAge_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if (tbAge.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer une valeur";
            }
            else
            {
                int age = 0;
                if(!Int32.TryParse(tbAge.Text.Trim(), out age))
                {
                    e.Cancel = true;
                    strErreur = "Veuillez entrer une valeur numérique";
                }
                else
                {
                    if(age < 16 || age > 65)
                    {
                        e.Cancel = true;
                        strErreur = "Veuillez entrer un âge entre 16 et 65 ans";
                    }
                }
            }
            errorProvider1.SetError(tbAge, strErreur);
        }

        private void tbMDP_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if (tbMDP.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer une valeur";
            }
            errorProvider1.SetError(tbMDP, strErreur);
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if (tbEmail.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer une valeur";
            }
            else
            {
                Match match = Regex.Match(tbEmail.Text.Trim(), regexEmail, RegexOptions.IgnoreCase);
                if (!match.Success)
                {
                    e.Cancel = true;
                    strErreur = "Format de courriel";
                }
            }
            errorProvider1.SetError(tbEmail, strErreur);
        }

        private void tbTel_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if (!tbTel.MaskCompleted)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer un numéro de téléphone";
            }
            errorProvider1.SetError(tbTel, strErreur);
        }

        private void tbCell_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if(tbCell.Text.Trim() != String.Empty)
            {
                if (!tbCell.MaskCompleted)
                {
                    e.Cancel = true;
                    strErreur = "Veuillez entrer un numéro de téléphone";
                }
            }
            
            errorProvider1.SetError(tbCell, strErreur);
        }

        private void tbNoCivique_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if (tbNoCivique.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer une valeur";
            }
            else
            {
                int no = 0;
                if (!Int32.TryParse(tbNoCivique.Text.Trim(), out no))
                {
                    e.Cancel = true;
                    strErreur = "Veuillez entrer une valeur numérique";
                }
            }
            errorProvider1.SetError(tbNoCivique, strErreur);
        }

        private void tbRue_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if (tbRue.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer une valeur";
            }
            errorProvider1.SetError(tbRue, strErreur);
        }

        private void tbVille_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if (tbVille.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer une valeur";
            }
            errorProvider1.SetError(tbVille, strErreur);
        }

        private void tbCodePostal_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if (tbCodePostal.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer une valeur";
            }else if(tbCodePostal.Text.Replace(" ","").Length != 6)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer un code postal de 6 chiffres";

            }
            errorProvider1.SetError(tbCodePostal, strErreur);
        }

        private void tbSalaire_Validating(object sender, CancelEventArgs e)
        {
            string strErreur = String.Empty;
            if (tbSalaire.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                strErreur = "Veuillez entrer une valeur";
            }
            else
            {
                double salaire = 0;
                if (!Double.TryParse(tbSalaire.Text.Trim().Replace('.',','), out salaire))
                {
                    e.Cancel = true;
                    strErreur = "Veuillez entrer une valeur numérique";
                }
                else
                {
                    if (salaire < 10.00 || salaire > 500.00)
                    {
                        e.Cancel = true;
                        strErreur = "Veuillez entrer un salaire entre 10.00$ et 500.00$";
                    }
                }
            }
            errorProvider1.SetError(tbSalaire, strErreur);
        }

        #endregion

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            
            Employes employe = new Employes
            {
                No = Int32.Parse(tbNo.Text.Trim()),
                MotDePasse = tbMDP.Text.Trim(),
                Nom = tbNom.Text.Trim(),
                Prenom = tbPrenom.Text.Trim(),
                Sexe = cbSexe.SelectedValue.ToString(),
                Age = Int32.Parse(tbAge.Text.Trim()),
                NoCivique = Int32.Parse(tbNoCivique.Text.Trim()),
                Rue = tbRue.Text.Trim(),
                Ville = tbVille.Text.Trim(),
                IdProvince = cbProvince.SelectedValue.ToString(),
                CodePostal = String.Format(tbCodePostal.Text.Trim().ToUpper()),
                Telephone = tbTel.Text.Trim(),
                Cellulaire = tbCell.Text.Trim() == String.Empty ? null : tbCell.Text.Trim(),
                Courriel = tbEmail.Text.Trim(),
                SalaireHoraire = Int32.Parse(tbSalaire.Text.Trim()),
                NoTypeEmploye = Int32.Parse(cbTypeEmpl.SelectedValue.ToString()),
                Remarque = tbRemarque.Text.Trim()
            };
            if (btnAjouter.Text == "Ajouter")
                monDataContext.Employes.InsertOnSubmit(employe);
            else
            {
                Employes a = (from unEmploye in monDataContext.Employes
                        where unEmploye.No == Int32.Parse(tbNo.Text.Trim())
                        select unEmploye).FirstOrDefault();
                a.Nom = employe.Nom;
                a.Prenom = employe.Prenom;
                a.Sexe = employe.Sexe;
                a.Age = employe.Age;
                a.MotDePasse = employe.MotDePasse;
                a.Telephone = employe.Telephone;
                a.Cellulaire = employe.Cellulaire;
                a.Courriel = employe.Courriel;
                a.SalaireHoraire = employe.SalaireHoraire;
                a.Remarque = employe.Remarque;
                a.NoCivique = employe.NoCivique;
                a.Rue = employe.Rue;
                a.Ville = employe.Ville;
                a.CodePostal = employe.CodePostal;
                a.IdProvince = employe.IdProvince;
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
