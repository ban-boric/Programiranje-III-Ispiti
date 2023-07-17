using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace DLWMS.Data
{
    public class Student
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int GodinaStudija { get; set; }
        public byte[]? Slika { get; set; }
        public bool Aktivan { get; set; }
        public Spol Spol { get; set; }       

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        [NotMapped]
        public string ImePrezime => $"{Ime} {Prezime}";

        [NotMapped]
        public float Prosjek { get; set; }

        public void GetProsjek()
        {
            List<StudentiPredmetiIB123456> lista = new List<StudentiPredmetiIB123456>();
            lista = _db.StudentiPredmeti.Include(X=>X.Student).ToList();
            int brojPredmeta = 0;
            float suma = 0.0f;

            foreach(var sp in lista)
            {
                if(sp.Student.Id == Id)
                {
                    suma += sp.Ocjena;
                    brojPredmeta++;
                }
            }

            if(brojPredmeta > 0)
            {
                Prosjek = suma / brojPredmeta;
            }
            else
            {
                Prosjek = 5;
            }
                
        }
    }  
}