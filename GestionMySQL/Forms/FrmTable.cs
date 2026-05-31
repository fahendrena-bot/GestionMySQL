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
    public partial class FrmTable : Form
    {
        public FrmTable()
        {
            InitializeComponent();
        }

        private void ChargerBases()
        {
            try
            {
                cmbBases.Items.Clear();

                string sql = "SHOW DATABASES";

                MySqlCommand cmd =
                    new MySqlCommand(
                        sql,
                        ConnexionMySQL.GetConnexion());

                MySqlDataReader lecteur =
                    cmd.ExecuteReader();

                while (lecteur.Read())
                {
                    cmbBases.Items.Add(
                        lecteur.GetString(0));
                }

                lecteur.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void AfficherTables()
        {
            try
            {
                string baseChoisie =
                    cmbBases.SelectedItem.ToString();

                string sql =
                    $"SHOW TABLES FROM {baseChoisie}";

                MySqlCommand cmd =
                    new MySqlCommand(
                        sql,
                        ConnexionMySQL.GetConnexion());

                MySqlDataAdapter da =
                    new MySqlDataAdapter(cmd);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvTables.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            AfficherTables();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChargerBases();
            AfficherTables();
        }

        private void FrmTable_Load(object sender, EventArgs e)
        {
            ChargerBases();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string baseChoisie =
                    cmbBases.SelectedItem.ToString();

                string sql =
                    $"CREATE TABLE {baseChoisie}.{txtNomTable.Text}" +
                    "(id INT AUTO_INCREMENT PRIMARY KEY," +
                    "nom VARCHAR(100))";

                MySqlCommand cmd =
                    new MySqlCommand(
                        sql,
                        ConnexionMySQL.GetConnexion());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Table créée.");

                AfficherTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string baseChoisie =
                    cmbBases.SelectedItem.ToString();

                string sql =
                    $"DROP TABLE {baseChoisie}.{txtNomTable.Text}";

                MySqlCommand cmd =
                    new MySqlCommand(
                        sql,
                        ConnexionMySQL.GetConnexion());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Table supprimée.");

                AfficherTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
