

namespace SOLIDPrinciples.OpenClosedPrinciple.CarbonFootPrintWithOCP
{
    class DieselVehicle : IVehicle
    {
        public const double DieselCarbonFootPrintEmissionFactor = 12.9;
        public double CalculateCarbonFootPrint(double averageFuelComsumed)
            => DieselCarbonFootPrintEmissionFactor * averageFuelComsumed;
    }
}
