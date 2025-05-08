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
using DGVPrinterHelper;
using Examen_GL_Groupe01._1._Classes;
using Examen_GL_Groupe01._4._Connexion;

namespace Examen_GL_Groupe01._2._Users_Controls
{
    public partial class frmDomicile : UserControl
    {
        public frmDomicile()
        {
            InitializeComponent();
        }

        public ComboBox MyComboBox2
        {
            get { return this.cmbPersonne; }
        }

        public ComboBox MyComboBox3
        {
            get { return this.cmbAdresse; }
        }

        Domicile domicile = new Domicile();

        DataAccess data = new DataAccess();

        private void ChargerComboPersonne()
        {
            data.OpenConnection();
            string query = "select nom + ' ' + postnom + ' ' + prenom as noms from personne";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtable = new DataTable();
            dtable.Load(dr);

            cmbPersonne.DataSource = dtable;
            cmbPersonne.DisplayMember = "noms";
            cmbPersonne.ValueMember = "noms";

            data.CloseConnection();
        }

        private void ChargerComboAdresse()
        {
            data.OpenConnection();
            string query = "select quartier + ', ' + commune + ', ' + ville + ', ' + pays as localisation from adresse";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtable = new DataTable();
            dtable.Load(dr);

            cmbAdresse.DataSource = dtable;
            cmbAdresse.DisplayMember = "localisation";
            cmbAdresse.ValueMember = "localisation";

            data.CloseConnection();
        }

        private void BindingClass()
        {
            domicile.Id = txtIdDomicile.Text;
            domicile.IdPersonne = txtIdPersonne.Text;
            domicile.IdAdresse = txtIdAdresse.Text;
            domicile.Avenue = txtAvenue.Text;
            domicile.NumeroAvenue = txtNumAv.Text;
        }

        private void LoadlistDomicile()
        {
            try
            {
                DgDomicile.DataSource = domicile.GetDomicile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearField()
        {
            txtIdDomicile.Text = DataAccess.instance.generateId;
            txtIdPersonne.Clear();
            txtIdAdresse.Clear();
            txtAvenue.Clear();
            txtNumAv.Clear();
            btnEnreg.Enabled = true;
            cmbPersonne.Enabled = true;
            cmbAdresse.Enabled = true;
            btnDelete.Enabled = false;
            btnModifier.Enabled = false;
            txtPersonne.Visible = false;
            txtAdresse.Visible = false;
        }

        private void frmDomicile_Load(object sender, EventArgs e)
        {
            LoadlistDomicile();
            txtIdDomicile.Text = DataAccess.instance.generateId;
            btnModifier.Enabled = false;
            btnDelete.Enabled = false;
            ChargerComboAdresse();
            ChargerComboPersonne();
        }

        private void DgDomicile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbPersonne.SelectedIndex = 0;
            cmbAdresse.SelectedIndex = 0;
            txtIdDomicile.Text = DgDomicile["id", DgDomicile.CurrentRow.Index].Value.ToString();
            txtIdPersonne.Text = DgDomicile["idPersonne", DgDomicile.CurrentRow.Index].Value.ToString();
            txtIdAdresse.Text = DgDomicile["idAdresse", DgDomicile.CurrentRow.Index].Value.ToString();
            txtAvenue.Text = DgDomicile["avenue", DgDomicile.CurrentRow.Index].Value.ToString();
            txtNumAv.Text = DgDomicile["NumeroAvenue", DgDomicile.CurrentRow.Index].Value.ToString();
            btnEnreg.Enabled = false;
            cmbPersonne.Enabled = false;
            cmbAdresse.Enabled = false;
            btnDelete.Enabled = true;
            btnModifier.Enabled = true;
            txtPersonne.Visible = true;
            txtAdresse.Visible = true;
        }

        private void cmbPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.OpenConnection();
            string query = "select id from personne where nom + ' ' + postnom + ' ' + prenom = '" + cmbPersonne.Text + "'";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtIdPersonne.Text = dt.Rows[i]["id"].ToString();
                }
            }
        }

        private void cmbAdresse_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.OpenConnection();
            string query = "select id from adresse where quartier + ', ' + commune + ', ' + ville + ', ' + pays = '" + cmbAdresse.Text + "'";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtIdAdresse.Text = dt.Rows[i]["id"].ToString();
                }
            }
        }

        private void txtPersonne_TextChanged(object sender, EventArgs e)
        {
            data.OpenConnection();
            string query = "select nom + ' ' + postnom + ' ' + prenom as noms from personne where id = '" + txtIdPersonne.Text + "'";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtPersonne.Text = dt.Rows[i]["noms"].ToString();
                }
            }
            else if (txtPersonne.Text == "")
            {
                txtPersonne.Text = "";
            }
        }

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {
            data.OpenConnection();
            string query = "select quartier + ', ' + commune + ', ' + ville + ', ' + pays as localisation from adresse where id = '" + txtIdAdresse.Text + "'";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtAdresse.Text = dt.Rows[i]["localisation"].ToString();
                }
            }
            else if (txtPersonne.Text == "")
            {
                txtAdresse.Text = "";
            }
        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = domicile.Enregistrer(domicile);
                if (resultat > 0)
                {
                    MessageBox.Show("Domicile ajouté avec succès", "Ajout Domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistDomicile();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("L'ajout du domicile a echoué", "Ajout Domicile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un problème s'est produit. Contactez l'adminisatrateur svp ! ", "Ajout Domicile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = domicile.Modifier(domicile);
                if (resultat > 0)
                {
                    MessageBox.Show("Domicile modifié avec succès", "Modification Domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistDomicile();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La modification a echouée", "Modification Domicile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la modification du domicile. Contactez l'administrateur svp ! ", "Modification Domicile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = domicile.Supprimer(domicile);
                if (resultat > 0)
                {
                    MessageBox.Show("Domicile supprimé avec succès", "Suppression Domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistDomicile();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La suppression a echouée", "Suppression Domicile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la suppression du domicile. Contactez l'administrateur svp ! ", "Suppression Domicile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumAv_Click(object sender, EventArgs e)
        {
            if (txtNumAv.Text == "")
            {
                txtNumAv.SelectionStart = 0;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection strcon = new SqlConnection("Data Source=BAHADOOR;Initial Catalog=gestion_personne;User ID=sa;Password=Espace2027;Encrypt=false");

            if (txtSearch.Text != "")
            {
                DgDomicile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "select * from domicile where id like @search or id_personne like @search or id_adresse like @search or avenue like @search or numero_avenue like @search";

                strcon.Open();
                SqlCommand cmd = new SqlCommand(query, strcon);
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                adap = new SqlDataAdapter(cmd);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                DgDomicile.DataSource = dv;
                strcon.Close();
            }
            else if (txtSearch.Text == "")
            {
                LoadlistDomicile();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "LISTE DES PERSONNES\n AVEC ADRESSES RESPECTIVES\n\n";
            printer.TitleFont = new Font("Times New Roman", 18, FontStyle.Bold);
            printer.TitleAlignment = StringAlignment.Center;

            printer.SubTitle = $"Liste imprimée : {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}\n\n\n\n";
            printer.SubTitleFont = new Font("Segeo UI", 10);
            printer.SubTitleColor = Color.CornflowerBlue;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "Examen Génie Logiciel | Groupe 01";
            printer.FooterFont = new Font("Segoe UI", 9, FontStyle.Italic);
            printer.FooterSpacing = 20;

            Bitmap logo = new Bitmap(@"D:\Logo\people.png");
            DGVPrinter.ImbeddedImage img = new DGVPrinter.ImbeddedImage();
            img.theImage = logo;
            img.ImageAlignment = DGVPrinter.Alignment.Left;
            img.ImageLocation = DGVPrinter.Location.Header;
            printer.ImbeddedImageList.Add(img);

            Bitmap logo2 = new Bitmap(@"D:\Logoo\address.png");
            DGVPrinter.ImbeddedImage img2 = new DGVPrinter.ImbeddedImage();
            img2.theImage = logo2;
            img2.ImageAlignment = DGVPrinter.Alignment.Right;
            img2.ImageLocation = DGVPrinter.Location.Header;
            printer.ImbeddedImageList.Add(img2);

            printer.PrintPreviewDataGridView(DgDomicile);
        }
    }
}
