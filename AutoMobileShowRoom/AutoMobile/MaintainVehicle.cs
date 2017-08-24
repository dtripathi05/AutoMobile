using System.Collections.Generic;

namespace AutoMobile
{
    public class MaintainVehicle : IService
    {
        Vehicle vehicle = null;
        public void service(Vehicle vehicle)
        {
             this.vehicle=vehicle;
        }
    }

}
