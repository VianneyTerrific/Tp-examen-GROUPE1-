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
    public partial class frmAdresse : UserControl
    {
        public frmAdresse()
        {
            InitializeComponent();
        }

        Adresse adresse = new Adresse();

        DataAccess data = new DataAccess();

        private void BindingClass()
        {
            adresse.Id = txtIdAdresse.Text;
            adresse.Quartier = txtQuartier.Text;
            adresse.Commune = txtCommune.Text;
            adresse.Ville = txtVille.Text;
            adresse.Pays = txtPays.Text;
        }

        private void LoadlistAdresse()
        {
            try
            {
                DgAdresse.DataSource = adresse.GetAdresse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearField()
        {
            txtIdAdresse.Text = DataAccess.instance.generateId;
            txtQuartier.Clear();
            txtCommune.Clear();
            txtVille.Clear();
            txtPays.Clear();
            btnEnreg.Enabled = true;
            btnDelete.Enabled = false;
            btnModifier.Enabled = false;
        }

        private void frmAdresse_Load(object sender, EventArgs e)
        {
            LoadlistAdresse();
            txtIdAdresse.Text = DataAccess.instance.generateId;
            btnModifier.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void DgAdresse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdAdresse.Text = DgAdresse["id", DgAdresse.CurrentRow.Index].Value.ToString();
            txtQuartier.Text = DgAdresse["quartier", DgAdresse.CurrentRow.Index].Value.ToString();
            txtCommune.Text = DgAdresse["commune", DgAdresse.CurrentRow.Index].Value.ToString();
            txtVille.Text = DgAdresse["ville", DgAdresse.CurrentRow.Index].Value.ToString();
            txtPays.Text = DgAdresse["pays", DgAdresse.CurrentRow.Index].Value.ToString();
            btnEnreg.Enabled = false;
            btnDelete.Enabled = true;
            btnModifier.Enabled = true;
        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = adresse.Enregistrer(adresse);
                if (resultat > 0)
                {
                    MessageBox.Show("Adresse ajoutée avec succès", "Ajout Adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistAdresse();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("L'ajout de l'adresse a echoué", "Ajout Adresse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un problème s'est produit. Contactez l'adminisatrateur svp ! ", "Ajout Adresse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = adresse.Modifier(adresse);
                if (resultat > 0)
                {
                    MessageBox.Show("Adresse modifiée avec succès", "Modification Adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistAdresse();
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
                int resultat2 = adresse.Supprimer2(adresse);
                int resultat = adresse.Supprimer(adresse);
                if (resultat > 0)
                {
                    MessageBox.Show("Adresse supprimée avec succès", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistAdresse();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La suppression a echouée", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la suppression de l'adresse. Contactez l'administrateur svp ! ", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection strcon = new SqlConnection("Data Source=BAHADOOR;Initial Catalog=gestion_personne;User ID=sa;Password=Espace2027;Encrypt=false");

            if (txtSearch.Text != "")
            {
                DgAdresse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "select * from adresse where id like @search or quartier like @search or commune like @search or ville like @search or pays like @search";

                strcon.Open();
                SqlCommand cmd = new SqlCommand(query, strcon);
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                adap = new SqlDataAdapter(cmd);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                DgAdresse.DataSource = dv;
                strcon.Close();
            }
            else if (txtSearch.Text == "")
            {
                LoadlistAdresse();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "LISTE DES ADRESSES\n\n";
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


            Bitmap logo = new Bitmap(@"D:\Logo\address.png");
            DGVPrinter.ImbeddedImage img = new DGVPrinter.ImbeddedImage();
            img.theImage = logo;
            img.ImageAlignment = DGVPrinter.Alignment.Left;
            img.ImageLocation = DGVPrinter.Location.Header;
            printer.ImbeddedImageList.Add(img);


            printer.PrintPreviewDataGridView(DgAdresse);
        }
    }
}
