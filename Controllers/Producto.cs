using System.ComponentModel.DataAnnotations;

namespace Sist_Gest_Vent_.Controllers
{
    public class Producto
    {
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "La identificacion es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock{ get; set; }
        [Required(ErrorMessage = "El numero de stock es obligatorio")]
        public int IdProveedor { get; set; }
    }
}
