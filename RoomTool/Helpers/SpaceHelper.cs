using System;
using System.Collections.Generic;
using System.Linq;
using BIMStructureMgd.DatabaseObjects;
using BIMStructureMgd.ObjectProperties;
using HostMgd.ApplicationServices;
using HostMgd.EditorInput;
using RoomTool.Models;
using Teigha.DatabaseServices;

namespace RoomTool.Helpers;

public static class SpaceHelper
{
    public static Database db;
    public static Document doc;
    public static BuildingModel GetBuildingModel()
    {
        var allSpaces = GetAllSpaces();
        var floors = GetFloors(allSpaces);

        var apartmentsByFloor = new Dictionary<string, List<string>>();

        foreach (var floor in floors)
        {
            apartmentsByFloor[floor] = new List<string>();
        }

        foreach (var space in allSpaces!)
        {
            var currentFloor = space.GetElementData().GetParameter("AEC_ELEMENT_RELELEV_BASE").Value;
            apartmentsByFloor[currentFloor].Add(space.Name);
        }

        var buildingModel = new BuildingModel
        {
            ApartmentsByFloor = apartmentsByFloor.ToDictionary(x => x.Key, x => x.Value.ToArray()),
            Apartments = apartmentsByFloor.SelectMany(x => x.Value).ToArray()
        };

        return buildingModel;
    }
    
    public static List<SpaceEntity>? GetAllSpaces()
    {
        using var tr = db.TransactionManager.StartTransaction();

        var selectionAll = doc.Editor.SelectAll();
        if(selectionAll.Status != PromptStatus.OK) return null;

        var allObj = selectionAll.Value;

        return allObj
            .OfType<SelectedObject>()
            .Select(obj => tr.GetObject(obj.ObjectId, OpenMode.ForWrite))
            .OfType<SpaceEntity>()
            .ToList();
    }

    public static SpaceEntity? GetSpaceFromDbByName(string name)
    {
        using var tr = db.TransactionManager.StartTransaction();
        var allSpaces = doc.Editor.SelectAll().Value
            .OfType<SelectedObject>()
            .Select(x => tr.GetObject(x.ObjectId, OpenMode.ForWrite))
            .OfType<SpaceEntity>();
        
        var space = allSpaces.FirstOrDefault(x => x.Name == name);

        return space;
    }

    public static SpaceEntity? GetSpaceFromDb(ObjectId id)
    {
        using var tr = db.TransactionManager.StartTransaction();
        var spaceEntity = tr.GetObject(id, OpenMode.ForWrite) as SpaceEntity;
        return spaceEntity;
    }
    
    public static List<Parameter>? GetSpaceEntityParams(Database db, ObjectId id)
    {
        var space = GetSpaceFromDb(id);
        var param = space?.GetElementData().Parameters.ToList();
        return param;
    }
    
    // public static List<Parameter>? GetValuableSpaceEntityParams(Database db, ObjectId id)
    // {
    //     var param = GetSpaceEntityParams(db, id);
    //     var valuable = param?.Where(x => x.Value != "").ToList();
    //     return valuable;
    // }
    
    private static string[] GetFloors(List<SpaceEntity>? spaces)
    {
        using var tr = db.TransactionManager.StartTransaction();
        var floors = new string[spaces.Count];
        for (var i = 0; i < spaces.Count; i++)
        {
            var baseLevel = spaces[i].GetElementData().GetParameter("AEC_ELEMENT_RELELEV_BASE").Value;
            floors[i] = baseLevel;
        }

        return floors;
    }
}