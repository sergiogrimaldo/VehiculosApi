using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehiculosAPI.Models
{
    [Table("Ventas")]
    public class Venta
    {
        [Key]
        public int VentaID { get; set; }

        [ForeignKey("Vehiculo")]
        public int VehiculoID { get; set; }
        public Vehiculo Vehiculo { get; set; }

        [Required]
        [MaxLength(100)]
        public string NombreComprador { get; set; }

        [Required]
        [MaxLength(50)]
        public string DocumentoComprador { get; set; }

        public DateTime FechaVenta { get; set; } = DateTime.Now;
    }
}
