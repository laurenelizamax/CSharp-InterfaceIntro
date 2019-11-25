using System;
using System.Collections.Generic;

namespace interfaceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGasVehicle> gasFacility = new List<IGasVehicle>();
            List<IElectricVehicle> chargingFacility = new List<IElectricVehicle>();
            List<IVehicle> testDriveLot = new List<IVehicle>();

            // Instance of a tesla class, we treat it as an ielectricvehicle
            var myTesla = new Tesla();
            var myCessna = new Cessna();
            var myRam = new Ram();
            var myZero = new Zero();
            var myPrius = new Prius();

            gasFacility.Add(myRam);
            gasFacility.Add(myCessna);
            gasFacility.Add(myPrius);

            chargingFacility.Add(myTesla);
            chargingFacility.Add(myZero);
            chargingFacility.Add(myPrius);

            testDriveLot.Add(myTesla);
            testDriveLot.Add(myRam);
            testDriveLot.Add(myZero);
            testDriveLot.Add(myCessna);
            testDriveLot.Add(myPrius);


            foreach (var vehicle in chargingFacility)
            {
                vehicle.ChargeBattery();
            }

            foreach (var vehicle in testDriveLot)
            {
                vehicle.Drive();
            }
        }
    }
}
