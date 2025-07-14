using System.ComponentModel.DataAnnotations;

namespace SegundoParcial_LP2.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "El nombre no puede exceder los 40 caracteres.")]
        public string Nombre { get; set; }

        public string Empresa { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Debe ser un correo electrónico válido.")]
        public string Correo { get; set; }

        [Required]
        [RegularExpression(@"^\d{10,}$", ErrorMessage = "El número de contacto debe tener al menos 10 dígitos y solo contener números.")]
        public string NumeroContacto { get; set; }
    }


}
