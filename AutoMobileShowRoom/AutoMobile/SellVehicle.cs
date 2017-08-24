using System.Collections.Generic;

namespace AutoMobile
{
    public class SellVehicle : IService
    {
        Vehicle vehicle=null;
        public void  service(Vehicle vehicle)
        {
            if (vehicle.Fresh == true)
            {
                this.vehicle = vehicle;
            }
            else
                throw new OldVehicleException("The Vehicle You Are Trying To Purchase is Old");
        }
    }

}
