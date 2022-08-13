using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("Tb_M_Divions")]
    public class Division
    {
        [Key]
        public string IdDivision { get; set; }
        public string DivisionName { get; set; }
        [JsonIgnore]
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
