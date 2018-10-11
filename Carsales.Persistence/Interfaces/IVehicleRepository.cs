using System.Collections.Generic;
using System.Text;

namespace Carsales.Persistence
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetVehicles();
        Vehicle GetVehicle(int id);
        void CreateVehicle(Vehicle vehicle);

    }
}
