using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    [Table("StudentiPorukeIB123456")]
    public class StudentiPorukeIB123456
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
        public virtual Predmet Predmet { get; set; }
        public string Sadrzaj { get; set; } 
        public byte[] Slika { get; set; }   
        public DateTime Validnost { get; set; }
    }
}
