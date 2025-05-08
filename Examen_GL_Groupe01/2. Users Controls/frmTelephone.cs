using DGVPrinterHelper;
using Examen_GL_Groupe01._1._Classes;
using Examen_GL_Groupe01._4._Connexion;
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

namespace Examen_GL_Groupe01._2._Users_Controls
{
    public partial class frmTelephone : UserControl
    {
        public frmTelephone()
        {
            InitializeComponent();
        }

        public ComboBox MyComboBox
        {
            get { return this.cmbPersonne; }
        }

        Telephone telephone = new Telephone();

        DataAccess data = new DataAccess();

        private void ChargerCombo()
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

        private void BindingClass()
        {
            telephone.Id = txtIdPhone.Text;
            telephone.IdPersonne = txtIdPersonne.Text;
            telephone.Initial = txtInitial.Text;
            telephone.Numero = txtNumero.Text;
        }

        private void LoadlistTelephone()
        {
            try
            {
                DgTelephone.DataSource = telephone.GetTelephone();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearField()
        {
            txtIdPhone.Text = DataAccess.instance.generateId;
            txtIdPersonne.Clear();
            txtInitial.Clear();
            txtNumero.Clear();
            btnEnreg.Enabled = true;
            cmbPersonne.Enabled = true;
            btnDelete.Enabled = false;
            btnModifier.Enabled = false;
            txtPersonne.Visible = false;
        }

        private void frmTelephone_Load(object sender, EventArgs e)
        {
            LoadlistTelephone();
            txtIdPhone.Text = DataAccess.instance.generateId;
            btnModifier.Enabled = false;
            btnDelete.Enabled = false;
            ChargerCombo();
        }

        private void DgTelephone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbPersonne.SelectedIndex = 0;
            txtIdPhone.Text = DgTelephone["id", DgTelephone.CurrentRow.Index].Value.ToString();
            txtIdPersonne.Text = DgTelephone["idPersonne", DgTelephone.CurrentRow.Index].Value.ToString();
            txtInitial.Text = DgTelephone["initial", DgTelephone.CurrentRow.Index].Value.ToString();
            txtNumero.Text = DgTelephone["numero", DgTelephone.CurrentRow.Index].Value.ToString();
            btnEnreg.Enabled = false;
            cmbPersonne.Enabled = false;
            btnDelete.Enabled = true;
            btnModifier.Enabled = true;
            txtPersonne.Visible = true;
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

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = telephone.Enregistrer(telephone);
                if (resultat > 0)
                {
                    MessageBox.Show("Téléphone ajoutée avec succès", "Ajout Téléphone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistTelephone();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("L'ajout du numéro a echoué", "Ajout Téléphone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un problème s'est produit. Contactez l'adminisatrateur svp ! ", "Ajout Téléphone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = telephone.Modifier(telephone);
                if (resultat > 0)
                {
                    MessageBox.Show("Adresse modifiée avec succès", "Modification Adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistTelephone();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La modification a echouée", "Modification Adresse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la modification de l'adresse. Contactez l'administrateur svp ! ", "Modification Adresse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = telephone.Supprimer(telephone);
                if (resultat > 0)
                {
                    MessageBox.Show("Adresse supprimée avec succès", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistTelephone();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La suppression a echouée", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors du suppression de l'adresse. Contactez l'administrateur svp ! ", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumero_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                txtNumero.SelectionStart = 0;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection strcon = new SqlConnection("Data Source=BAHADOOR;Initial Catalog=gestion_personne;User ID=sa;Password=Espace2027;Encrypt=false");

            if (txtSearch.Text != "")
            {
                DgTelephone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "select * from telephone where id like @search or id_personne like @search or initial like @search or numero like @search";
                strcon.Open();
                SqlCommand cmd = new SqlCommand(query, strcon);
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                adap = new SqlDataAdapter(cmd);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                DgTelephone.DataSource = dv;
                strcon.Close();
            }
            else if (txtSearch.Text == "")
            {
                LoadlistTelephone();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "LISTE DES PERSONNES\n AVEC NUMEROS RELATIFS\n\n";
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

            Bitmap logo2 = new Bitmap(@"D:\Logo\phone.png");
            DGVPrinter.ImbeddedImage img2 = new DGVPrinter.ImbeddedImage();
            img2.theImage = logo2;
            img2.ImageAlignment = DGVPrinter.Alignment.Right;
            img2.ImageLocation = DGVPrinter.Location.Header;
            printer.ImbeddedImageList.Add(img2);

            printer.PrintPreviewDataGridView(DgTelephone);
        }
    }
}
