using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTS_API.Models
{
    public class Karyawan
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public bool gender { get; set; }

        public Salary Salary { get; set; }
        [ForeignKey("Salary")]
        public int SalaryId { get; set; }

    }
}
