using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Helpers
{
    public class BlobHelper : IBlobHelper
    {

        public Task<Guid> UploadBlobAsync(IFormFile imageFile, string folder)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> UploadBlobAsync(byte[] file, string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> UploadBlobAsync(string image, string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> UploadBlobAsync(Guid id, string containerName)
        {
            throw new NotImplementedException();
        }
        public bool DeleteImageAsync(string imageId, string folder)
        {
            string path = Directory.GetCurrentDirectory() + "//wwwroot//images//" + folder + "//" + imageId + ".jpg";
            try
            {
                File.Delete(path);
                return true;
            }
            catch { return false; }
        }

        public async Task<Guid> UploadImageAsync(IFormFile imageFile, string folder)
        {
            Guid gGuid = Guid.NewGuid();
            string guid = gGuid.ToString();
            string file = $"{guid}.jpg";
            string path = Path.Combine(
                Directory.GetCurrentDirectory(),
                $"wwwroot\\images\\{folder}",
                file);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);

            }
            return gGuid;
            //return $"~/images/{folder}/{file}";
        }
    }
}
