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
    public partial class frmPersonne : UserControl
    {
        public frmPersonne()
        {
            InitializeComponent();
        }

        Personne personne = new Personne();

        DataAccess data = new DataAccess();

        private void BindingClass()
        {
            personne.Id = txtIdPersonne.Text;
            personne.Nom = txtNom.Text;
            personne.Postnom = txtPostnom.Text;
            personne.Prenom = txtPrenom.Text;
            if (rbM.Checked)
            {
                personne.Sexe = 'M';
            }
            else
            {
                personne.Sexe = 'F';
            }
        }

        private void LoadlistPersonne()
        {
            try
            {
                DgPersonne.DataSource = personne.GetPersonne();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearField()
        {
            txtIdPersonne.Text = DataAccess.instance.generateId;
            txtNom.Clear();
            txtPostnom.Clear();
            txtPrenom.Clear();
            rbM.Checked = true;
            rbF.Checked = false;
            btnEnreg.Enabled = true;
            btnDelete.Enabled = false;
            btnModifier.Enabled = false;
        }

        private void frmPersonne_Load(object sender, EventArgs e)
        {
            LoadlistPersonne();
            txtIdPersonne.Text = DataAccess.instance.generateId;
            btnModifier.Enabled = false;
            btnDelete.Enabled = false;
            rbM.Checked = true;
        }

        private void DgPersonne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPersonne.Text = DgPersonne["id", DgPersonne.CurrentRow.Index].Value.ToString();
            txtNom.Text = DgPersonne["nom", DgPersonne.CurrentRow.Index].Value.ToString();
            txtPostnom.Text = DgPersonne["postnom", DgPersonne.CurrentRow.Index].Value.ToString();
            txtPrenom.Text = DgPersonne["prenom", DgPersonne.CurrentRow.Index].Value.ToString();
            rbM.Checked = DgPersonne["sexe", DgPersonne.CurrentRow.Index].Value.ToString() == "M";
            rbF.Checked = DgPersonne["sexe", DgPersonne.CurrentRow.Index].Value.ToString() == "F";
            btnEnreg.Enabled = false;
            btnDelete.Enabled = true;
            btnModifier.Enabled = true;
        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = personne.Enregistrer(personne);
                if (resultat > 0)
                {
                    MessageBox.Show("Personne ajoutée avec succès", "Ajout Personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistPersonne();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("L'ajout de la personne a echoué", "Ajout Personne", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un problème s'est produit. Contactez l'adminisatrateur svp ! ", "Ajout Personne", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = personne.Modifier(personne);
                if (resultat > 0)
                {
                    MessageBox.Show("Personne modifiée avec succès", "Modification Personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistPersonne();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La modification a echouée", "Modification Personne", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la modification de la personne. Contactez l'administrateur svp ! ", "Modification Personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat3 = personne.Supprimer3(personne);
                int resultat2 = personne.Supprimer2(personne);
                int resultat = personne.Supprimer(personne);
                if (resultat > 0)
                {
                    MessageBox.Show("Personne supprimée avec succès", "Suppression Personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistPersonne();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La suppression a echouée", "Suppression Personne", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la suppression de la personne. Contactez l'administrateur svp ! ", "Suppression Personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection strcon = new SqlConnection("Data Source=BAHADOOR;Initial Catalog=gestion_personne;User ID=sa;Password=Espace2027;Encrypt=false");

            if (txtSearch.Text != "")
            {
                DgPersonne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string query = "select * from personne where id like @search or nom like @search or postnom like @search or prenom like @search or sexe like @search";

                strcon.Open();
                SqlCommand cmd = new SqlCommand(query, strcon);
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                adap = new SqlDataAdapter(cmd);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                DgPersonne.DataSource = dv;
                strcon.Close();
            }
            else if (txtSearch.Text == "")
            {
                LoadlistPersonne();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "LISTE DES PERSONNES\n\n";
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


            printer.PrintPreviewDataGridView(DgPersonne);
        }
    }
}
