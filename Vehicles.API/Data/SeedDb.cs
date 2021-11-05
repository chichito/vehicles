using System;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckVehiclesTypeAsync();
            await CheckBrandsAsync();
            await CheckDocumentTypeAsync();
            await CheckProcedureAsync();
        }

        private async Task CheckProcedureAsync()
        {
            if (!_context.Procedures.Any())
            {
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Alineación" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Lubricación de suspención delantera" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Lubricación de suspención trasera" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Frenos delanteros" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Frenos traseros" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Liquido frenos delanteros" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Liquido frenos traseros" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Calibración de válvulas" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Alineación carburador" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Aceite motor" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Aceite caja" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Filtro de aire" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Sistema el{ectrico" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Guayas" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Cambio de llanta delantera" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Cambio de llanta trasera" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "reparación de motor" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Kit arrastre" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Banda transmisión" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Cambio batería" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Lavado sistema de inyección" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Lavado de tanque" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Cambio de bujia" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Cambio rodamiento delantero" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Cambio rodamiento trasero" });
                _context.Procedures.Add(new Procedure { Price = 1000, Description = "Accesorios" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckDocumentTypeAsync()
        {
            if (!_context.DocumentTypes.Any())
            {
                _context.DocumentTypes.Add(new DocumentType { Description = "Cédula" });
                _context.DocumentTypes.Add(new DocumentType { Description = "Tarjeta de Identidad" });
                _context.DocumentTypes.Add(new DocumentType { Description = "NIT" });
                _context.DocumentTypes.Add(new DocumentType { Description = "Pasaporte" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckBrandsAsync()
        {
            if (!_context.Brands.Any())
            {
                _context.Brands.Add(new Brand { Description = "Ducati" });
                _context.Brands.Add(new Brand { Description = "Harley Davison" });
                _context.Brands.Add(new Brand { Description = "KTM" });
                _context.Brands.Add(new Brand { Description = "BMW" });
                _context.Brands.Add(new Brand { Description = "Triumph" });
                _context.Brands.Add(new Brand { Description = "Victoria" });
                _context.Brands.Add(new Brand { Description = "Honda" });
                _context.Brands.Add(new Brand { Description = "Suzuki" });
                _context.Brands.Add(new Brand { Description = "Kawasaky" });
                _context.Brands.Add(new Brand { Description = "TVS" });
                _context.Brands.Add(new Brand { Description = "Bajaj" });
                _context.Brands.Add(new Brand { Description = "AKT" });
                _context.Brands.Add(new Brand { Description = "Yamaha" });
                _context.Brands.Add(new Brand { Description = "Chevrolet" });
                _context.Brands.Add(new Brand { Description = "Mazda" });
                _context.Brands.Add(new Brand { Description = "Renault" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckVehiclesTypeAsync()
        {
            if (!_context.VehicleTypes.Any())
            {
                _context.VehicleTypes.Add(new VehicleType { Description = "Carro" });
                _context.VehicleTypes.Add(new VehicleType { Description = "Moto" });
                await _context.SaveChangesAsync();
            }
        }

    }
}
