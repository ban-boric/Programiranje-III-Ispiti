using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    [Table("StudentiUvjerenjaIB123456")]
    public class StudentiUvjerenjaIB123456
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public string VrstaUvjerenja { get; set; }
        public string SvrhaUvjerenja { get; set; }
        public byte[] Uplatnica { get; set; }
        public bool Printano { get; set; } = false;
    }
}
