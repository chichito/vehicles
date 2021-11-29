using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    public class VehiclePhoto
    {
        public int Id { get; set; }

        [Required( ErrorMessage = "El campo {0} es obigatorio.")]
        public Vehicle Vehicle { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        [Display(Name = "Foto")]
        public String ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44352/images/no-image.png"
            : $"https://localhost:44352/images/vehicles/{ImageId}.jpg";
    }
}
