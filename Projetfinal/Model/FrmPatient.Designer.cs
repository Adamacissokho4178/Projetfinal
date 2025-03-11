namespace Projetfinal.Model
{
    partial class FrmPatient
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
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.lblTaille = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.lblPoids = new System.Windows.Forms.Label();
            this.txtGroupeSanguin = new System.Windows.Forms.TextBox();
            this.lblGroupeSanguin = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.dgPatient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(434, 45);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(112, 28);
            this.btnChoisir.TabIndex = 30;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(290, 416);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(112, 28);
            this.btnSupprimer.TabIndex = 33;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(151, 416);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(112, 28);
            this.btnModifier.TabIndex = 32;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 416);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 28);
            this.btnAjouter.TabIndex = 29;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(7, 358);
            this.txtTaille.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(394, 26);
            this.txtTaille.TabIndex = 27;
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(7, 338);
            this.lblTaille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(45, 20);
            this.lblTaille.TabIndex = 35;
            this.lblTaille.Text = "Taille";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(7, 306);
            this.txtPoids.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(394, 26);
            this.txtPoids.TabIndex = 26;
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(7, 287);
            this.lblPoids.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(48, 20);
            this.lblPoids.TabIndex = 34;
            this.lblPoids.Text = "Poids";
            // 
            // txtGroupeSanguin
            // 
            this.txtGroupeSanguin.Location = new System.Drawing.Point(7, 255);
            this.txtGroupeSanguin.Margin = new System.Windows.Forms.Padding(4);
            this.txtGroupeSanguin.Name = "txtGroupeSanguin";
            this.txtGroupeSanguin.Size = new System.Drawing.Size(394, 26);
            this.txtGroupeSanguin.TabIndex = 25;
            // 
            // lblGroupeSanguin
            // 
            this.lblGroupeSanguin.AutoSize = true;
            this.lblGroupeSanguin.Location = new System.Drawing.Point(7, 235);
            this.lblGroupeSanguin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupeSanguin.Name = "lblGroupeSanguin";
            this.lblGroupeSanguin.Size = new System.Drawing.Size(126, 20);
            this.lblGroupeSanguin.TabIndex = 31;
            this.lblGroupeSanguin.Text = "Groupe Sanguin";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(7, 203);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(394, 26);
            this.txtTelephone.TabIndex = 23;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(7, 183);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(84, 20);
            this.lblTelephone.TabIndex = 28;
            this.lblTelephone.Text = "Telephone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(7, 151);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(394, 26);
            this.txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 131);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(7, 99);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(394, 26);
            this.txtAdresse.TabIndex = 20;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(7, 80);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(68, 20);
            this.lblAdresse.TabIndex = 21;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(7, 48);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(394, 26);
            this.txtNomPrenom.TabIndex = 18;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(7, 28);
            this.lblNomPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(100, 20);
            this.lblNomPrenom.TabIndex = 19;
            this.lblNomPrenom.Text = "Nom prenom";
            // 
            // dgPatient
            // 
            this.dgPatient.ColumnHeadersHeight = 34;
            this.dgPatient.Location = new System.Drawing.Point(434, 81);
            this.dgPatient.Margin = new System.Windows.Forms.Padding(4);
            this.dgPatient.Name = "dgPatient";
            this.dgPatient.RowHeadersWidth = 62;
            this.dgPatient.Size = new System.Drawing.Size(726, 479);
            this.dgPatient.TabIndex = 36;
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 706);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.lblTaille);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.lblPoids);
            this.Controls.Add(this.txtGroupeSanguin);
            this.Controls.Add(this.lblGroupeSanguin);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.dgPatient);
            this.Name = "FrmPatient";
            this.Text = "FrmPatient";
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.TextBox txtGroupeSanguin;
        private System.Windows.Forms.Label lblGroupeSanguin;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.DataGridView dgPatient;
    }
}