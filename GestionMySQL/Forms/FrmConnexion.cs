using GestionMySQL.Services;
namespace GestionMySQL
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnexionMySQL db = new ConnexionMySQL();

            bool connexionOK = db.Connecter(
                txtServeur.Text,
                txtPort.Text,
                txtUtilisateur.Text,
                txtMotPasse.Text
            );

            if (connexionOK)
            {
                MessageBox.Show(
                    "Connexion réussie !",
                    "Succès",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                FrmAccueil accueil = new FrmAccueil();

                accueil.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Connexion impossible.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
