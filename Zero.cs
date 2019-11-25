using System;

namespace interfaceIntro
{
    public class Zero : IVehicle, IElectricVehicle
    {
        public int BatterykWh { get; set; }

        public void ChargeBattery()
        {
            BatterykWh = 150;
        }

        public void Drive()
        {
            Console.Write("Woooosh");
        }
    }
}