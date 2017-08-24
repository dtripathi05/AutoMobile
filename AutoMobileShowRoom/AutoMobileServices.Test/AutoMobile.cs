using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMobile;
namespace AutoMobileServices.Test
{
    [TestClass]
    public class AutoMobile
    {
        [TestMethod]
        public void Provide_The_Service_Customer_want()
        {
            Vehicle vehicle1 = new Vehicle("Alto",250000,"FourWheeler","UP 26 ac 2555",false);
            Vehicle vehicle2 = new Vehicle("Pulsor", 50000, "TwoWheeler", "UP 26 dc 2533", true);
            IService service = IServiceFactory.GetService("Maintain");
            InVoice invoice = new InVoice("123",  DateTime.Now, 1000); 
            ServiceManager manager = new ServiceManager(invoice);

        }
    }
}
