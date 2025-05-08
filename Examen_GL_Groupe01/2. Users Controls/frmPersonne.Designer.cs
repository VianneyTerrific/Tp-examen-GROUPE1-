namespace Examen_GL_Groupe01._2._Users_Controls
{
    partial class frmPersonne
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonne));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnreg = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.DgPersonne = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtIdPersonne = new System.Windows.Forms.TextBox();
            this.txtPostnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(528, 272);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 215;
            this.pictureBox4.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(577, 276);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 28);
            this.txtSearch.TabIndex = 214;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 22);
            this.label4.TabIndex = 213;
            this.label4.Text = "Barre de recherche";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.White;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(31, 214);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(963, 28);
            this.txtPrenom.TabIndex = 212;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 22);
            this.label12.TabIndex = 211;
            this.label12.Text = "PRENOM";
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbF.Location = new System.Drawing.Point(101, 274);
            this.rbF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(38, 22);
            this.rbF.TabIndex = 210;
            this.rbF.TabStop = true;
            this.rbF.Text = "F";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbM.Location = new System.Drawing.Point(31, 274);
            this.rbM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(42, 22);
            this.rbM.TabIndex = 209;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 208;
            this.label5.Text = "SEXE ";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(903, 261);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 44);
            this.btnPrint.TabIndex = 207;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(596, 710);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 44);
            this.btnDelete.TabIndex = 206;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnreg
            // 
            this.btnEnreg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnreg.FlatAppearance.BorderSize = 0;
            this.btnEnreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnreg.Image = ((System.Drawing.Image)(resources.GetObject("btnEnreg.Image")));
            this.btnEnreg.Location = new System.Drawing.Point(329, 710);
            this.btnEnreg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(89, 44);
            this.btnEnreg.TabIndex = 205;
            this.btnEnreg.UseVisualStyleBackColor = false;
            this.btnEnreg.Click += new System.EventHandler(this.btnEnreg_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModifier.Enabled = false;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.Location = new System.Drawing.Point(461, 710);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(89, 44);
            this.btnModifier.TabIndex = 204;
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // DgPersonne
            // 
            this.DgPersonne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgPersonne.BackgroundColor = System.Drawing.Color.White;
            this.DgPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPersonne.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgPersonne.Location = new System.Drawing.Point(29, 314);
            this.DgPersonne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgPersonne.Name = "DgPersonne";
            this.DgPersonne.RowHeadersWidth = 51;
            this.DgPersonne.RowTemplate.Height = 24;
            this.DgPersonne.Size = new System.Drawing.Size(963, 377);
            this.DgPersonne.TabIndex = 203;
            this.DgPersonne.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPersonne_CellContentClick);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.White;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(31, 100);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(963, 28);
            this.txtNom.TabIndex = 201;
            // 
            // txtIdPersonne
            // 
            this.txtIdPersonne.BackColor = System.Drawing.Color.White;
            this.txtIdPersonne.Enabled = false;
            this.txtIdPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPersonne.Location = new System.Drawing.Point(31, 43);
            this.txtIdPersonne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPersonne.Multiline = true;
            this.txtIdPersonne.Name = "txtIdPersonne";
            this.txtIdPersonne.Size = new System.Drawing.Size(963, 29);
            this.txtIdPersonne.TabIndex = 200;
            // 
            // txtPostnom
            // 
            this.txtPostnom.BackColor = System.Drawing.Color.White;
            this.txtPostnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostnom.Location = new System.Drawing.Point(31, 156);
            this.txtPostnom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPostnom.Name = "txtPostnom";
            this.txtPostnom.Size = new System.Drawing.Size(963, 28);
            this.txtPostnom.TabIndex = 202;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 197;
            this.label1.Text = "ID ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 22);
            this.label10.TabIndex = 199;
            this.label10.Text = "POSTNOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 198;
            this.label2.Text = "NOM";
            // 
            // frmPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnreg);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.DgPersonne);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtIdPersonne);
            this.Controls.Add(this.txtPostnom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPersonne";
            this.Size = new System.Drawing.Size(1021, 775);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnreg;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView DgPersonne;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtIdPersonne;
        private System.Windows.Forms.TextBox txtPostnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}
