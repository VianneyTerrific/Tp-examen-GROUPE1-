namespace Examen_GL_Groupe01._2._Users_Controls
{
    partial class frmDomicile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDomicile));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPersonne = new System.Windows.Forms.TextBox();
            this.txtAvenue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumAv = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnreg = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtIdAdresse = new System.Windows.Forms.TextBox();
            this.txtIdPersonne = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAdresse = new System.Windows.Forms.ComboBox();
            this.cmbPersonne = new System.Windows.Forms.ComboBox();
            this.txtIdDomicile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgDomicile = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDomicile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(590, 334);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 217;
            this.pictureBox4.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(645, 339);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(354, 32);
            this.txtSearch.TabIndex = 216;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 26);
            this.label4.TabIndex = 215;
            this.label4.Text = "Barre de recherche";
            // 
            // txtAdresse
            // 
            this.txtAdresse.BackColor = System.Drawing.Color.White;
            this.txtAdresse.Enabled = false;
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(590, 195);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(525, 32);
            this.txtAdresse.TabIndex = 214;
            this.txtAdresse.Visible = false;
            this.txtAdresse.TextChanged += new System.EventHandler(this.txtAdresse_TextChanged);
            // 
            // txtPersonne
            // 
            this.txtPersonne.BackColor = System.Drawing.Color.White;
            this.txtPersonne.Enabled = false;
            this.txtPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonne.Location = new System.Drawing.Point(35, 195);
            this.txtPersonne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonne.Name = "txtPersonne";
            this.txtPersonne.Size = new System.Drawing.Size(525, 32);
            this.txtPersonne.TabIndex = 213;
            this.txtPersonne.Visible = false;
            this.txtPersonne.TextChanged += new System.EventHandler(this.txtPersonne_TextChanged);
            // 
            // txtAvenue
            // 
            this.txtAvenue.BackColor = System.Drawing.Color.White;
            this.txtAvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvenue.Location = new System.Drawing.Point(35, 265);
            this.txtAvenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAvenue.Name = "txtAvenue";
            this.txtAvenue.Size = new System.Drawing.Size(525, 32);
            this.txtAvenue.TabIndex = 212;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 26);
            this.label12.TabIndex = 211;
            this.label12.Text = "AVENUE";
            // 
            // txtNumAv
            // 
            this.txtNumAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAv.Location = new System.Drawing.Point(590, 268);
            this.txtNumAv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumAv.Mask = "999999999";
            this.txtNumAv.Name = "txtNumAv";
            this.txtNumAv.Size = new System.Drawing.Size(525, 33);
            this.txtNumAv.TabIndex = 210;
            this.txtNumAv.ValidatingType = typeof(int);
            this.txtNumAv.Click += new System.EventHandler(this.txtNumAv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(585, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 26);
            this.label5.TabIndex = 209;
            this.label5.Text = "NUMERO AVENUE";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(1018, 321);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 55);
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
            this.btnDelete.Location = new System.Drawing.Point(672, 887);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 55);
            this.btnDelete.TabIndex = 208;
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
            this.btnEnreg.Location = new System.Drawing.Point(372, 887);
            this.btnEnreg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(100, 55);
            this.btnEnreg.TabIndex = 206;
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
            this.btnModifier.Location = new System.Drawing.Point(521, 887);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 55);
            this.btnModifier.TabIndex = 205;
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtIdAdresse
            // 
            this.txtIdAdresse.BackColor = System.Drawing.Color.White;
            this.txtIdAdresse.Enabled = false;
            this.txtIdAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAdresse.Location = new System.Drawing.Point(590, 125);
            this.txtIdAdresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdAdresse.Name = "txtIdAdresse";
            this.txtIdAdresse.Size = new System.Drawing.Size(525, 32);
            this.txtIdAdresse.TabIndex = 201;
            // 
            // txtIdPersonne
            // 
            this.txtIdPersonne.BackColor = System.Drawing.Color.White;
            this.txtIdPersonne.Enabled = false;
            this.txtIdPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPersonne.Location = new System.Drawing.Point(35, 125);
            this.txtIdPersonne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPersonne.Name = "txtIdPersonne";
            this.txtIdPersonne.Size = new System.Drawing.Size(525, 32);
            this.txtIdPersonne.TabIndex = 200;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(585, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 26);
            this.label9.TabIndex = 199;
            this.label9.Text = "ADRESSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 198;
            this.label3.Text = "PERSONNE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(585, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 26);
            this.label7.TabIndex = 197;
            this.label7.Text = "ID ADRESSE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 26);
            this.label8.TabIndex = 196;
            this.label8.Text = "ID PERSONNE";
            // 
            // cmbAdresse
            // 
            this.cmbAdresse.BackColor = System.Drawing.Color.White;
            this.cmbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdresse.FormattingEnabled = true;
            this.cmbAdresse.Location = new System.Drawing.Point(590, 194);
            this.cmbAdresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAdresse.Name = "cmbAdresse";
            this.cmbAdresse.Size = new System.Drawing.Size(525, 34);
            this.cmbAdresse.TabIndex = 203;
            this.cmbAdresse.SelectedIndexChanged += new System.EventHandler(this.cmbAdresse_SelectedIndexChanged);
            // 
            // cmbPersonne
            // 
            this.cmbPersonne.BackColor = System.Drawing.Color.White;
            this.cmbPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonne.FormattingEnabled = true;
            this.cmbPersonne.Location = new System.Drawing.Point(35, 194);
            this.cmbPersonne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPersonne.Name = "cmbPersonne";
            this.cmbPersonne.Size = new System.Drawing.Size(525, 34);
            this.cmbPersonne.TabIndex = 202;
            this.cmbPersonne.SelectedIndexChanged += new System.EventHandler(this.cmbPersonne_SelectedIndexChanged);
            // 
            // txtIdDomicile
            // 
            this.txtIdDomicile.BackColor = System.Drawing.Color.White;
            this.txtIdDomicile.Enabled = false;
            this.txtIdDomicile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDomicile.Location = new System.Drawing.Point(35, 54);
            this.txtIdDomicile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdDomicile.Multiline = true;
            this.txtIdDomicile.Name = "txtIdDomicile";
            this.txtIdDomicile.Size = new System.Drawing.Size(1081, 35);
            this.txtIdDomicile.TabIndex = 195;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 26);
            this.label1.TabIndex = 194;
            this.label1.Text = "ID";
            // 
            // DgDomicile
            // 
            this.DgDomicile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgDomicile.BackgroundColor = System.Drawing.Color.White;
            this.DgDomicile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDomicile.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgDomicile.Location = new System.Drawing.Point(35, 387);
            this.DgDomicile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgDomicile.Name = "DgDomicile";
            this.DgDomicile.RowHeadersWidth = 51;
            this.DgDomicile.RowTemplate.Height = 24;
            this.DgDomicile.Size = new System.Drawing.Size(1083, 475);
            this.DgDomicile.TabIndex = 204;
            this.DgDomicile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDomicile_CellContentClick);
            // 
            // frmDomicile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtPersonne);
            this.Controls.Add(this.txtAvenue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNumAv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnreg);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtIdAdresse);
            this.Controls.Add(this.txtIdPersonne);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbAdresse);
            this.Controls.Add(this.cmbPersonne);
            this.Controls.Add(this.txtIdDomicile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgDomicile);
            this.Name = "frmDomicile";
            this.Size = new System.Drawing.Size(1149, 969);
            this.Load += new System.EventHandler(this.frmDomicile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDomicile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPersonne;
        private System.Windows.Forms.TextBox txtAvenue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtNumAv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnreg;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtIdAdresse;
        private System.Windows.Forms.TextBox txtIdPersonne;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAdresse;
        private System.Windows.Forms.ComboBox cmbPersonne;
        private System.Windows.Forms.TextBox txtIdDomicile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgDomicile;
    }
}
