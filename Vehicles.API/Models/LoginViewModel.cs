using System.ComponentModel.DataAnnotations;

namespace Vehicles.API.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Debes introducior un email valido.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        [MaxLength(6, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Password { get; set; }

        [Display(Name = "Recordame")]
        public bool RememberMe { get; set; }

    }
}
