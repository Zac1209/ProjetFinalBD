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
    public partial class ajoutAbo : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        String regexNom = "[A-Z][a-zA-Z][^#&<>\"~;$^%{}?]{1,20}$";
        String regexEmail = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
        List<Abonnements> lstAboAAjouter = new List<Abonnements>();
        String strTemplateID = "";
        int intNbEnfant = 0;
        int intNbEnfantActuel = 3;
        public ajoutAbo()
        {
            InitializeComponent();

            dtDateAbo.Value = DateTime.Now;
            //Init la list de Sexe
            Dictionary<String, String> dicCbSexe = new Dictionary<String,String>();
            dicCbSexe.Add("H", "Homme");
            dicCbSexe.Add("F", "Femme");
            cbSexe.DataSource = new BindingSource(dicCbSexe, null);
            cbSexe.DisplayMember = "Value";
            cbSexe.ValueMember = "Key";

            //Init type abonnement
            cbTypeAbo.DataSource = from unType in monDataContext.TypesAbonnement
                                   select unType;
            cbTypeAbo.DisplayMember = "Description";
            cbTypeAbo.ValueMember = "No";

            //Init provinces
            cbProvince.DataSource = from province in monDataContext.Provinces
                                    select province;
            cbProvince.DisplayMember = "Nom";
            cbProvince.ValueMember = "Id";

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

        private void dtNaissance_Validating(object sender, CancelEventArgs e)
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dtNaissance.Value.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            string strErreur = String.Empty;

            if(Int32.Parse(cbTypeAbo.SelectedValue.ToString()) == 2)//Âge d'or
            {
                if (age < 60)
                {
                    e.Cancel = true;
                    strErreur = "Veuillez entrer un âge de minimum 60 ans pour l'âge d'or";
                }
            }
            else
            {
                if (btnAjouter.Text.Contains("enfant"))
                {
                    if (age >= 18 || age <= 0)
                    {
                        e.Cancel = true;
                        strErreur = "Veuillez entrer un âge entre 0 et 18 ans exclusivement pour un enfant";
                    }
                }
                else
                {
                    if (age < 18)
                    {
                        e.Cancel = true;
                        strErreur = "Veuillez entrer un âge de minimum 18 ans pour une personne qui n'est pas de l'âge d'or";
                    }
                }
            }
                   
            
            errorProvider1.SetError(dtNaissance, strErreur);
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

        #endregion

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if (cbTypeAbo.SelectedValue.ToString().Equals("1") ||
                cbTypeAbo.SelectedValue.ToString().Equals("2") ||
                (cbTypeAbo.SelectedValue.ToString().Equals("3") && lstAboAAjouter.Count() == 0) ||
                (cbTypeAbo.SelectedValue.ToString().Equals("4") && lstAboAAjouter.Count() == 0) ||
                (cbTypeAbo.SelectedValue.ToString().Equals("5") && lstAboAAjouter.Count() == 0) ||
                (cbTypeAbo.SelectedValue.ToString().Equals("6") && lstAboAAjouter.Count() == 0))
            {
                //Trouver le plus grand chiffre associé à des abonnements PRINCIPAL avec le même nom et l'incrémenter de 1
                var listAbonnementAvecMemeNomFamille = from unAbo in monDataContext.Abonnements
                                                       where unAbo.Id.Contains(tbNom.Text.Trim())
                                                       select unAbo;
                int numActuel;
                if (listAbonnementAvecMemeNomFamille != null)
                {
                    int idEnChiffreOld = 0;
                    foreach (Abonnements abo in listAbonnementAvecMemeNomFamille)
                    {
                        String resultString = Regex.Match(abo.Id, @"\d+").Value;
                        int idEnChiffreNew = Int32.Parse(resultString);

                        //Check si c'est le user principal de la famille
                        String lettreDefinitionAbonnement = abo.Id.Substring(abo.Id.IndexOf(idEnChiffreNew.ToString()) + idEnChiffreNew.ToString().Length, 1);
                        if (lettreDefinitionAbonnement.ToUpper().Equals("P"))
                        {
                            if (idEnChiffreNew > idEnChiffreOld)
                                idEnChiffreOld = idEnChiffreNew;
                        }

                    }
                    numActuel = idEnChiffreOld;
                }
                else
                    numActuel = 0;
                int idNum = numActuel + 1;
                strTemplateID = tbNom.Text.Trim() + idNum;

                //Créer l'abonnement
                Abonnements abonnementPrincipal = new Abonnements
                {
                    Id = strTemplateID + "P",
                    DateAbonnement = dtDateAbo.Value,
                    Nom = tbNom.Text.Trim(),
                    Prenom = tbPrenom.Text.Trim(),
                    Sexe = cbSexe.SelectedValue.ToString(),
                    DateNaissance = dtNaissance.Value,
                    NoCivique = Int32.Parse(tbNoCivique.Text.Trim()),
                    Rue = tbRue.Text.Trim(),
                    Ville = tbVille.Text.Trim(),
                    IdProvince = cbProvince.SelectedValue.ToString(),
                    CodePostal = String.Format(tbCodePostal.Text.Trim().ToUpper()),
                    Telephone = tbTel.Text.Trim(),
                    Cellulaire = tbCell.Text.Trim() == String.Empty ? null : tbCell.Text.Trim(),
                    Courriel = tbEmail.Text.Trim(),
                    NoTypeAbonnement = Int32.Parse(cbTypeAbo.SelectedValue.ToString()),
                    Remarque = tbRemarque.Text.Trim()
                };
                lstAboAAjouter.Add(abonnementPrincipal);
                btnAjouter.Text = "Ajouter un/une conjoint(e)";
                if (cbTypeAbo.SelectedValue.ToString().Equals("6"))
                {
                    Boolean binReponseValide = false;
                    while (!binReponseValide)
                    {
                        string reponse = Microsoft.VisualBasic.Interaction.InputBox("Combien d'enfants avez-vous?", "Questionnaire", "3");
                        if (!Int32.TryParse(reponse, out intNbEnfant))
                        {
                            MessageBox.Show("Veuillez entrer une valeur numérique!");
                        }
                        else if (intNbEnfant < 3)
                            MessageBox.Show("Veuillez entrer au moins 3 enfants!");
                        else
                            binReponseValide = true;
                    }
                }
                resetZonePourEntrerNewPersonne();
            }
            else if ((cbTypeAbo.SelectedValue.ToString().Equals("3") && lstAboAAjouter.Count() == 1) ||
                (cbTypeAbo.SelectedValue.ToString().Equals("4") && lstAboAAjouter.Count() == 1) ||
                (cbTypeAbo.SelectedValue.ToString().Equals("5") && lstAboAAjouter.Count() == 1) ||
                (cbTypeAbo.SelectedValue.ToString().Equals("6") && lstAboAAjouter.Count() == 1))
            {
                Abonnements abonnementConjoint = new Abonnements
                {
                    Id = strTemplateID + cbSexe.SelectedValue.ToString() + "0",
                    DateAbonnement = dtDateAbo.Value,
                    Nom = tbNom.Text.Trim(),
                    Prenom = tbPrenom.Text.Trim(),
                    Sexe = cbSexe.SelectedValue.ToString(),
                    DateNaissance = dtNaissance.Value,
                    NoCivique = Int32.Parse(tbNoCivique.Text.Trim()),
                    Rue = tbRue.Text.Trim(),
                    Ville = tbVille.Text.Trim(),
                    IdProvince = cbProvince.SelectedValue.ToString(),
                    CodePostal = String.Format(tbCodePostal.Text.Trim().ToUpper()),
                    Telephone = tbTel.Text.Trim(),
                    Cellulaire = tbCell.Text.Trim() == String.Empty ? null : tbCell.Text.Trim(),
                    Courriel = tbEmail.Text.Trim(),
                    NoTypeAbonnement = Int32.Parse(cbTypeAbo.SelectedValue.ToString()),
                    Remarque = tbRemarque.Text.Trim()
                };
                lstAboAAjouter.Add(abonnementConjoint);
                btnAjouter.Text = "Ajouter un enfant";
                resetZonePourEntrerNewPersonne();
            }
            else if ((cbTypeAbo.SelectedValue.ToString().Equals("4") && lstAboAAjouter.Count() == 2) ||
               (cbTypeAbo.SelectedValue.ToString().Equals("5") && lstAboAAjouter.Count() == 2) ||
               (cbTypeAbo.SelectedValue.ToString().Equals("6") && lstAboAAjouter.Count() == 2))
            {
                Abonnements enfant = new Abonnements
                {
                    Id = strTemplateID + "E1",
                    DateAbonnement = dtDateAbo.Value,
                    Nom = tbNom.Text.Trim(),
                    Prenom = tbPrenom.Text.Trim(),
                    Sexe = cbSexe.SelectedValue.ToString(),
                    DateNaissance = dtNaissance.Value,
                    NoCivique = Int32.Parse(tbNoCivique.Text.Trim()),
                    Rue = tbRue.Text.Trim(),
                    Ville = tbVille.Text.Trim(),
                    IdProvince = cbProvince.SelectedValue.ToString(),
                    CodePostal = String.Format(tbCodePostal.Text.Trim().ToUpper()),
                    Telephone = tbTel.Text.Trim(),
                    Cellulaire = tbCell.Text.Trim() == String.Empty ? null : tbCell.Text.Trim(),
                    Courriel = tbEmail.Text.Trim(),
                    NoTypeAbonnement = Int32.Parse(cbTypeAbo.SelectedValue.ToString()),
                    Remarque = tbRemarque.Text.Trim()
                };
                lstAboAAjouter.Add(enfant);
                resetZonePourEntrerNewPersonne();
            }
            else if ((cbTypeAbo.SelectedValue.ToString().Equals("5") && lstAboAAjouter.Count() == 3) ||
               (cbTypeAbo.SelectedValue.ToString().Equals("6") && lstAboAAjouter.Count() == 3))
            {
                Abonnements enfant = new Abonnements
                {
                    Id = strTemplateID + "E2",
                    DateAbonnement = dtDateAbo.Value,
                    Nom = tbNom.Text.Trim(),
                    Prenom = tbPrenom.Text.Trim(),
                    Sexe = cbSexe.SelectedValue.ToString(),
                    DateNaissance = dtNaissance.Value,
                    NoCivique = Int32.Parse(tbNoCivique.Text.Trim()),
                    Rue = tbRue.Text.Trim(),
                    Ville = tbVille.Text.Trim(),
                    IdProvince = cbProvince.SelectedValue.ToString(),
                    CodePostal = String.Format(tbCodePostal.Text.Trim().ToUpper()),
                    Telephone = tbTel.Text.Trim(),
                    Cellulaire = tbCell.Text.Trim() == String.Empty ? null : tbCell.Text.Trim(),
                    Courriel = tbEmail.Text.Trim(),
                    NoTypeAbonnement = Int32.Parse(cbTypeAbo.SelectedValue.ToString()),
                    Remarque = tbRemarque.Text.Trim()
                };
                lstAboAAjouter.Add(enfant);
                resetZonePourEntrerNewPersonne();
            }
            else
            {
                
                if(intNbEnfantActuel <= intNbEnfant)
                {
                    Abonnements enfant = new Abonnements
                    {
                        Id = strTemplateID + "E" + intNbEnfantActuel,
                        DateAbonnement = dtDateAbo.Value,
                        Nom = tbNom.Text.Trim(),
                        Prenom = tbPrenom.Text.Trim(),
                        Sexe = cbSexe.SelectedValue.ToString(),
                        DateNaissance = dtNaissance.Value,
                        NoCivique = Int32.Parse(tbNoCivique.Text.Trim()),
                        Rue = tbRue.Text.Trim(),
                        Ville = tbVille.Text.Trim(),
                        IdProvince = cbProvince.SelectedValue.ToString(),
                        CodePostal = String.Format(tbCodePostal.Text.Trim().ToUpper()),
                        Telephone = tbTel.Text.Trim(),
                        Cellulaire = tbCell.Text.Trim() == String.Empty ? null : tbCell.Text.Trim(),
                        Courriel = tbEmail.Text.Trim(),
                        NoTypeAbonnement = Int32.Parse(cbTypeAbo.SelectedValue.ToString()),
                        Remarque = tbRemarque.Text.Trim()
                    };
                    intNbEnfantActuel++;
                    lstAboAAjouter.Add(enfant);
                    resetZonePourEntrerNewPersonne();
                }                
            }



            if (cbTypeAbo.SelectedValue.ToString().Equals("1") ||
                cbTypeAbo.SelectedValue.ToString().Equals("2") ||
                (cbTypeAbo.SelectedValue.ToString().Equals("3") && lstAboAAjouter.Count() == 2) ||
                (cbTypeAbo.SelectedValue.ToString().Equals("4") && lstAboAAjouter.Count() == 3) ||
                (cbTypeAbo.SelectedValue.ToString().Equals("5") && lstAboAAjouter.Count() == 4) ||
                (cbTypeAbo.SelectedValue.ToString().Equals("6") && lstAboAAjouter.Count() == (intNbEnfant + 2))) 
            {
                foreach(Abonnements abo in lstAboAAjouter)
                {
                    monDataContext.Abonnements.InsertOnSubmit(abo);
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
            
               
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetZonePourEntrerNewPersonne()
        {
            tbNom.Clear();
            tbPrenom.Clear();
            cbSexe.SelectedValue = "H";
            dtNaissance.ResetText();
            tbTel.Clear();
            tbCell.Clear();
            tbEmail.Clear();
            cbTypeAbo.Enabled = false;
            tbNoCivique.Enabled = false;
            tbRue.Enabled = false;
            tbVille.Enabled = false;
            tbCodePostal.Enabled = false;
            cbProvince.Enabled = false;
        }

    }
}
