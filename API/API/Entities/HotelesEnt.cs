namespace API.Entities
{
    public class HotelesEnt
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string pais { get; set; }
        public decimal puntuacion { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public string imagen { get; set; }
        public int IdAmenidades { get; set; }
        public int IDPais { get; set; }

    }
}