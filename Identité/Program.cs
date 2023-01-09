using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identité
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Modele.BDIdentite.AjouterIdentite(new Modele.Identite("Fofana Bassirou", DateTime.Parse("12/11/2131"), "66 55 66 66", "bassirou@gmail.com", "Masculin", null));
            Modele.BDIdentite.AjouterIdentite(new Modele.Identite("Diarra Oumou", DateTime.Parse("12/11/2131"), "65 34 52 56", "oumou@gmail.com", "Feminin", null));
            Modele.BDIdentite.AjouterIdentite(new Modele.Identite("Koné Mai", DateTime.Parse("12/11/1631"), "62 55 12 44", "mai@gmail.com", "Feminin", null));
            Modele.BDIdentite.AjouterIdentite(new Modele.Identite("Sidibé Toumani", DateTime.Parse("12/11/1631"), "52 35 55 44", "sidibe@gmail.com", "Masculin", null));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormIdentite());
        }
    }
}
