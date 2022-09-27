using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTS_API.Models
{
    public class Late
    {
        [Key]
        public int id { get; set; }
        public float late { get; set; }
        public Karyawan karyawan { get; set; }
        [ForeignKey("karyawan")]
        public int idperson { get; set; }

    }
}
