using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("Tb_T_Pesanan")]
    public class Pesanan
    {
        [Key]
        public string IdPesanan { get; set; }
        [ForeignKey("Vehicle")]
        public string NoPlat { get; set; }
        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }
        public DateTime TanggalPesanan { get; set; }
        public string LokasiAwal { get; set; }
        public string LokasiTujuan { get; set; }
        public string Deskripsi { get; set; }
        public virtual Employee Employee { get; set; } 
        public virtual Vehicle Vehicle { get; set; }
    }
}
