using System;
using System.Collections.Generic;

namespace SOLIDPrinciples.OpenClosedPrinciple.CarbonFootPrintWithoutOCP
{
    class CarbonFootPrintCalculater
    {
        public void TotalCarbonFootPrintEmission(List<object> vehicles, double averageFuelComsumed)
        {
            double totalCarbonFootPrintEmission = 0;
            foreach (var vehicle in vehicles)
            {
                if(vehicle is DieselVehicle)
                    totalCarbonFootPrintEmission += DieselVehicle.DieselCarbonFootPrintEmissionFactor * averageFuelComsumed;
                else if(vehicle is ElectricVehicle)
                    totalCarbonFootPrintEmission += ElectricVehicle.ElectricCarbonFootPrintEmissionFactor * averageFuelComsumed;
                else
                    totalCarbonFootPrintEmission += HybridVehicle.HybridCarbonFootPrintEmissionFactor * averageFuelComsumed;
            }
            Console.WriteLine($"Total CO2 Emission is {totalCarbonFootPrintEmission}");
        }
    }
}
