using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Models
{
    public class UserViewModel 
    {
        public String Id { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Debes introducior un email valido.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Email { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String LastName { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String Document { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        public String Address { get; set; }

        [Display(Name = "Telefono")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        public String PhoneNumber { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        [Display(Name = "Tipo de usuario")]
        public UserType UserType { get; set; }

        [Display(Name = "Foto")]
        public IFormFile ImageFile { get; set; }

        [Display(Name = "Foto")]
        public String ImageFullPath => ImageId == Guid.Empty
                    ? $"https://localhost:44352/images/no-image.png"
                    : $"https://localhost:44352/images/users/{ImageId}.jpg";

        [Display(Name = "Tipo de Documento")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un tipo de documento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int DocumentTypeId { get; set; }

        public IEnumerable<SelectListItem> DocumentTypes { get; set; }
    }
}
