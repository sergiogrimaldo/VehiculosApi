using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehiculosAPI.Models
{
    [Table("Vehiculos")]
    public class Vehiculo
    {
        [Key]
        public int VehiculoID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Modelo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Color { get; set; }

        [Required]
        public int Kilometraje { get; set; }

        [Required]
        [Range(0, 250000000)]
        public decimal Valor { get; set; }

        [MaxLength(255)]
        public string? Imagen { get; set; } // Opcional

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(50)]
        public string TipoVehiculo { get; set; } // 'Carro' o 'Moto'

        public int Cilindraje { get; set; } // Sólo motos
        public int NumVelocidades { get; set; } // Sólo motos

        [Required]
        [MaxLength(50)]
        public string Estado { get; set; } // 'Nuevo' o 'Usado'
    }
}
