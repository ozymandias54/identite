using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identité.Modele
{
    class Identite
    {
        public int Id { get; set; }
        public string NomComplet { get; set; }
        public DateTime DateNaiss { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Genre { get; set; }
        public Byte[] Photo { get; set; }

        public Identite()
        {
        }

        public Identite(string nomComplet, DateTime dateNaiss, string telephone, string email, string genre, byte[] photo)
        {
            NomComplet = nomComplet;
            DateNaiss = dateNaiss;
            Telephone = telephone;
            Email = email;
            Genre = genre;
            Photo = photo;
        }
    }
}
