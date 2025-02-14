using System.ComponentModel.DataAnnotations;

namespace Sist_Gest_Vent_.Controllers
{
    public class Inventario
    {
        public int IdInventario { get; set; }

        [Required(ErrorMessage = "La identificacion es obligatorio")]
        public int IdProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int StockAnual{ get; set; }
    }
}
