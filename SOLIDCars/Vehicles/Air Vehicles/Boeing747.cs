using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCars.Vehicles.Air_Vehicles
{
    class Boeing747 : IVehicle
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine($"The {Name}'s original nickname was Jumbo Jet. They are used for commercial airflights.");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
