using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLIDCars.Vehicles;

namespace SOLIDCars
{
    class Program
    {
        static void Main(string[] args)
        {

            // Build a collection of all vehicles that fly
            var blueAngel = new AirBasedVehicles
            {
                Name = "Blue Angel",
                Wheels = 3,
                Doors = 1,
                PassengerCapacity = 2,
                Winged = true,
                MaxAirSpeed = 700
            };

            var boeing747 = new AirBasedVehicles
            {
                Name = "Boeing 747",
                Wheels = 3,
                Doors = 8,
                PassengerCapacity = 150,
                Winged = true,
                MaxAirSpeed = 570
            };

            var aircrafts = new List<AirBasedVehicles>();
            aircrafts.Add(blueAngel);
            aircrafts.Add(boeing747);

            // With a single `foreach`, have each vehicle Fly()
            foreach (var aircraft in aircrafts)
            {
                aircraft.Fly();
            }



            // Build a collection of all vehicles that operate on roads
            var gsxr600 = new LandBasedVehicle
            {
                Name = "Suzuki GSXR 600",
                Wheels = 2,
                PassengerCapacity = 2,
                TransmissionType = "Manual",
                EngineVolume = 600.00,
                MaxLandSpeed = 150
            };

            var cbr300 = new LandBasedVehicle
            {
                Name = "Honda CBR 300",
                Wheels = 2,
                PassengerCapacity = 2,
                TransmissionType = "Manual",
                EngineVolume = 300.00,
                MaxLandSpeed = 110
            };

            var landMachines = new List<LandBasedVehicle>();
            landMachines.Add(gsxr600);
            landMachines.Add(cbr300);

            // With a single `foreach`, have each road vehicle Drive()
            foreach (var landMachine in landMachines)
            {
                landMachine.Drive();
            }


            // Build a collection of all vehicles that operate on water
            var speedBoat = new WaterBasedVehicle
            {
                Name = "Speed Boat",
                PassengerCapacity = 6,
                TransmissionType = "Automatic",
                MaxWaterSpeed = 80.50
            };

            var yacht = new WaterBasedVehicle
            {
                Name = "Yacht",
                PassengerCapacity = 15,
                TransmissionType = "Advanced",
                MaxWaterSpeed = 50.70
            };

            var waterBeauties = new List<WaterBasedVehicle>();
            waterBeauties.Add(speedBoat);
            waterBeauties.Add(yacht);

            // With a single `foreach`, have each water vehicle Drive()
            foreach (var waterBeauty in waterBeauties)
            {
                waterBeauty.Drive();
            }




            Console.ReadLine();

        }
    }
}
