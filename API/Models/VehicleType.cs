using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("Tb_M_VehicleType")]
    public class VehicleType
    {
        [Key]
        public int IdType { get; set; }
        public string TypeName { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
