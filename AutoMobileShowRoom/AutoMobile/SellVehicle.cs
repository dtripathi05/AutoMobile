using System.Collections.Generic;

namespace AutoMobile
{
    public class SellVehicle : IService
    {
        List<Vehicle> soldVehicle = new List<Vehicle>();
        public void service(Vehicle vehicle)
        {
            if (vehicle.Fresh == true)
            {
                soldVehicle.Add(vehicle);
            }
            else
                throw new OldVehicleException("The Vehicle You Are Trying To Purchase is Old");
        }
    }

}
