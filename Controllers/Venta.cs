using System.ComponentModel.DataAnnotations;

namespace Sist_Gest_Vent_.Controllers
{
    public class Venta
    {
        public int IdVenta { get; set; }

        [Required(ErrorMessage = "La identificacion es obligatorio")]
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public decimal Total { get; set; }
    }
}
