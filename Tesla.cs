using System;

namespace interfaceIntro
{
    public class Tesla : IVehicle, IElectricVehicle
    {
        public int BatterykWh { get; set; }

        public void ChargeBattery()
        {
            BatterykWh = 100;
        }

        public void Drive()
        {
            Console.WriteLine("Vroom!");
        }
    }
}