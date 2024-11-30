using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehiculosAPI.Models
{
    [Table("PreciosVehiculos")]
    public class PrecioVehiculo
    {
        [Key]
        [MaxLength(100)]
        public string Modelo { get; set; }

        [Required]
        public decimal Precio { get; set; }
    }
}
