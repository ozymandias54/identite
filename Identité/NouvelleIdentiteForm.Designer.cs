
namespace Identité
{
    partial class NouvelleIdentiteForm
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInitialiser = new System.Windows.Forms.Button();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.champPhoto = new System.Windows.Forms.PictureBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtGenre = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.champPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouveau Utilisateur";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInitialiser);
            this.groupBox1.Controls.Add(this.btnParcourir);
            this.groupBox1.Controls.Add(this.btnSauvegarder);
            this.groupBox1.Controls.Add(this.champPhoto);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtGenre);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 451);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Identité";
            // 
            // btnInitialiser
            // 
            this.btnInitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitialiser.Location = new System.Drawing.Point(271, 350);
            this.btnInitialiser.Name = "btnInitialiser";
            this.btnInitialiser.Size = new System.Drawing.Size(126, 29);
            this.btnInitialiser.TabIndex = 13;
            this.btnInitialiser.Text = "Reinitialiser";
            this.btnInitialiser.UseVisualStyleBackColor = false;
            this.btnInitialiser.Click += new System.EventHandler(this.btnInitialiser_Click);
            // 
            // btnParcourir
            // 
            this.btnParcourir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnParcourir.Location = new System.Drawing.Point(398, 241);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(130, 33);
            this.btnParcourir.TabIndex = 12;
            this.btnParcourir.Text = "Parcourir...";
            this.btnParcourir.UseVisualStyleBackColor = false;
            this.btnParcourir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSauvegarder.Location = new System.Drawing.Point(88, 350);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(139, 29);
            this.btnSauvegarder.TabIndex = 11;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // champPhoto
            // 
            this.champPhoto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.champPhoto.Image = global::Identité.Properties.Resources.userIdentite;
            this.champPhoto.InitialImage = null;
            this.champPhoto.Location = new System.Drawing.Point(365, 56);
            this.champPhoto.Name = "champPhoto";
            this.champPhoto.Size = new System.Drawing.Size(190, 167);
            this.champPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.champPhoto.TabIndex = 10;
            this.champPhoto.TabStop = false;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(162, 275);
            this.txtTel.Mask = "00 00 00 00 ";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(184, 29);
            this.txtTel.TabIndex = 9;
            // 
            // txtGenre
            // 
            this.txtGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtGenre.FormattingEnabled = true;
            this.txtGenre.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.txtGenre.Location = new System.Drawing.Point(162, 213);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(184, 32);
            this.txtGenre.TabIndex = 8;
            this.txtGenre.Text = "Masculin";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteCustomSource.AddRange(new string[] {
            "nom@gmail.com",
            "prenom@gmail.com",
            "pseudo@gmail.com"});
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmail.Location = new System.Drawing.Point(162, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 29);
            this.txtEmail.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(162, 114);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(184, 29);
            this.txtDate.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.AutoCompleteCustomSource.AddRange(new string[] {
            "Ali Maiga",
            "Issa Kone",
            "Aicha Sy",
            "Fatou Sow"});
            this.txtNom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNom.Location = new System.Drawing.Point(162, 56);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(184, 29);
            this.txtNom.TabIndex = 5;
            this.txtNom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNom_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date Naissance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom Complet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.Image = global::Identité.Properties.Resources.icons8_add_user_male_64;
            this.button1.Location = new System.Drawing.Point(3, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 64);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NouvelleIdentiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "NouvelleIdentiteForm";
            this.Size = new System.Drawing.Size(601, 550);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.champPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.PictureBox champPhoto;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.Button btnInitialiser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtGenre;
    }
}
