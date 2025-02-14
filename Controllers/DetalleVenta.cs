using System.ComponentModel.DataAnnotations;

namespace Sist_Gest_Vent_.Controllers
{
    public class DetalleVenta
    {
        public int DetalleId { get; set; }

        [Required(ErrorMessage = "La identificacion es obligatorio")]
        public int IdVenta { get; set; }

        [Required(ErrorMessage = "La identificacion de la venta es obligatorio")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "La identificacion del producto es obligatorio")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatorio es obligatorio")]
        public decimal PrecioUnitario { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public decimal Subtotal { get; set; }
    }
}
