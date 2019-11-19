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
    public partial class frmConnexion : Form
    {
        DataClasses1DataContext monDataContext = new DataClasses1DataContext();
        frmMenu Menu;
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text.Trim();
            string pass = tbPass.Text.Trim();
            var user = (from unUser in monDataContext.Employes
                    where unUser.No.ToString() == username &&
                    unUser.MotDePasse == pass
                    select unUser).FirstOrDefault();
            if (user == null)
                MessageBox.Show("Nom d'utilisateur ou mot de passe invalide");
            else
            {
                Menu = new frmMenu(user);
                this.Hide();
                Menu.ShowDialog();
                this.Show();
            }
                
        }

        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }
    }
}
