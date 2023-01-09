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
    public partial class FormIdentite : Form
    {
        public FormIdentite()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
           var ms= MessageBox.Show("Voulez vous Quitter l'Application ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ms == DialogResult.OK)
            {
                Application.Exit();
            }
           
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ListeIdentiteForm lif = new ListeIdentiteForm();
            lif.Dock = DockStyle.Fill;
            panel2.Controls.Add(lif);
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            NouvelleIdentiteForm nif = new NouvelleIdentiteForm();
            nif.Dock = DockStyle.Fill;
            panel2.Controls.Add(nif);
        }
    }
}
