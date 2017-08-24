using System.Collections.Generic;

namespace AutoMobile
{
    public class RentVehicle : IService
    {
        Vehicle vehicle = null;
        public void service(Vehicle vehicle)
        {
            if (vehicle.Fresh == false)
            {
               this.vehicle= vehicle;
            }
            else
            throw new OldVehicleException("The Vehicle You Are Trying To Rent is New");
        }
    }

}
