using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("Tb_M_Vehicle")]
    public class Vehicle
    {
        [Key]
        public string NoPlat { get; set; }
        public string Color { get; set; }
        public string CarBrand { get; set; }
        public int Capity { get; set; }
        public DateTime YearProductions { get; set; }
        [ForeignKey("VehicleType")]
        public int CarTypeId { get; set; }
        public int status { get; set; }
        public virtual VehicleType VehicleType { get; set; }
        [JsonIgnore]
        public virtual ICollection<Pesanan> Pesanan { get; set; }

    }
}
