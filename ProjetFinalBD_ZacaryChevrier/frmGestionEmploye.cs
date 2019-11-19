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
    public partial class frmGestionEmploye : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        int employeCount = 0;
        public frmGestionEmploye()
        {
            InitializeComponent();
            employeCount = monDataContext.Employes.Count();
            employesBindingSource.DataSource = from unEmploye in monDataContext.Employes
                                               orderby unEmploye.No
                                               select unEmploye;
        }


        private void employesDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0://Numéro d'employé

                    break;
                case 1://MDP

                    break;
                case 2://Nom

                    break;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new ajoutModEmploye()).ShowDialog();
            refresh();
            this.Show();
        }

        private void refresh()
        {
            monDataContext = new DataClasses1DataContext();
            employeCount = monDataContext.Employes.Count();
            employesBindingSource.DataSource = from unEmploye in monDataContext.Employes
                                               orderby unEmploye.No
                                               select unEmploye;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (frmMenu.userConnect.NoTypeEmploye != 1 && Int32.Parse(employesDataGridView.SelectedRows[0].Cells[0].Value.ToString()) == 1)
                MessageBox.Show("Seul l'administrateur peut modifier l'administrateur");
            else
            {
                this.Hide();
                (new ajoutModEmploye(false, Int32.Parse(employesDataGridView.SelectedRows[0].Cells[0].Value.ToString()))).ShowDialog();
                refresh();
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int noEmployeToDelete = Int32.Parse(employesDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            if (noEmployeToDelete == 1)
                MessageBox.Show("L'administrateur ne peut pas être supprimé");
            else if(noEmployeToDelete == frmMenu.userConnect.No && frmMenu.userConnect.NoTypeEmploye == 2)
                MessageBox.Show("Un membre de la direction ne peut pas s'auto-supprimer");
            else
            {
                var employeService = from unService in monDataContext.Services
                                     where unService.NoEmploye == noEmployeToDelete
                                     select unService;
                if (employeService.Count() != 0)
                    MessageBox.Show("Cette employé offre actuellement un ou des service(s)");
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet employé?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var employeToDelete = (from unEmploye in monDataContext.Employes
                                               where unEmploye.No == noEmployeToDelete
                                               select unEmploye).FirstOrDefault();
                        monDataContext.Employes.DeleteOnSubmit(employeToDelete);
                        monDataContext.SubmitChanges();
                        refresh();
                        MessageBox.Show("Succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
        }
    }
}
