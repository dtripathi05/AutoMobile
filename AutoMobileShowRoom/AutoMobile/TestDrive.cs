using System.Collections.Generic;

namespace AutoMobile
{
    public class TestDrive : IService
    {
        Vehicle vehicle = null;
        public void service(Vehicle vehicle)
        {
             this.vehicle=vehicle;
        }
    }

}
