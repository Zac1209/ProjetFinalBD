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
            (new ajoutEmploye()).ShowDialog();
            refresh();
            this.Show();
        }

        private void refresh()
        {
            employeCount = monDataContext.Employes.Count();
            employesBindingSource.DataSource = from unEmploye in monDataContext.Employes
                                               orderby unEmploye.No
                                               select unEmploye;
        }
    }
}
