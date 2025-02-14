using System.ComponentModel.DataAnnotations;

namespace Sist_Gest_Vent_.Controllers
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }

        [Required(ErrorMessage = "La identificacion es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Telefono { get; set; }
        public string Correo { get; set; }
        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo no válido")]
        public string Direccion { get; set; }
    }
}
