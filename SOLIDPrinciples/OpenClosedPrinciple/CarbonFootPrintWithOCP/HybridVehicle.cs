

namespace SOLIDPrinciples.OpenClosedPrinciple.CarbonFootPrintWithOCP
{
    class HybridVehicle : IVehicle
    {
        public const double HybridCarbonFootPrintEmissionFactor = 10.5;
        public double CalculateCarbonFootPrint(double averageFuelComsumed)
            => HybridCarbonFootPrintEmissionFactor * averageFuelComsumed;
         
    }
}
