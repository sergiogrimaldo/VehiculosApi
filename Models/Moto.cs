namespace VehiculosAPI.Models
{
    public class Moto
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int Cilindraje { get; set; }
        public int Velocidades { get; set; }
    }
}

