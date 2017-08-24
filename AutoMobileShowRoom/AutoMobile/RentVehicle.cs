using System.Collections.Generic;

namespace AutoMobile
{
    public class RentVehicle : IService
    {
       
        public Vehicle service(Vehicle vehicle)
        {
            if (vehicle.Fresh == false)
            {
                return vehicle;
            }else
            throw new OldVehicleException("The Vehicle You Are Trying To Rent is New");
        }
    }

}
