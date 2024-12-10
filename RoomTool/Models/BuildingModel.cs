using System.Collections.Generic;

namespace RoomTool.Models;

public class BuildingModel
{
    /// <summary>
    /// Key - Number of floor, Value - apartments on floor
    /// </summary>
    public Dictionary<string, string[]> ApartmentsByFloor;

    /// <summary>
    ///  All apartments in building
    /// </summary>
    public string[] Apartments;
}