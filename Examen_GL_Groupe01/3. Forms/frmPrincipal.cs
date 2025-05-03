using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen_GL_Groupe01._2._Users_Controls;
using Examen_GL_Groupe01._4._Connexion;

namespace Examen_GL_Groupe01._3._Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            SidePanel.Height = btnPersonne.Height;
            SidePanel.Top = btnPersonne.Top;
            frmPersonne1.BringToFront();
        }

        DataAccess data = new DataAccess();

        private void ChargerComboPersonne()
        {
            ComboBox cmb = frmDomicile1.MyComboBox2;

            data.OpenConnection();
            string query = "select nom + ' ' + postnom + ' ' + prenom as noms from personne";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtable = new DataTable();
            dtable.Load(dr);

            cmb.DataSource = dtable;
            cmb.DisplayMember = "noms";
            cmb.ValueMember = "noms";

            data.CloseConnection();
        }

        private void ChargerComboPersonne2()
        {
            ComboBox cmb = frmTelephone1.MyComboBox;

            data.OpenConnection();
            string query = "select nom + ' ' + postnom + ' ' + prenom as noms from personne";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtable = new DataTable();
            dtable.Load(dr);

            cmb.DataSource = dtable;
            cmb.DisplayMember = "noms";
            cmb.ValueMember = "noms";

            data.CloseConnection();
        }

        private void ChargerComboAdresse()
        {
            ComboBox cmb = frmDomicile1.MyComboBox3;

            data.OpenConnection();
            string query = "select quartier + ', ' + commune + ', ' + ville + ', ' + pays as localisation from adresse";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtable = new DataTable();
            dtable.Load(dr);

            cmb.DataSource = dtable;
            cmb.DisplayMember = "localisation";
            cmb.ValueMember = "localisation";

            data.CloseConnection();
        }

        private void btnPersonne_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPersonne.Height;
            SidePanel.Top = btnPersonne.Top;
            frmPersonne1.BringToFront();
        }

        private void btnAdresse_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAdresse.Height;
            SidePanel.Top = btnAdresse.Top;
            frmAdresse1.BringToFront();
        }

        private void btnDomicile_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDomicile.Height;
            SidePanel.Top = btnDomicile.Top;
            frmDomicile1.BringToFront();

            //Chargement ComboBox
            ChargerComboAdresse();
            ChargerComboPersonne();
        }

        private void btnTelephone_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTelephone.Height;
            SidePanel.Top = btnTelephone.Top;
            frmTelephone1.BringToFront();

            //Chargement ComboBox
            ChargerComboPersonne2();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment vous deconnectez ?", "Deconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmConnexion con = new frmConnexion();
                con.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment quitter ?", "Formulaire Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
