
namespace Identité
{
    partial class ListeIdentiteForm
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.nbre = new System.Windows.Forms.Label();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.tel = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.eMail = new System.Windows.Forms.Label();
            this.dateNaissance = new System.Windows.Forms.Label();
            this.nomComplet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des Identités";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 154);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(574, 191);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.Click += new System.EventHandler(this.dataGrid_Click);
            // 
            // nbre
            // 
            this.nbre.AutoSize = true;
            this.nbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbre.Location = new System.Drawing.Point(177, 68);
            this.nbre.Name = "nbre";
            this.nbre.Size = new System.Drawing.Size(45, 16);
            this.nbre.TabIndex = 2;
            this.nbre.Text = "label2";
            // 
            // txtFiltre
            // 
            this.txtFiltre.AutoCompleteCustomSource.AddRange(new string[] {
            "Fofana Bassirou",
            "Diarra Oumou",
            "Koné Mai",
            "Sidibé Toumani"});
            this.txtFiltre.Location = new System.Drawing.Point(273, 110);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(175, 20);
            this.txtFiltre.TabIndex = 3;
            // 
            // btnFiltre
            // 
            this.btnFiltre.Location = new System.Drawing.Point(467, 110);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(84, 19);
            this.btnFiltre.TabIndex = 4;
            this.btnFiltre.Text = "Filtre";
            this.btnFiltre.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::Identité.Properties.Resources.icons8_list_view_50;
            this.button1.Location = new System.Drawing.Point(3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 55);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picture);
            this.panel1.Controls.Add(this.tel);
            this.panel1.Controls.Add(this.genre);
            this.panel1.Controls.Add(this.eMail);
            this.panel1.Controls.Add(this.dateNaissance);
            this.panel1.Controls.Add(this.nomComplet);
            this.panel1.Location = new System.Drawing.Point(12, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 176);
            this.panel1.TabIndex = 6;
            // 
            // picture
            // 
            this.picture.Image = global::Identité.Properties.Resources.userIdentite;
            this.picture.Location = new System.Drawing.Point(414, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(157, 170);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 5;
            this.picture.TabStop = false;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(260, 73);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(22, 13);
            this.tel.TabIndex = 4;
            this.tel.Text = "Tel";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(258, 28);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(36, 13);
            this.genre.TabIndex = 3;
            this.genre.Text = "Genre";
            // 
            // eMail
            // 
            this.eMail.AutoSize = true;
            this.eMail.Location = new System.Drawing.Point(25, 116);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(32, 13);
            this.eMail.TabIndex = 2;
            this.eMail.Text = "Email";
            // 
            // dateNaissance
            // 
            this.dateNaissance.AutoSize = true;
            this.dateNaissance.Location = new System.Drawing.Point(25, 73);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(98, 13);
            this.dateNaissance.TabIndex = 1;
            this.dateNaissance.Text = "Date de Naissance";
            // 
            // nomComplet
            // 
            this.nomComplet.AutoSize = true;
            this.nomComplet.Location = new System.Drawing.Point(25, 28);
            this.nomComplet.Name = "nomComplet";
            this.nomComplet.Size = new System.Drawing.Size(67, 13);
            this.nomComplet.TabIndex = 0;
            this.nomComplet.Text = "NomComplet";
            // 
            // ListeIdentiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.txtFiltre);
            this.Controls.Add(this.nbre);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label1);
            this.Name = "ListeIdentiteForm";
            this.Size = new System.Drawing.Size(601, 550);
            this.Load += new System.EventHandler(this.ListeIdentiteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label nbre;
        private System.Windows.Forms.TextBox txtFiltre;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label eMail;
        private System.Windows.Forms.Label dateNaissance;
        private System.Windows.Forms.Label nomComplet;
        private System.Windows.Forms.PictureBox picture;
    }
}
