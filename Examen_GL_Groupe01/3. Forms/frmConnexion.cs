using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSingleConnexion;

namespace Examen_GL_Groupe01._3._Forms
{
    public partial class frmConnexion : Form
    {
        private ConnexionType connexionType;
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            cmbDbType.DataSource = Enum.GetNames(typeof(ConnexionType));
            cmbDbType.SelectedIndex = 0;
            txtServer.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Affectation des valeurs dans l'objet de la classe
                Connexion connexion = new Connexion();

                connexion.Serveur = txtServer.Text;
                connexion.Database = txtDB.Text;
                connexion.User = txtUser.Text;
                connexion.Password = txtPassword.Text;

                // Initialisation de la connexion à la base de données
                ImplementeConnexion.Instance.Initialise(connexion, connexionType);

                //Ouverture de la connexion à la base de données
                ImplementeConnexion.Instance.Conn.Open();
                MessageBox.Show("Connection réussie !!!", "Connexion à la base de données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                this.Hide();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Erreur de connection, " + ex.Message, "Connexion à la base de données", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Erreur de connection, " + ex.Message, "Connexion à la base de données", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connection, " + ex.Message, "Connexion à la base de données", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn != null)
                {
                    if (ImplementeConnexion.Instance.Conn.State == System.Data.ConnectionState.Open)
                        ImplementeConnexion.Instance.Conn.Close();
                }
            }
        }

        private void cmbDbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDbType.SelectedIndex)
            {
                case 0:
                    connexionType = ConnexionType.SQLServer;
                    break;
                case 1:
                    connexionType = ConnexionType.MySQL;
                    break;
                case 2:
                    connexionType = ConnexionType.PostgreSQL;
                    break;
                case 3:
                    connexionType = ConnexionType.Oracle;
                    break;
                case 4:
                    connexionType = ConnexionType.Access;
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '●';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
