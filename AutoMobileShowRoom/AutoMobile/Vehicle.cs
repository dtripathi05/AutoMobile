namespace AutoMobile
{
    public class Vehicle
    {
        public string Name{ get; }
        public double Price { get; }
        public string  Type { get; }
        public string VehicleNumber { get; }
        public bool Fresh { get; }
        public Vehicle(string name,double price,string type,string vehicleNumber,bool fresh)
        {
            Name = name;
            Price = price;
            Type = type;
            VehicleNumber = vehicleNumber;
            Fresh = fresh;
        }
    }

}
