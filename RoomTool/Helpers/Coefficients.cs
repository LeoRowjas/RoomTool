using System.Collections.Generic;
using Teigha.Runtime;

namespace RoomTool.Helpers;

public static class Coefficients
{
    public static Dictionary<string, double> CoefficientsDictionary = new()
    {
        { "Жилые помещения квартиры", 1 },
        { "нежилые помещения квартир", 1 },
        { "лоджия", 0.5 },
        { "балкон, терраса", 0.3 },
        { "нежилые помещения общественные", 1 },
        { "офисы", 1 },
        { "Теплые лоджии", 1 },
    };
}