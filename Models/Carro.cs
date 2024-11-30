namespace VehiculosAPI.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }
    }
}
