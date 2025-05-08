namespace Examen_GL_Groupe01._2._Users_Controls
{
    partial class frmTelephone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelephone));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnreg = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtPersonne = new System.Windows.Forms.TextBox();
            this.txtIdPersonne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPersonne = new System.Windows.Forms.ComboBox();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.txtIdPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgTelephone = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgTelephone)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(627, 208);
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
            this.txtSearch.Location = new System.Drawing.Point(676, 212);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 28);
            this.txtSearch.TabIndex = 214;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(673, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 213;
            this.label2.Text = "Barre de recherche";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(31, 270);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Mask = "999999999";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(276, 29);
            this.txtNumero.TabIndex = 212;
            this.txtNumero.ValidatingType = typeof(int);
            this.txtNumero.Click += new System.EventHandler(this.txtNumero_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(906, 257);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 44);
            this.btnPrint.TabIndex = 210;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(597, 710);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 44);
            this.btnDelete.TabIndex = 211;
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
            this.btnEnreg.Location = new System.Drawing.Point(331, 710);
            this.btnEnreg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(89, 44);
            this.btnEnreg.TabIndex = 209;
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
            this.btnModifier.Location = new System.Drawing.Point(463, 710);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(89, 44);
            this.btnModifier.TabIndex = 208;
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtPersonne
            // 
            this.txtPersonne.BackColor = System.Drawing.Color.White;
            this.txtPersonne.Enabled = false;
            this.txtPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonne.Location = new System.Drawing.Point(31, 156);
            this.txtPersonne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonne.Name = "txtPersonne";
            this.txtPersonne.Size = new System.Drawing.Size(961, 28);
            this.txtPersonne.TabIndex = 204;
            this.txtPersonne.Visible = false;
            this.txtPersonne.TextChanged += new System.EventHandler(this.txtPersonne_TextChanged);
            // 
            // txtIdPersonne
            // 
            this.txtIdPersonne.BackColor = System.Drawing.Color.White;
            this.txtIdPersonne.Enabled = false;
            this.txtIdPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPersonne.Location = new System.Drawing.Point(31, 100);
            this.txtIdPersonne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPersonne.Name = "txtIdPersonne";
            this.txtIdPersonne.Size = new System.Drawing.Size(961, 28);
            this.txtIdPersonne.TabIndex = 205;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 203;
            this.label3.Text = "PERSONNE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 22);
            this.label8.TabIndex = 202;
            this.label8.Text = "ID PERSONNE";
            // 
            // cmbPersonne
            // 
            this.cmbPersonne.BackColor = System.Drawing.Color.White;
            this.cmbPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonne.FormattingEnabled = true;
            this.cmbPersonne.Location = new System.Drawing.Point(31, 155);
            this.cmbPersonne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPersonne.Name = "cmbPersonne";
            this.cmbPersonne.Size = new System.Drawing.Size(961, 30);
            this.cmbPersonne.TabIndex = 206;
            this.cmbPersonne.SelectedIndexChanged += new System.EventHandler(this.cmbPersonne_SelectedIndexChanged);
            // 
            // txtInitial
            // 
            this.txtInitial.BackColor = System.Drawing.Color.White;
            this.txtInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitial.Location = new System.Drawing.Point(31, 211);
            this.txtInitial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInitial.Multiline = true;
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(276, 29);
            this.txtInitial.TabIndex = 201;
            // 
            // txtIdPhone
            // 
            this.txtIdPhone.BackColor = System.Drawing.Color.White;
            this.txtIdPhone.Enabled = false;
            this.txtIdPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPhone.Location = new System.Drawing.Point(31, 43);
            this.txtIdPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPhone.Multiline = true;
            this.txtIdPhone.Name = "txtIdPhone";
            this.txtIdPhone.Size = new System.Drawing.Size(961, 29);
            this.txtIdPhone.TabIndex = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 198;
            this.label5.Text = "NUMERO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 197;
            this.label4.Text = "INITIAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 22);
            this.label1.TabIndex = 199;
            this.label1.Text = "ID";
            // 
            // DgTelephone
            // 
            this.DgTelephone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgTelephone.BackgroundColor = System.Drawing.Color.White;
            this.DgTelephone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgTelephone.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgTelephone.Location = new System.Drawing.Point(31, 307);
            this.DgTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgTelephone.Name = "DgTelephone";
            this.DgTelephone.RowHeadersWidth = 51;
            this.DgTelephone.RowTemplate.Height = 24;
            this.DgTelephone.Size = new System.Drawing.Size(963, 383);
            this.DgTelephone.TabIndex = 207;
            this.DgTelephone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTelephone_CellContentClick);
            // 
            // frmTelephone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnreg);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtPersonne);
            this.Controls.Add(this.txtIdPersonne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbPersonne);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.txtIdPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgTelephone);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTelephone";
            this.Size = new System.Drawing.Size(1021, 775);
            this.Load += new System.EventHandler(this.frmTelephone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgTelephone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnreg;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtPersonne;
        private System.Windows.Forms.TextBox txtIdPersonne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPersonne;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.TextBox txtIdPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgTelephone;
    }
}
