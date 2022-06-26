

namespace SOLIDPrinciples.OpenClosedPrinciple.CarbonFootPrintWithOCP
{
    class ElectricVehicle : IVehicle
    {
        public const double ElectricCarbonFootPrintEmissionFactor = 4.5;
        public double CalculateCarbonFootPrint(double averageFuelComsumed)
            => ElectricCarbonFootPrintEmissionFactor * averageFuelComsumed;
    }
}
