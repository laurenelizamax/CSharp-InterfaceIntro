namespace interfaceIntro
{
    public class Prius : IVehicle, IGasVehicle, IElectricVehicle
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }
        public int BatterykWh { get; set; }

        public void ChargeBattery()
        {

        }

        public void Drive()
        {
        }

        public void RefuelTank()
        {
        }
    }
}