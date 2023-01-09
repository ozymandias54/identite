using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identité
{
    public partial class NouvelleIdentiteForm : UserControl
    {
        public NouvelleIdentiteForm()
        {
            InitializeComponent();
            
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Equals("") || txtTel.Text.Equals("") || txtGenre.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Veillez renseignez tous les Champs", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Modele.Identite i = new Modele.Identite();
                i.NomComplet = txtNom.Text;
                i.DateNaiss = txtDate.Value.Date;
                i.Email = txtEmail.Text;
                i.Genre = txtGenre.Text;
                i.Telephone = txtTel.Text;
                ImageConverter ic = new ImageConverter();
                Image image = champPhoto.Image;
                i.Photo = (byte[])ic.ConvertTo(image, typeof(byte[])); 
                Modele.BDIdentite.AjouterIdentite(i);
                MessageBox.Show("Identité ajouté avec ID :"+ Modele.BDIdentite.ListeIdentites().Max(x => x.Id), "Nouvelle identité",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNom.Text = "";
                txtTel.Text = "";
                txtGenre.Text = "";
                txtEmail.Text = "";
                champPhoto.Image = global::Identité.Properties.Resources.userIdentite;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "C:\\Users\\fofana\\Pictures\\identite";
            op.Filter = "Database files (*jpeg,*.jpg, *.png)|*jpeg;*jpg;*.png";
            op.FilterIndex = 0;
            op.RestoreDirectory = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                var path = op.FileName;
                Image img = Image.FromFile(path);
                champPhoto.Image = img;

            }
        }

        private void btnInitialiser_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtTel.Text = "";
            txtGenre.Text = "";
            txtEmail.Text = "";
            champPhoto.Image = global::Identité.Properties.Resources.userIdentite;
        }

        private void txtNom_KeyUp(object sender, KeyEventArgs e)
        {
            string nom = txtNom.Text.Replace(" ","3");
            txtEmail.Text = nom.ToLower() + "@gmail.com";
        }
    }
}
