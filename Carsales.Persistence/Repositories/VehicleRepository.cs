using System;
using System.Collections.Generic;
using System.Linq;

namespace Carsales.Persistence
{
    class VehicleRepository : IVehicleRepository
    {
        private readonly VehiclesDbContext _context;


        public VehicleRepository(VehiclesDbContext context)
        {
            _context = context;
        }

        public List<Vehicle> GetVehicles()
        {
            return _context.Vehicles.ToList();
        }

        public Vehicle GetVehicle(int id)
        {
            var vehicle = _context.Vehicles.Find(id);
            return vehicle;
        }

        public void CreateVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
        }
    }
}