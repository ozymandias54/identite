using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Identité
{
    public partial class ListeIdentiteForm : UserControl
    {
        public ListeIdentiteForm()
        {
            InitializeComponent();

        }

        private int idSelect;
        private void ListeIdentiteForm_Load(object sender, EventArgs e)
        {
            BindingList<Modele.Identite> lst = new BindingList<Modele.Identite>(Modele.BDIdentite.ListeIdentites());
            dataGrid.DataSource = lst;
            dataGrid.AutoResizeColumns();
            dataGrid.AllowUserToResizeColumns = true;
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.Columns["Photo"].Visible = false;
            dataGrid.AllowUserToAddRows = false;
            nbre.Text = "Nombre d'identité :" + dataGrid.RowCount;

        }

        private void dataGrid_Click(object sender, EventArgs e)
        {
            idSelect = (int)dataGrid.CurrentRow.Cells["Id"].Value;
            string nom = (string)dataGrid.CurrentRow.Cells["NomComplet"].Value;
            DateTime dateN = (DateTime)dataGrid.CurrentRow.Cells["DateNaiss"].Value;
            string email = (string)dataGrid.CurrentRow.Cells["Email"].Value;
            string sexe = (string)dataGrid.CurrentRow.Cells["Genre"].Value;
            string tele = (string)dataGrid.CurrentRow.Cells["Telephone"].Value;
            Byte[] photo= (byte[])dataGrid.CurrentRow.Cells["Photo"].Value;
            string date = dateN.ToString();
            nomComplet.Text ="NomComplet :"+ nom;
            dateNaissance.Text = "Date de Naissance :"+date;
            eMail.Text ="Email :"+ email;
            genre.Text ="Genre :"+ sexe;
            tel.Text ="Tel :" +tele;
            if (photo == null)
            {
                picture.Image = global::Identité.Properties.Resources.userIdentite;
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(photo, 0, photo.Length);
                Image img = Image.FromStream(ms, true, true);
                picture.Image = img;
            }
            
        }

    }
}