using System;
using System.Collections.Generic;

namespace SOLIDPrinciples.OpenClosedPrinciple.CarbonFootPrintWithOCP
{
    class CarbonFootPrintCalculator
    {
        public void TotalCarbonFootPrintEmission(List<IVehicle> vehicles, double averageFuelComsumed)
        {
            double totalCarbonFootPrintEmission = 0;
            foreach (var vehicle in vehicles)
            {
                totalCarbonFootPrintEmission += vehicle.CalculateCarbonFootPrint(averageFuelComsumed);
            }
            Console.WriteLine($"Total CO2 Emission is {totalCarbonFootPrintEmission}");
        }
    }
}
