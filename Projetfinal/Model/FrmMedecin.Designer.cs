namespace Projetfinal.Model
{
    partial class FrmMedecin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSpecialite = new System.Windows.Forms.ComboBox();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNumeroOrdre = new System.Windows.Forms.TextBox();
            this.lblNumeroOrdre = new System.Windows.Forms.Label();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.dgMedecin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSpecialite
            // 
            this.cbSpecialite.FormattingEnabled = true;
            this.cbSpecialite.Location = new System.Drawing.Point(124, 417);
            this.cbSpecialite.Name = "cbSpecialite";
            this.cbSpecialite.Size = new System.Drawing.Size(299, 28);
            this.cbSpecialite.TabIndex = 58;
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(579, 97);
            this.btnAgenda.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(96, 34);
            this.btnAgenda.TabIndex = 57;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(471, 97);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(96, 34);
            this.btnChoisir.TabIndex = 50;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(328, 556);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 34);
            this.btnSupprimer.TabIndex = 53;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(228, 556);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(95, 34);
            this.btnModifier.TabIndex = 52;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(120, 556);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(96, 34);
            this.btnAjouter.TabIndex = 49;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // txtNumeroOrdre
            // 
            this.txtNumeroOrdre.Location = new System.Drawing.Point(121, 484);
            this.txtNumeroOrdre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumeroOrdre.Name = "txtNumeroOrdre";
            this.txtNumeroOrdre.Size = new System.Drawing.Size(302, 26);
            this.txtNumeroOrdre.TabIndex = 47;
            // 
            // lblNumeroOrdre
            // 
            this.lblNumeroOrdre.AutoSize = true;
            this.lblNumeroOrdre.Location = new System.Drawing.Point(121, 460);
            this.lblNumeroOrdre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumeroOrdre.Name = "lblNumeroOrdre";
            this.lblNumeroOrdre.Size = new System.Drawing.Size(109, 20);
            this.lblNumeroOrdre.TabIndex = 55;
            this.lblNumeroOrdre.Text = "Numero Ordre";
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Location = new System.Drawing.Point(121, 397);
            this.lblSpecialite.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(78, 20);
            this.lblSpecialite.TabIndex = 54;
            this.lblSpecialite.Text = "Specialite";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(121, 358);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(302, 26);
            this.txtIdentifiant.TabIndex = 46;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(121, 333);
            this.lblIdentifiant.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(80, 20);
            this.lblIdentifiant.TabIndex = 51;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(121, 294);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(302, 26);
            this.txtTelephone.TabIndex = 44;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(121, 269);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(84, 20);
            this.lblTelephone.TabIndex = 48;
            this.lblTelephone.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 230);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(302, 26);
            this.txtEmail.TabIndex = 43;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(121, 205);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "Email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(121, 166);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(302, 26);
            this.txtAdresse.TabIndex = 41;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(121, 142);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(68, 20);
            this.lblAdresse.TabIndex = 42;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(121, 103);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(302, 26);
            this.txtNomPrenom.TabIndex = 39;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(121, 78);
            this.lblNomPrenom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(100, 20);
            this.lblNomPrenom.TabIndex = 40;
            this.lblNomPrenom.Text = "Nom prenom";
            // 
            // dgMedecin
            // 
            this.dgMedecin.ColumnHeadersHeight = 34;
            this.dgMedecin.Location = new System.Drawing.Point(471, 141);
            this.dgMedecin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgMedecin.Name = "dgMedecin";
            this.dgMedecin.RowHeadersWidth = 62;
            this.dgMedecin.Size = new System.Drawing.Size(538, 474);
            this.dgMedecin.TabIndex = 56;
            // 
            // FrmMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 693);
            this.Controls.Add(this.cbSpecialite);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNumeroOrdre);
            this.Controls.Add(this.lblNumeroOrdre);
            this.Controls.Add(this.lblSpecialite);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.dgMedecin);
            this.Name = "FrmMedecin";
            this.Text = "FrmMedecin";
            ((System.ComponentModel.ISupportInitialize)(this.dgMedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSpecialite;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtNumeroOrdre;
        private System.Windows.Forms.Label lblNumeroOrdre;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.DataGridView dgMedecin;
    }
}