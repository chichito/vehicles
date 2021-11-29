using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Helpers
{
    public interface IBlobHelper
    {
        Task<Guid> UploadBlobAsync(IFormFile file, string containerName);
        Task<Guid> UploadBlobAsync(byte[] file, string containerName);
        Task<Guid> UploadBlobAsync(string image, string containerName);
        Task<Guid> UploadBlobAsync(Guid id, string containerName);
        bool DeleteImageAsync(string imageId, string folder);
        Task<Guid> UploadImageAsync(IFormFile imageFile, string folder);
    }
}
