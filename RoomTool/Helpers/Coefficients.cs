using System.Collections.Generic;
using Teigha.Runtime;

namespace RoomTool.Helpers;

public static class Coefficients
{
    public static Dictionary<string, double> CoefficientsDictionary = new()
    {
        { "LivingSpacesApartments", 1.0 },
        { "UnlivingSpacesApartments", 1.0 },
        { "Logia", 0.5 },
        { "BalconyOrTerrace", 0.3 },
        { "UnlivingSpacesPublic", 1.0 },
        { "Offices", 1.0 },
        { "WarmLogia", 1.0 },
    };
}