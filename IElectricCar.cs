namespace interfaceIntro
{
    public interface IElectricVehicle
    {
        int BatterykWh { get; set; }
        void ChargeBattery();
    }
}