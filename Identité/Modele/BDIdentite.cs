using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Identité.Modele
{
    static class BDIdentite
    {
        public static List<Identite> liste;
        public static void AjouterIdentite(Identite i)
        {
            if (liste == null)
            {
                liste = new List<Identite>();
            }
            i.Id = liste.Any() ? liste.Max(x => x.Id) + 1 : 1;
            liste.Add(i);
        }

        public static List<Identite> ListeIdentites()
        {
            return liste;
        }
        public static void SupprimerIdentite(int Ididentite)
        {
           int index = liste.FindIndex(x => x.Id == Ididentite);
            liste.RemoveAt(index);
        }
        public static void ModifierIdentite(int Ididentite,byte[] img)
        {
            liste.Find(x => x.Id == Ididentite).Photo = img;
        }
        public static List<Identite> RechercheIdentite(string nom)
        {
            List<Identite> res = liste.Where(x => x.NomComplet.ToLower().Contains(nom.ToLower())).ToList();
            return res;
        }
        public static Identite RechercheIdentite(int Ididentite)
        {
            Identite id = liste.Find(x => x.Id == Ididentite);
            return id;
        }
    }
}
