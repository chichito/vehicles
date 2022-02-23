using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Controllers;

namespace Vehicles.API.Models
{
    public class AddUserViewModel: EditUserViewModel
    {
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="Debes introducir un email válido.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        [MinLength(6, ErrorMessage = "El campo {0} debe tener una longitud minima de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String Password { get; set; }

        [Display(Name = "Confirmación de contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "El campo {0} debe tener una longitud minima de {1} carácteres.")]
        [Compare("Password",ErrorMessage = "La contraseña y confirmación de contraseña no son iguales")]
        public String PasswordConfirm { get; set; }
    }
}
