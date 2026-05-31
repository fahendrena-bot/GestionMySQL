using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GestionMySQL.Services;

namespace GestionMySQL.Forms
{
    public partial class FrmSQL : Form
    {
        public FrmSQL()
        {
            InitializeComponent();
        }

        private void btnExcecuter_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = rtbSQL.Text;

                MySqlCommand cmd =
                    new MySqlCommand(
                        sql,
                        ConnexionMySQL.GetConnexion());

                string requete = sql.Trim().ToUpper();

                if (requete.StartsWith("SELECT") ||
                    requete.StartsWith("SHOW") ||
                    requete.StartsWith("DESC"))
                {
                    MySqlDataAdapter da =
                        new MySqlDataAdapter(cmd);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dgvResultat.DataSource = dt;
                }
                else
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Requête exécutée avec succès.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
