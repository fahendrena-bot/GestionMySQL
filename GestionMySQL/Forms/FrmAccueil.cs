using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionMySQL.Forms;

namespace GestionMySQL
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            FrmBaseDonnee frm = new FrmBaseDonnee();
            frm.ShowDialog();
        }

        private void button_table_Click(object sender, EventArgs e)
        {
            FrmTable frm = new FrmTable();
            frm.ShowDialog();
        }

        private void button_sql_Click(object sender, EventArgs e)
        {
            FrmSQL frm = new FrmSQL();
            frm.ShowDialog();
        }

        private void deconnexion_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show(
             "Voulez-vous vraiment vous déconnecter ?",
            "Déconnexion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                FrmConnexion frmConnexion = new FrmConnexion();

                frmConnexion.Show();

                this.Close();
            }

        }
    }
}
