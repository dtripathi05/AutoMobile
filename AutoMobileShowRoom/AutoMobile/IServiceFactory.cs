using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobile
{

    public class IServiceFactory
    {
        public static IService GetService(string type)
        {
            Dictionary<string, IService> service = new Dictionary<string, IService>();
            MaintainVehicle maintain = new MaintainVehicle();
            SellVehicle sell = new SellVehicle();
            RentVehicle rent = new RentVehicle();
            TestDrive testVehicle = new TestDrive();
            service.Add("Maintain", maintain);
            service.Add("Sell", sell);
            service.Add("Rent", rent);
            service.Add("Test", testVehicle);
            IService result = null;
            service.TryGetValue(type, out result);
            return result;
        }
    }
    public class ServiceManager
    {
        double total = 0;
        public InVoice InVoice { get; }
        Dictionary<IService,InVoice> totalService = new Dictionary<IService, InVoice>();
        public void TotalServices(IService service,InVoice invoice,Vehicle vehicle)
        {
            service.service(vehicle);
            totalService.Add(service,invoice);
        }
        //public ServiceManager(InVoice inVoice)
        //{
        //    InVoice = inVoice;
        //}
        public Dictionary<IService,InVoice> GetTotalServices()
        {
            return totalService;
        }
        public double DailyIncome()
        {
            var Keys = totalService.Keys;
            foreach (var Item in Keys)
            {
                total +=  totalService[Item].InvoiceAmount;
            }
            return total;
        }
    }
    public class InVoice
    {
        public string InVoiceNumber { get; }
        public DateTime DateTime { get; }
        public double InvoiceAmount { get; }
        public InVoice(string inVoiceNo,DateTime dateTime,double amount)
        {
            InvoiceAmount = amount;
            DateTime = dateTime;
            InVoiceNumber = inVoiceNo;
        }
    }
}
