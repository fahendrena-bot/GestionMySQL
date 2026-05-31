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
    public partial class FrmBaseDonnee : Form
    {
        public FrmBaseDonnee()
        {
            InitializeComponent();
        }


        private void AfficherBases()
        {
            try
            {
                string sql = "SHOW DATABASES";

                MySqlCommand cmd =
                    new MySqlCommand(
                        sql,
                        ConnexionMySQL.GetConnexion());

                MySqlDataAdapter da =
                    new MySqlDataAdapter(cmd);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvBases.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AfficherBases();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AfficherBases();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    $"DROP DATABASE {txtNomBase.Text}";

                MySqlCommand cmd =
                    new MySqlCommand(
                        sql,
                        ConnexionMySQL.GetConnexion());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Base supprimée.");

                AfficherBases();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    $"CREATE DATABASE {txtNomBase.Text}";

                MySqlCommand cmd =
                    new MySqlCommand(
                        sql,
                        ConnexionMySQL.GetConnexion());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Base créée.");

                AfficherBases();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AfficherBases();
        }
    }




}
